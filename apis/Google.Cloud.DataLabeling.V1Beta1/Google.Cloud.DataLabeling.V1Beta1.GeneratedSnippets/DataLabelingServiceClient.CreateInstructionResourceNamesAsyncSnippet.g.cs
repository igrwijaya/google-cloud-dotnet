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

namespace Google.Cloud.DataLabeling.V1Beta1.Snippets
{
    // [START datalabeling_v1beta1_generated_DataLabelingService_CreateInstruction_async_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.DataLabeling.V1Beta1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDataLabelingServiceClientSnippets
    {
        /// <summary>Snippet for CreateInstructionAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateInstructionResourceNamesAsync()
        {
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Instruction instruction = new Instruction();
            // Make the request
            Operation<Instruction, CreateInstructionMetadata> response = await dataLabelingServiceClient.CreateInstructionAsync(parent, instruction);

            // Poll until the returned long-running operation is complete
            Operation<Instruction, CreateInstructionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instruction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instruction, CreateInstructionMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceCreateInstructionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instruction retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END datalabeling_v1beta1_generated_DataLabelingService_CreateInstruction_async_flattened_resourceNames]
}
