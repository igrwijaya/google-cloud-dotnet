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

namespace Google.Cloud.DevTools.ContainerAnalysis.V1.Snippets
{
    // [START containeranalysis_v1_generated_ContainerAnalysis_TestIamPermissions_sync]
    using Google.Api.Gax;
    using Google.Cloud.DevTools.ContainerAnalysis.V1;
    using Google.Cloud.Iam.V1;

    public sealed partial class GeneratedContainerAnalysisClientSnippets
    {
        /// <summary>Snippet for TestIamPermissions</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void TestIamPermissionsRequestObject()
        {
            // Create client
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = containerAnalysisClient.TestIamPermissions(request);
        }
    }
    // [END containeranalysis_v1_generated_ContainerAnalysis_TestIamPermissions_sync]
}
