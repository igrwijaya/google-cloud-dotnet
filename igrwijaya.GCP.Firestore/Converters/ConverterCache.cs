﻿// Copyright 2018, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Type;
using BclType = System.Type;
using DateTime = System.DateTime;
using Value = Google.Cloud.Firestore.V1.Value;
using wkt = Google.Protobuf.WellKnownTypes;

namespace igrwijaya.GCP.Firestore.Converters
{
    /// <summary>
    /// A cache for serializers based on the target type. Some are prepopulated (e.g. for protos and
    /// primitives); one for anonymous and attributed types are added on demand.
    /// </summary>
    internal static class ConverterCache
    {
        private static readonly ConcurrentDictionary<BclType, IFirestoreInternalConverter> s_converters =
            new ConcurrentDictionary<BclType, IFirestoreInternalConverter>
            {
                [typeof(byte)] = new ByteConverter(),
                [typeof(sbyte)] = new SByteConverter(),
                [typeof(short)] = new Int16Converter(),
                [typeof(ushort)] = new UInt16Converter(),
                [typeof(int)] = new Int32Converter(),
                [typeof(uint)] = new UInt32Converter(),
                [typeof(long)] = new Int64Converter(),
                [typeof(ulong)] = new UInt64Converter(),
                [typeof(string)] = new StringConverter(),
                [typeof(float)] = new SingleConverter(),
                [typeof(double)] = new DoubleConverter(),
                [typeof(bool)] = new BooleanConverter(),
                [typeof(Timestamp)] = new TimestampConverter(),
                [typeof(GeoPoint)] = new GeoPointConverter(),
                [typeof(Blob)] = new BlobConverter(),
                [typeof(ByteString)] = new ByteStringConverter(),
                [typeof(byte[])] = new ByteArrayConverter(),
                [typeof(SentinelValue)] = new SentinelValueConverter(),
                [typeof(DateTime)] = new DateTimeConverter(),
                [typeof(DateTimeOffset)] = new DateTimeOffsetConverter(),
                [typeof(Value)] = new ValueConverter(),
                [typeof(wkt::Timestamp)] = new TimestampProtoConverter(),
                [typeof(LatLng)] = new LatLngConverter(),
                [typeof(Dictionary<string, object>)] = new DictionaryConverter<object>(typeof(Dictionary<string, object>)),
                [typeof(IDictionary<string, object>)] = new DictionaryConverter<object>(typeof(Dictionary<string, object>)),
                [typeof(DocumentReference)] = new DocumentReferenceConverter()
            };

        internal static IFirestoreInternalConverter GetConverter(BclType targetType) =>
            s_converters.GetOrAdd(targetType, t => CreateConverter(t));

        private static readonly MethodInfo s_createDictionaryConverter = typeof(ConverterCache).GetMethod(nameof(CreateDictionaryConverter), BindingFlags.Static | BindingFlags.NonPublic);

        private static IFirestoreInternalConverter CreateDictionaryConverter<T>(BclType targetType) => new DictionaryConverter<T>(targetType);

