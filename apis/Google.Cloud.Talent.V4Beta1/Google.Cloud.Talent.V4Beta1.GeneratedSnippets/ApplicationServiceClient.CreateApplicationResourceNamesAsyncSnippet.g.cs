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

namespace Google.Cloud.Talent.V4Beta1.Snippets
{
    // [START jobs_v4beta1_generated_ApplicationService_CreateApplication_async_flattened_resourceNames]
    using Google.Cloud.Talent.V4Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedApplicationServiceClientSnippets
    {
        /// <summary>Snippet for CreateApplicationAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateApplicationResourceNamesAsync()
        {
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProfileName parent = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]");
            Application application = new Application();
            // Make the request
            Application response = await applicationServiceClient.CreateApplicationAsync(parent, application);
        }
    }
    // [END jobs_v4beta1_generated_ApplicationService_CreateApplication_async_flattened_resourceNames]
}
