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

namespace Google.Cloud.Dataproc.V1.Snippets
{
    // [START dataproc_v1_generated_WorkflowTemplateService_InstantiateWorkflowTemplate_async_flattened2]
    using Google.Cloud.Dataproc.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedWorkflowTemplateServiceClientSnippets
    {
        /// <summary>Snippet for InstantiateWorkflowTemplateAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task InstantiateWorkflowTemplate2Async()
        {
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/regions/[REGION]/workflowTemplates/[WORKFLOW_TEMPLATE]";
            IDictionary<string, string> parameters = new Dictionary<string, string> { { "", "" }, };
            // Make the request
            Operation<Empty, WorkflowMetadata> response = await workflowTemplateServiceClient.InstantiateWorkflowTemplateAsync(name, parameters);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = await workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dataproc_v1_generated_WorkflowTemplateService_InstantiateWorkflowTemplate_async_flattened2]
}