        private static IFirestoreInternalConverter CreateConverter(BclType targetType)
        {
            var targetTypeInfo = targetType.GetTypeInfo();
            if (targetType.IsArray)
            {
                return new ArrayConverter(targetType.GetElementType());
            }
            if (targetTypeInfo.IsDefined(typeof(FirestoreDataAttribute)))
            {
                return AttributedTypeConverter.ForType(targetType);
            }
            // Simple way of checking for an anonymous type. Far from foolproof, but a reasonable start.
            // If the target type implements IEnumerable, it's probably an iterator method result.
            // If the target type implements IAsyncStateMachine, it's probably an async method state machine.
            if (targetTypeInfo.IsDefined(typeof(CompilerGeneratedAttribute)) &&
                !typeof(IEnumerable).IsAssignableFrom(targetType) &&
                !typeof(IAsyncStateMachine).IsAssignableFrom(targetType))
            {
                return new AnonymousTypeConverter(targetType);
            }

            if (targetTypeInfo.IsEnum)
            {
                return new EnumConverter(targetType);
            }
            if (TryGetStringDictionaryValueType(targetType) is BclType dictionaryElementType)
            {
                var method = s_createDictionaryConverter.MakeGenericMethod(dictionaryElementType);
                try
                {
                    return (IFirestoreInternalConverter) method.Invoke(null, new object[] { targetType });
                }
                catch (TargetInvocationException e) when (e.InnerException != null)
                {
                    throw e.InnerException;
                }
            }

            // This will only return true if the target type can be assigned
            // from List<T>, and the target type implements IEnumerable<T>. That's
            // enough to make ListConverter work: when serializing, it will just use
            // IEnumerable, and when deserializing it will construct a List<T>.
            if (TryGetListType(targetType) is BclType listType)
            {
                return new ListConverter(listType);
            }

            if (typeof(IList).IsAssignableFrom(targetType))
            {
                return new ListConverter(targetType);
            }

            // The best we can do is a "serialize-only" converter. That's better than nothing though.
            if (typeof(IEnumerable).IsAssignableFrom(targetType))
            {
                return new SequenceConverter(targetType);
            }

            throw new ArgumentException($"Unable to create converter for type {targetType.GetTypeInfo().FullName}");
        }

        // Internal for testing

        /// <summary>
        /// If <paramref name="type"/> implements (or is) <see cref="IDictionary{TKey, TValue}"/> with TKey equal to string, returns TValue.
        /// Otherwise, returns null.
        /// </summary>
        internal static BclType TryGetStringDictionaryValueType(BclType type)
        {
            return type.GetTypeInfo()
                .GetInterfaces()
                .Concat(new[] { type }) // Make this method handle IDictionary<,> as an input; GetInterfaces doesn't return the type you call it on
                .Select(MapInterfaceToDictionaryValueTypeArgument).FirstOrDefault(t => t != null);

            BclType MapInterfaceToDictionaryValueTypeArgument(BclType iface)
            {
                var ifaceInfo = iface.GetTypeInfo();
                if (!ifaceInfo.IsGenericType || ifaceInfo.IsGenericTypeDefinition)
                {
                    return null;
                }
                var generic = ifaceInfo.GetGenericTypeDefinition();
                if (generic != typeof(IDictionary<,>))
                {
                    return null;
                }
                var typeArguments = ifaceInfo.GenericTypeArguments;
                return typeArguments[0] == typeof(string) ? typeArguments[1] : null;
            }
        }

        /// <summary>
        /// If <paramref name="targetType"/> is a type that implements <see cref="IEnumerable{T}"/>, we check to see if <see cref="List{T}"/> is
        /// compatible with the target type. 
        /// </summary>
        /// <param name="targetType"></param>
        /// <returns>null if <paramref name="targetType"/> cannot be implemented via <see cref="List{T}"/>; the list type otherwise.</returns>
        internal static BclType TryGetListType(BclType targetType)
        {
            var elementType = targetType.GetTypeInfo()
                .GetInterfaces()
                .Concat(new[] { targetType }) // Make this method handle IDictionary<,> as an input; GetInterfaces doesn't return the type you call it on
                .Select(MapInterfaceToTypeArgument).FirstOrDefault(t => t != null);
            if (elementType is null)
            {
                return null;
            }
            var candidateType = typeof(List<>).MakeGenericType(elementType);
            return targetType.IsAssignableFrom(candidateType) ? candidateType : null;

            BclType MapInterfaceToTypeArgument(BclType iface)
            {
                var ifaceInfo = iface.GetTypeInfo();
                if (!ifaceInfo.IsGenericType || ifaceInfo.IsGenericTypeDefinition)
                {
                    return null;
                }
                var generic = ifaceInfo.GetGenericTypeDefinition();
                if (generic != typeof(IEnumerable<>))
                {
                    return null;
                }
                return ifaceInfo.GenericTypeArguments[0];
            }
        }
    }
}
