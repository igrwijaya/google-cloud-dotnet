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
using System.Collections.Generic;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Type;
using BclType = System.Type;
using Value = Google.Cloud.Firestore.V1.Value;
using wkt = Google.Protobuf.WellKnownTypes;

namespace igrwijaya.GCP.Firestore.Converters
{
    /// <summary>
    /// A base class for many converters, allowing them to simply override the method for the one
    /// deserialization case required. Serializing to a single value has to be implemented; serializing
    /// to a map will fail with an exception unless <see cref="SerializeMap(SerializationContext, object, IDictionary{string, Value})"/>
    /// is overridden.
    /// </summary>
    internal abstract class ConverterBase : IFirestoreInternalConverter
    {
        protected BclType TargetType { get; }

        protected ConverterBase(BclType targetType)
        {
            TargetType = targetType;
        }

        public virtual object DeserializeMap(DeserializationContext context, IDictionary<string, Value> values) =>
            throw new ArgumentException($"Unable to convert map value to {TargetType}");

        public virtual object DeserializeValue(DeserializationContext context, Value value)
        {
            switch (value.ValueTypeCase)
            {
                case Value.ValueTypeOneofCase.ArrayValue:
                    return DeserializeArray(context, value.ArrayValue.Values);
                case Value.ValueTypeOneofCase.BooleanValue:
                    return DeserializeBoolean(context, value.BooleanValue);
                case Value.ValueTypeOneofCase.BytesValue:
                    return DeserializeBytes(context, value.BytesValue);
                case Value.ValueTypeOneofCase.DoubleValue:
                    return DeserializeDouble(context, value.DoubleValue);
                case Value.ValueTypeOneofCase.GeoPointValue:
                    return DeserializeGeoPoint(context, value.GeoPointValue);
                case Value.ValueTypeOneofCase.IntegerValue:
                    return DeserializeInteger(context, value.IntegerValue);
                case Value.ValueTypeOneofCase.MapValue:
                    return DeserializeMap(context, value.MapValue.Fields);
                case Value.ValueTypeOneofCase.ReferenceValue:
                    return DeserializeReference(context, value.ReferenceValue);
                case Value.ValueTypeOneofCase.StringValue:
                    return DeserializeString(context, value.StringValue);
                case Value.ValueTypeOneofCase.TimestampValue:
                    return DeserializeTimestamp(context, value.TimestampValue);
                default:
                    throw new ArgumentException($"Unable to convert value type {value.ValueTypeCase}");
            }
        }

        public abstract Value Serialize(SerializationContext context, object value);

        public virtual void SerializeMap(SerializationContext context, object value, IDictionary<string, Value> map) =>
            throw new ArgumentException($"Unable to convert {TargetType} to a map");

        protected virtual object DeserializeArray(DeserializationContext context, RepeatedField<Value> values) =>
            throw new ArgumentException($"Unable to convert array value to {TargetType}");

        protected virtual object DeserializeBoolean(DeserializationContext context, bool value) =>
            throw new ArgumentException($"Unable to convert Boolean value to {TargetType}");

        protected virtual object DeserializeBytes(DeserializationContext context, ByteString value) =>
            throw new ArgumentException($"Unable to convert bytes value to {TargetType}");

        protected virtual object DeserializeDouble(DeserializationContext context, double value) =>
            throw new ArgumentException($"Unable to convert double value to {TargetType}");

        protected virtual object DeserializeGeoPoint(DeserializationContext context, LatLng value) =>
            throw new ArgumentException($"Unable to convert LatLng value to {TargetType}");

        protected virtual object DeserializeInteger(DeserializationContext context, long value) =>
            throw new ArgumentException($"Unable to convert integer value to {TargetType}");

        protected virtual object DeserializeReference(DeserializationContext context, string value) =>
            throw new ArgumentException($"Unable to convert reference value to {TargetType}");

        protected virtual object DeserializeString(DeserializationContext context, string value) =>
            throw new ArgumentException($"Unable to convert string value to {TargetType}");

        protected virtual object DeserializeTimestamp(DeserializationContext context, wkt::Timestamp value) =>
            throw new ArgumentException($"Unable to convert Timestamp value to {TargetType}");
    }
}
