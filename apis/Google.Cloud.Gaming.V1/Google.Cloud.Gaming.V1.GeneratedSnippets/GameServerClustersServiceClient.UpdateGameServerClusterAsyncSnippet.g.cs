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

namespace Google.Cloud.Gaming.V1.Snippets
{
    // [START gameservices_v1_generated_GameServerClustersService_UpdateGameServerCluster_async_flattened]
    using Google.Cloud.Gaming.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGameServerClustersServiceClientSnippets
    {
        /// <summary>Snippet for UpdateGameServerClusterAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdateGameServerClusterAsync()
        {
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            GameServerCluster gameServerCluster = new GameServerCluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GameServerCluster, OperationMetadata> response = await gameServerClustersServiceClient.UpdateGameServerClusterAsync(gameServerCluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GameServerCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerCluster, OperationMetadata> retrievedResponse = await gameServerClustersServiceClient.PollOnceUpdateGameServerClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerCluster retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END gameservices_v1_generated_GameServerClustersService_UpdateGameServerCluster_async_flattened]
}
