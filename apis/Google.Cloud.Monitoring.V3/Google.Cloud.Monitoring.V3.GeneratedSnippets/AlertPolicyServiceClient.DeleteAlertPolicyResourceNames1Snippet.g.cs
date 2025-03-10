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

namespace Google.Cloud.Monitoring.V3.Snippets
{
    // [START monitoring_v3_generated_AlertPolicyService_DeleteAlertPolicy_sync_flattened_resourceNames1]
    using Google.Cloud.Monitoring.V3;

    public sealed partial class GeneratedAlertPolicyServiceClientSnippets
    {
        /// <summary>Snippet for DeleteAlertPolicy</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void DeleteAlertPolicyResourceNames1()
        {
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            AlertPolicyName name = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]");
            // Make the request
            alertPolicyServiceClient.DeleteAlertPolicy(name);
        }
    }
    // [END monitoring_v3_generated_AlertPolicyService_DeleteAlertPolicy_sync_flattened_resourceNames1]
}
