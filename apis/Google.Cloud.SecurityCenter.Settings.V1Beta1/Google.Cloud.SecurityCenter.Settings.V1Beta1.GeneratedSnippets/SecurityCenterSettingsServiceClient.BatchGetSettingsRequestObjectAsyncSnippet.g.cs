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

namespace Google.Cloud.SecurityCenter.Settings.V1Beta1.Snippets
{
    // [START securitycenter_v1beta1_generated_SecurityCenterSettingsService_BatchGetSettings_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.SecurityCenter.Settings.V1Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSecurityCenterSettingsServiceClientSnippets
    {
        /// <summary>Snippet for BatchGetSettingsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task BatchGetSettingsRequestObjectAsync()
        {
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchGetSettingsRequest request = new BatchGetSettingsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Names = { "", },
            };
            // Make the request
            BatchGetSettingsResponse response = await securityCenterSettingsServiceClient.BatchGetSettingsAsync(request);
        }
    }
    // [END securitycenter_v1beta1_generated_SecurityCenterSettingsService_BatchGetSettings_async]
}
