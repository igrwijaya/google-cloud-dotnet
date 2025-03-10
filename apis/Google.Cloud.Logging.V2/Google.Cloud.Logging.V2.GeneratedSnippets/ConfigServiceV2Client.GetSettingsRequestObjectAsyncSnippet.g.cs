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

namespace Google.Cloud.Logging.V2.Snippets
{
    // [START logging_v2_generated_ConfigServiceV2_GetSettings_async]
    using Google.Cloud.Logging.V2;
    using System.Threading.Tasks;

    public sealed partial class GeneratedConfigServiceV2ClientSnippets
    {
        /// <summary>Snippet for GetSettingsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetSettingsRequestObjectAsync()
        {
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
            };
            // Make the request
            Settings response = await configServiceV2Client.GetSettingsAsync(request);
        }
    }
    // [END logging_v2_generated_ConfigServiceV2_GetSettings_async]
}
