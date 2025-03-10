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

namespace Google.Cloud.OsLogin.V1.Snippets
{
    // [START oslogin_v1_generated_OsLoginService_ImportSshPublicKey_async_flattened2]
    using Google.Cloud.OsLogin.Common;
    using Google.Cloud.OsLogin.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedOsLoginServiceClientSnippets
    {
        /// <summary>Snippet for ImportSshPublicKeyAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task ImportSshPublicKey2Async()
        {
            // Create client
            OsLoginServiceClient osLoginServiceClient = await OsLoginServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "users/[USER]";
            SshPublicKey sshPublicKey = new SshPublicKey();
            string projectId = "";
            // Make the request
            ImportSshPublicKeyResponse response = await osLoginServiceClient.ImportSshPublicKeyAsync(parent, sshPublicKey, projectId);
        }
    }
    // [END oslogin_v1_generated_OsLoginService_ImportSshPublicKey_async_flattened2]
}
