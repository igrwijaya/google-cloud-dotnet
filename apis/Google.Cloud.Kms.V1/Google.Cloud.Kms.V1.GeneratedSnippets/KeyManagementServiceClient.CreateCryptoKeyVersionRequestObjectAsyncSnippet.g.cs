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

namespace Google.Cloud.Kms.V1.Snippets
{
    // [START cloudkms_v1_generated_KeyManagementService_CreateCryptoKeyVersion_async]
    using Google.Cloud.Kms.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedKeyManagementServiceClientSnippets
    {
        /// <summary>Snippet for CreateCryptoKeyVersionAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateCryptoKeyVersionRequestObjectAsync()
        {
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCryptoKeyVersionRequest request = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.CreateCryptoKeyVersionAsync(request);
        }
    }
    // [END cloudkms_v1_generated_KeyManagementService_CreateCryptoKeyVersion_async]
}
