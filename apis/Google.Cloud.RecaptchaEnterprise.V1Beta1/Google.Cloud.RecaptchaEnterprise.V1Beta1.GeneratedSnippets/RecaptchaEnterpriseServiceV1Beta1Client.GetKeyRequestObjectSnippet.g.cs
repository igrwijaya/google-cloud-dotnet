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

namespace Google.Cloud.RecaptchaEnterprise.V1Beta1.Snippets
{
    // [START recaptchaenterprise_v1beta1_generated_RecaptchaEnterpriseServiceV1Beta1_GetKey_sync]
    using Google.Cloud.RecaptchaEnterprise.V1Beta1;

    public sealed partial class GeneratedRecaptchaEnterpriseServiceV1Beta1ClientSnippets
    {
        /// <summary>Snippet for GetKey</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetKeyRequestObject()
        {
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            GetKeyRequest request = new GetKeyRequest
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            // Make the request
            Key response = recaptchaEnterpriseServiceV1Beta1Client.GetKey(request);
        }
    }
    // [END recaptchaenterprise_v1beta1_generated_RecaptchaEnterpriseServiceV1Beta1_GetKey_sync]
}
