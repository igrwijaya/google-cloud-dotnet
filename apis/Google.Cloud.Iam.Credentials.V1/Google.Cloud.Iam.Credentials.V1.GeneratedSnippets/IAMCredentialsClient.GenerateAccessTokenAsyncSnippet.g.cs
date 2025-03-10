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

namespace Google.Cloud.Iam.Credentials.V1.Snippets
{
    // [START iamcredentials_v1_generated_IAMCredentials_GenerateAccessToken_async_flattened]
    using Google.Cloud.Iam.Credentials.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedIAMCredentialsClientSnippets
    {
        /// <summary>Snippet for GenerateAccessTokenAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GenerateAccessTokenAsync()
        {
            // Create client
            IAMCredentialsClient iAMCredentialsClient = await IAMCredentialsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            IEnumerable<string> delegates = new string[] { "", };
            IEnumerable<string> scope = new string[] { "", };
            Duration lifetime = new Duration();
            // Make the request
            GenerateAccessTokenResponse response = await iAMCredentialsClient.GenerateAccessTokenAsync(name, delegates, scope, lifetime);
        }
    }
    // [END iamcredentials_v1_generated_IAMCredentials_GenerateAccessToken_async_flattened]
}
