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
    // [START oslogin_v1_generated_OsLoginService_DeleteSshPublicKey_sync]
    using Google.Cloud.OsLogin.Common;
    using Google.Cloud.OsLogin.V1;

    public sealed partial class GeneratedOsLoginServiceClientSnippets
    {
        /// <summary>Snippet for DeleteSshPublicKey</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void DeleteSshPublicKeyRequestObject()
        {
            // Create client
            OsLoginServiceClient osLoginServiceClient = OsLoginServiceClient.Create();
            // Initialize request argument(s)
            DeleteSshPublicKeyRequest request = new DeleteSshPublicKeyRequest
            {
                SshPublicKeyName = SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            // Make the request
            osLoginServiceClient.DeleteSshPublicKey(request);
        }
    }
    // [END oslogin_v1_generated_OsLoginService_DeleteSshPublicKey_sync]
}
