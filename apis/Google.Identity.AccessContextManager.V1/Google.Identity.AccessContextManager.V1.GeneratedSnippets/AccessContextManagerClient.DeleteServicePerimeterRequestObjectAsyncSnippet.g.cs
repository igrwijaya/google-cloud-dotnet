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

namespace Google.Identity.AccessContextManager.V1.Snippets
{
    // [START accesscontextmanager_v1_generated_AccessContextManager_DeleteServicePerimeter_async]
    using Google.Identity.AccessContextManager.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAccessContextManagerClientSnippets
    {
        /// <summary>Snippet for DeleteServicePerimeterAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task DeleteServicePerimeterRequestObjectAsync()
        {
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServicePerimeterRequest request = new DeleteServicePerimeterRequest
            {
                ServicePerimeterName = ServicePerimeterName.FromAccessPolicyServicePerimeter("[ACCESS_POLICY]", "[SERVICE_PERIMETER]"),
            };
            // Make the request
            Operation<Empty, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.DeleteServicePerimeterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceDeleteServicePerimeterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END accesscontextmanager_v1_generated_AccessContextManager_DeleteServicePerimeter_async]
}
