// Copyright 2022 Google LLC
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

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gcvsv = Google.Cloud.Video.Stitcher.V1;
using sys = System;

namespace Google.Cloud.Video.Stitcher.V1
{
    /// <summary>Resource name for the <c>Slate</c> resource.</summary>
    public sealed partial class SlateName : gax::IResourceName, sys::IEquatable<SlateName>
    {
        /// <summary>The possible contents of <see cref="SlateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/slates/{slate}</c>.
            /// </summary>
            ProjectLocationSlate = 1,
        }

        private static gax::PathTemplate s_projectLocationSlate = new gax::PathTemplate("projects/{project}/locations/{location}/slates/{slate}");

        /// <summary>Creates a <see cref="SlateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SlateName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SlateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SlateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SlateName"/> with the pattern <c>projects/{project}/locations/{location}/slates/{slate}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="slateId">The <c>Slate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SlateName"/> constructed from the provided ids.</returns>
        public static SlateName FromProjectLocationSlate(string projectId, string locationId, string slateId) =>
            new SlateName(ResourceNameType.ProjectLocationSlate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), slateId: gax::GaxPreconditions.CheckNotNullOrEmpty(slateId, nameof(slateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SlateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/slates/{slate}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="slateId">The <c>Slate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SlateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/slates/{slate}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string slateId) =>
            FormatProjectLocationSlate(projectId, locationId, slateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SlateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/slates/{slate}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="slateId">The <c>Slate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SlateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/slates/{slate}</c>.
        /// </returns>
        public static string FormatProjectLocationSlate(string projectId, string locationId, string slateId) =>
            s_projectLocationSlate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(slateId, nameof(slateId)));

        /// <summary>Parses the given resource name string into a new <see cref="SlateName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/slates/{slate}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="slateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SlateName"/> if successful.</returns>
        public static SlateName Parse(string slateName) => Parse(slateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SlateName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/slates/{slate}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="slateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SlateName"/> if successful.</returns>
        public static SlateName Parse(string slateName, bool allowUnparsed) =>
            TryParse(slateName, allowUnparsed, out SlateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SlateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/slates/{slate}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="slateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SlateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string slateName, out SlateName result) => TryParse(slateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SlateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/slates/{slate}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="slateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SlateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string slateName, bool allowUnparsed, out SlateName result)
        {
            gax::GaxPreconditions.CheckNotNull(slateName, nameof(slateName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSlate.TryParseName(slateName, out resourceName))
            {
                result = FromProjectLocationSlate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(slateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SlateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string slateId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SlateId = slateId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SlateName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/slates/{slate}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="slateId">The <c>Slate</c> ID. Must not be <c>null</c> or empty.</param>
        public SlateName(string projectId, string locationId, string slateId) : this(ResourceNameType.ProjectLocationSlate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), slateId: gax::GaxPreconditions.CheckNotNullOrEmpty(slateId, nameof(slateId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Slate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SlateId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSlate: return s_projectLocationSlate.Expand(ProjectId, LocationId, SlateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SlateName);

        /// <inheritdoc/>
        public bool Equals(SlateName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SlateName a, SlateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SlateName a, SlateName b) => !(a == b);
    }

    public partial class Slate
    {
        /// <summary>
        /// <see cref="gcvsv::SlateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::SlateName SlateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::SlateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
