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

namespace Google.Cloud.GkeHub.V1.Snippets
{
    // [START gkehub_v1_generated_GkeHub_GetFeature_async]
    using Google.Cloud.GkeHub.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGkeHubClientSnippets
    {
        /// <summary>Snippet for GetFeatureAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetFeatureRequestObjectAsync()
        {
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            GetFeatureRequest request = new GetFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]"),
            };
            // Make the request
            Feature response = await gkeHubClient.GetFeatureAsync(request);
        }
    }
    // [END gkehub_v1_generated_GkeHub_GetFeature_async]
}
