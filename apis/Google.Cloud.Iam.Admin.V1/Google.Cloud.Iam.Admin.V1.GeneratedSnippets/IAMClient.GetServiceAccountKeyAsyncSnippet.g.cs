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

namespace Google.Cloud.Iam.Admin.V1.Snippets
{
    // [START iam_v1_generated_IAM_GetServiceAccountKey_async_flattened]
    using Google.Cloud.Iam.Admin.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedIAMClientSnippets
    {
        /// <summary>Snippet for GetServiceAccountKeyAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetServiceAccountKeyAsync()
        {
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]/keys/[KEY]";
            ServiceAccountPublicKeyType publicKeyType = ServiceAccountPublicKeyType.TypeNone;
            // Make the request
            ServiceAccountKey response = await iAMClient.GetServiceAccountKeyAsync(name, publicKeyType);
        }
    }
    // [END iam_v1_generated_IAM_GetServiceAccountKey_async_flattened]
}
