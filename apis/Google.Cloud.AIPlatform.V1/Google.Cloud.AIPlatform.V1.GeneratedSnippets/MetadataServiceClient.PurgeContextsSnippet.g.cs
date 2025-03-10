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
    // [START aiplatform_v1_generated_MetadataService_PurgeContexts_sync_flattened]
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedMetadataServiceClientSnippets
    {
        /// <summary>Snippet for PurgeContexts</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void PurgeContexts()
        {
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            Operation<PurgeContextsResponse, PurgeContextsMetadata> response = metadataServiceClient.PurgeContexts(parent);

            // Poll until the returned long-running operation is complete
            Operation<PurgeContextsResponse, PurgeContextsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeContextsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeContextsResponse, PurgeContextsMetadata> retrievedResponse = metadataServiceClient.PollOncePurgeContexts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeContextsResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_MetadataService_PurgeContexts_sync_flattened]
}
