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
using gcav = Google.Cloud.ArtifactRegistry.V1;
using sys = System;

namespace Google.Cloud.ArtifactRegistry.V1
{
    /// <summary>Resource name for the <c>YumArtifact</c> resource.</summary>
    public sealed partial class YumArtifactName : gax::IResourceName, sys::IEquatable<YumArtifactName>
    {
        /// <summary>The possible contents of <see cref="YumArtifactName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/yumArtifacts/{yum_artifact}</c>.
            /// </summary>
            ProjectLocationRepositoryYumArtifact = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryYumArtifact = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/yumArtifacts/{yum_artifact}");

        /// <summary>Creates a <see cref="YumArtifactName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="YumArtifactName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static YumArtifactName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new YumArtifactName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="YumArtifactName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/yumArtifacts/{yum_artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="yumArtifactId">The <c>YumArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="YumArtifactName"/> constructed from the provided ids.</returns>
        public static YumArtifactName FromProjectLocationRepositoryYumArtifact(string projectId, string locationId, string repositoryId, string yumArtifactId) =>
            new YumArtifactName(ResourceNameType.ProjectLocationRepositoryYumArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), yumArtifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(yumArtifactId, nameof(yumArtifactId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="YumArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/yumArtifacts/{yum_artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="yumArtifactId">The <c>YumArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="YumArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/yumArtifacts/{yum_artifact}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string yumArtifactId) =>
            FormatProjectLocationRepositoryYumArtifact(projectId, locationId, repositoryId, yumArtifactId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="YumArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/yumArtifacts/{yum_artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="yumArtifactId">The <c>YumArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="YumArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/yumArtifacts/{yum_artifact}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryYumArtifact(string projectId, string locationId, string repositoryId, string yumArtifactId) =>
            s_projectLocationRepositoryYumArtifact.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(yumArtifactId, nameof(yumArtifactId)));

        /// <summary>Parses the given resource name string into a new <see cref="YumArtifactName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/yumArtifacts/{yum_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="yumArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="YumArtifactName"/> if successful.</returns>
        public static YumArtifactName Parse(string yumArtifactName) => Parse(yumArtifactName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="YumArtifactName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/yumArtifacts/{yum_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="yumArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="YumArtifactName"/> if successful.</returns>
        public static YumArtifactName Parse(string yumArtifactName, bool allowUnparsed) =>
            TryParse(yumArtifactName, allowUnparsed, out YumArtifactName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="YumArtifactName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/yumArtifacts/{yum_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="yumArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="YumArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string yumArtifactName, out YumArtifactName result) =>
            TryParse(yumArtifactName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="YumArtifactName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/yumArtifacts/{yum_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="yumArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="YumArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string yumArtifactName, bool allowUnparsed, out YumArtifactName result)
        {
            gax::GaxPreconditions.CheckNotNull(yumArtifactName, nameof(yumArtifactName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryYumArtifact.TryParseName(yumArtifactName, out resourceName))
            {
                result = FromProjectLocationRepositoryYumArtifact(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(yumArtifactName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private YumArtifactName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string repositoryId = null, string yumArtifactId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
            YumArtifactId = yumArtifactId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="YumArtifactName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/yumArtifacts/{yum_artifact}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="yumArtifactId">The <c>YumArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        public YumArtifactName(string projectId, string locationId, string repositoryId, string yumArtifactId) : this(ResourceNameType.ProjectLocationRepositoryYumArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), yumArtifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(yumArtifactId, nameof(yumArtifactId)))
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
        /// The <c>Repository</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RepositoryId { get; }

        /// <summary>
        /// The <c>YumArtifact</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string YumArtifactId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRepositoryYumArtifact: return s_projectLocationRepositoryYumArtifact.Expand(ProjectId, LocationId, RepositoryId, YumArtifactId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as YumArtifactName);

        /// <inheritdoc/>
        public bool Equals(YumArtifactName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(YumArtifactName a, YumArtifactName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(YumArtifactName a, YumArtifactName b) => !(a == b);
    }

    public partial class YumArtifact
    {
        /// <summary>
        /// <see cref="gcav::YumArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::YumArtifactName YumArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::YumArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
