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

namespace Google.Cloud.PhishingProtection.V1Beta1.Snippets
{
    // [START phishingprotection_v1beta1_generated_PhishingProtectionServiceV1Beta1_ReportPhishing_sync_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.PhishingProtection.V1Beta1;

    public sealed partial class GeneratedPhishingProtectionServiceV1Beta1ClientSnippets
    {
        /// <summary>Snippet for ReportPhishing</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ReportPhishingResourceNames()
        {
            // Create client
            PhishingProtectionServiceV1Beta1Client phishingProtectionServiceV1Beta1Client = PhishingProtectionServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string uri = "";
            // Make the request
            ReportPhishingResponse response = phishingProtectionServiceV1Beta1Client.ReportPhishing(parent, uri);
        }
    }
    // [END phishingprotection_v1beta1_generated_PhishingProtectionServiceV1Beta1_ReportPhishing_sync_flattened_resourceNames]
}
