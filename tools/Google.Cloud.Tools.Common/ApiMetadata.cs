﻿// Copyright 2017 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.Common
{
    public class ApiMetadata
    {
        /// <summary>
        /// Packages that should be treated as Cloud packages even though they don't start with Google.Cloud
        /// </summary>
        private static readonly HashSet<string> PseudoCloudPackages = new HashSet<string>
        {
            // Long-running operations API. Not strictly GCP-specific, but reasonable to host on DevSite.
            // (A little like GAX.)
            "Google.LongRunning",
            // The "interface" for Google.Cloud.DevTools.ContainerAnalysis.V1
            "Grafeas.V1",
            // Common types used by Google.Cloud.GSuiteAddOns.V1
            "Google.Apps.Script.Type",
            // Actually GCP-specific; should probably have a Google.Cloud prefix, but it's too late now.
            "Google.Identity.AccessContextManager.V1",
            "Google.Identity.AccessContextManager.Type"
        };

        // Pattern to extract the underlying API version from the package name.
        private static readonly Regex PackageIdVersionPattern = new Regex(@"\.V[1-9]\d*[-A-Za-z0-9]*$");
        private static readonly Regex PrereleaseApiPattern = new Regex(@"^V[1-9]\d*[^\d]+.*$");
        private static readonly Regex ReleaseVersion = new Regex(@"^[1-9]\d*\.\d+\.\d+$");

        public string Id { get; set; }
        public string Version { get; set; }
        public string ReleasedVersion { get; set; }
        public ApiType Type { get; set; }
        public string TargetFrameworks { get; set; }
        public string TestTargetFrameworks { get; set; }

        /// <summary>
        /// The type to include as library_type in the .repo-metadata.json file, when the defaulting
        /// in <see cref="EffectiveMetadataType"/> is inappropriate.
        /// </summary>
        public string MetadataType { get; set; }

        [JsonIgnore]
        public string EffectiveMetadataType => MetadataType ?? Type switch
        {
            ApiType.None => "OTHER",
            ApiType.Grpc => "GAPIC_AUTO",
            ApiType.Regapic => "GAPIC_AUTO",
            ApiType.Rest => "GAPIC_MANUAL", // These aren't the REST generated clients, they're the augmented wrappers.
            ApiType.Analyzers => "OTHER",
            ApiType.Other => "OTHER",
            _ => throw new InvalidOperationException($"Unknown ApiType value {Type}")
        };

        /// <summary>
        /// The version of the underlying API, taken from the last segment of the package ID,
        /// e.g. Google.Cloud.OSLogin.V1Beta would return V1Beta.
        /// Returns null if there's no match, e.g. for Google.Cloud.Firestore.
        /// </summary>
        [JsonIgnore]
        public string ApiVersion
        {
            get
            {
                var match = PackageIdVersionPattern.Match(Id);
                return match.Success ? match.Value.Substring(1) : null;
            }
        }

        /// <summary>
        /// API name to include in documentation, e.g. "Google Monitoring"
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// This takes priority over <see cref="ProductName"/> and <see cref="Description"/>  when writing
        /// a list of packages. This is useful for APIs which have multiple packages, e.g. Firestore and Spanner.
        /// If <see cref="ProductName"/> is appropriate or the product name is missing but <see cref="Description"/> is
        /// already short enough, this can be left empty.
        /// </summary>
        public string ListingDescription { get; set; }

        /// <summary>
        /// The resolved description to use in listing descriptions, using the first of<see cref="ListingDescription"/>,
        /// <see cref="ProductName"/>, <see cref="Description"/> to be populated.
        ///Note that NuGet descriptions are usually full sentences, ending in a period.
        // The product name or brief description is usually a sentence fragment, so if we *do*
        // use the full description, we trim any trailing periods.
        /// </summary>
        [JsonIgnore]
        public string EffectiveListingDescription => ListingDescription ?? ProductName ?? Description.TrimEnd('.');

        /// <summary>
        /// API URL to include in documentation, e.g. "https://cloud.google.com/monitoring/api/v3/"
        /// </summary>
        public string ProductUrl { get; set; }

        /// <summary>
        /// The full description included in the NuGet package.
        /// </summary>
        public string Description { get; set; }

        public List<string> Tags { get; set; } = new List<string>();
        // Using a SortedDictionary means we'll keep dependencies in alphabetical order.
        public SortedDictionary<string, string> Dependencies { get; set; } = new SortedDictionary<string, string>(StringComparer.Ordinal);
        public SortedDictionary<string, string> TestDependencies { get; set; } = new SortedDictionary<string, string>(StringComparer.Ordinal);

        /// <summary>
        /// The type of generator used to generate source code for this API.
        /// </summary>
        public GeneratorType Generator { get; set; }

        /// <summary>
        /// The autogenerator type used to maintain this API, when specified explicitly.
        /// </summary>
        public AutoGeneratorType? AutoGenerator { get; set; }

        /// <summary>
        /// Determines the autogenerator type for this API based on what's explicitly configured,
        /// and sensible defaults otherwise.
        /// </summary>
        public AutoGeneratorType DetermineAutoGeneratorType()
        {
            if (AutoGenerator != null)
            {
                return AutoGenerator.Value;
            }

            // Default to OwlBot, now that almost everything supports it.
            // Anything else should be specified explicitly.
            // (This only applies to generated APIs, however.)
            return Generator == GeneratorType.None ? AutoGeneratorType.None : AutoGeneratorType.OwlBot;
        }
        
        /// <summary>
        /// The path within googleapis for the API protos.
        /// </summary>
        public string ProtoPath { get; set; }
        
        /// <summary>
        /// The NuGet package owner, typically "google-apis-packages" or "google-cloud".
        /// This property is used by <see cref="EffectivePackageOwner"/> to override the
        /// default ID-based value.
        /// </summary>
        public string PackageOwner { get; set; }

        /// <summary>
        /// When set to <c>true</c>, this API is skipped by the update-history command in ReleaseManager.
        /// Instead, projects that depend on this API will include commits in their history.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool NoVersionHistory { get; set; }

        /// <summary>
        /// The effective package owner, taking account of <see cref="PackageOwner"/> and (if that is unset) the package ID.
        /// </summary>
        [JsonIgnore]
        public string EffectivePackageOwner => PackageOwner ?? (Id.StartsWith("Google.Cloud") ? "google-cloud" : "google-apis-packages");

        [JsonIgnore]
        public bool IsReleaseVersion => ReleaseVersion.IsMatch(Version);

        [JsonIgnore]
        public StructuredVersion StructuredVersion => StructuredVersion.FromString(Version);

        /// <summary>
        /// The release level to record in .repo-metadata.json, if this differs from the one
        /// inferred from the JSON. (For example, we will have 2.0.0-alpha00 versions that didn't
        /// have a 1.0.0.)
        /// </summary>
        public string ReleaseLevelOverride { get; set; }

        /// <summary>
        /// Path to an API-specific JSON configuration file for resources.
        /// This augments the default CommonResourcesConfig.json file in the repo root directory.
        /// Typically a group of APIs (e.g. Bigtable.Admin.V2 and Bigtable.V2) will all have this configuration
        /// option set to refer to a single file in a common package containing common resource names.
        /// </summary>
        public string CommonResourcesConfig { get; set; }

        /// <summary>
        /// Reason to force local regeneration of the API in OwlBot PRs, due to some corner case.
        /// This reason ends up in the .OwlBot-ForceRegeneration.txt file.
        /// </summary>
        public string ForceOwlBotRegeneration { get; set; }

        /// <summary>
        /// Indicates whether the given package name denotes a Cloud API, documented on cloud.google.com.
        /// Note that this is only expected to "know" about API libraries, not support libraries (GAX, protobuf etc).
        /// </summary>
        /// <param name="package">The name of the package, e.g. Google.Cloud.Storage.V1</param>
        public static bool IsCloudPackage(string package) => package.StartsWith("Google.Cloud.") || PseudoCloudPackages.Contains(package);

        // TODO: Optimize to do this lazily if it's ever an issue
        [JsonIgnore]
        public bool CanHaveGaRelease
        {
            get
            {
                string[] parts = Id.Split('.');
                // Three possibilities:
                // - GA API, e.g. Google.Cloud.Spanner.V1
                // - Prerelease API, e.g. Google.Cloud.Spanner.V1Beta1 or Google.Cloud.Spanner.V1P1Beta1
                // - Non-API, e.g. Google.Cloud.Spanner.Data
                // We can create GA packages for the first and the last.
                return !PrereleaseApiPattern.IsMatch(parts.Last());
            }
        }

        /// <summary>
        /// The token this was parsed from in the <see cref="ApiCatalog"/>. This is populated
        /// by <see cref="ApiCatalog.FromJson(string)"/> and <see cref="ApiCatalog.Load"/>, and
        /// the token is part of <see cref="ApiCatalog.Json"/>.
        /// </summary>
        [JsonIgnore]
        public JToken Json { get; set; }

        /// <summary>
        /// The package group that this package is part of. This is populated
        /// by <see cref="ApiCatalog.FromJson(string)"/> and <see cref="ApiCatalog.Load"/>.
        /// </summary>
        [JsonIgnore]
        public PackageGroup PackageGroup { get; set; }

        /// <summary>
        /// The value to include as api_shortname in .repo-metadata.json. This is normally inferred
        /// from the API index when an API is added. Care should be taken before using this value
        /// for *any* other purpose, as it's not an API identifier in any meaningful way.
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// The path to the service config file, relative to the proto directory. Only relevant
        /// for GAPIC APIs, and is usually copied from the API index when an API is added.
        /// </summary>
        public string ServiceConfigFile { get; set; }
    }
}
