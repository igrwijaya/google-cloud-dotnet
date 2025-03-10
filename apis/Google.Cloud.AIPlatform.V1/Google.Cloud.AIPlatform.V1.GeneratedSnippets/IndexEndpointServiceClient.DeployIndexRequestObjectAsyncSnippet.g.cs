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

namespace Google.Cloud.AIPlatform.V1.Snippets
{
    // [START aiplatform_v1_generated_IndexEndpointService_DeployIndex_async]
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedIndexEndpointServiceClientSnippets
    {
        /// <summary>Snippet for DeployIndexAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task DeployIndexRequestObjectAsync()
        {
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeployIndexRequest request = new DeployIndexRequest
            {
                IndexEndpointAsIndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DeployedIndex = new DeployedIndex(),
            };
            // Make the request
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> response = await indexEndpointServiceClient.DeployIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceDeployIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_IndexEndpointService_DeployIndex_async]
}
