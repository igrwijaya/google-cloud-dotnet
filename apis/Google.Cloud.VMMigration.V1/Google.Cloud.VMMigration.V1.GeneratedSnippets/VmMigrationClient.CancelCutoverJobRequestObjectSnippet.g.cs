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

namespace Google.Cloud.VMMigration.V1.Snippets
{
    // [START vmmigration_v1_generated_VmMigration_CancelCutoverJob_sync]
    using Google.Cloud.VMMigration.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedVmMigrationClientSnippets
    {
        /// <summary>Snippet for CancelCutoverJob</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CancelCutoverJobRequestObject()
        {
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            CancelCutoverJobRequest request = new CancelCutoverJobRequest
            {
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
            };
            // Make the request
            Operation<CancelCutoverJobResponse, OperationMetadata> response = vmMigrationClient.CancelCutoverJob(request);

            // Poll until the returned long-running operation is complete
            Operation<CancelCutoverJobResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CancelCutoverJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CancelCutoverJobResponse, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCancelCutoverJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CancelCutoverJobResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END vmmigration_v1_generated_VmMigration_CancelCutoverJob_sync]
}
