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

namespace Google.Cloud.Dialogflow.Cx.V3.Snippets
{
    // [START dialogflow_v3_generated_TestCases_CreateTestCase_sync_flattened]
    using Google.Cloud.Dialogflow.Cx.V3;

    public sealed partial class GeneratedTestCasesClientSnippets
    {
        /// <summary>Snippet for CreateTestCase</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateTestCase()
        {
            // Create client
            TestCasesClient testCasesClient = TestCasesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            TestCase testCase = new TestCase();
            // Make the request
            TestCase response = testCasesClient.CreateTestCase(parent, testCase);
        }
    }
    // [END dialogflow_v3_generated_TestCases_CreateTestCase_sync_flattened]
}
