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

namespace Google.Cloud.NetworkManagement.V1.Snippets
{
    // [START networkmanagement_v1_generated_ReachabilityService_GetConnectivityTest_async]
    using Google.Cloud.NetworkManagement.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedReachabilityServiceClientSnippets
    {
        /// <summary>Snippet for GetConnectivityTestAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetConnectivityTestRequestObjectAsync()
        {
            // Create client
            ReachabilityServiceClient reachabilityServiceClient = await ReachabilityServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectivityTestRequest request = new GetConnectivityTestRequest { Name = "", };
            // Make the request
            ConnectivityTest response = await reachabilityServiceClient.GetConnectivityTestAsync(request);
        }
    }
    // [END networkmanagement_v1_generated_ReachabilityService_GetConnectivityTest_async]
}
