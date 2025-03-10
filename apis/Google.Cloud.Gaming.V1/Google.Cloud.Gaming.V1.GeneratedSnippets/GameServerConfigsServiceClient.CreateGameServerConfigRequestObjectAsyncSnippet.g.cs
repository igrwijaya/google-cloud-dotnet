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
    // [START gameservices_v1_generated_GameServerConfigsService_CreateGameServerConfig_async]
    using Google.Cloud.Gaming.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGameServerConfigsServiceClientSnippets
    {
        /// <summary>Snippet for CreateGameServerConfigAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateGameServerConfigRequestObjectAsync()
        {
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = await GameServerConfigsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateGameServerConfigRequest request = new CreateGameServerConfigRequest
            {
                ParentAsGameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                ConfigId = "",
                GameServerConfig = new GameServerConfig(),
            };
            // Make the request
            Operation<GameServerConfig, OperationMetadata> response = await gameServerConfigsServiceClient.CreateGameServerConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GameServerConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerConfig, OperationMetadata> retrievedResponse = await gameServerConfigsServiceClient.PollOnceCreateGameServerConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerConfig retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END gameservices_v1_generated_GameServerConfigsService_CreateGameServerConfig_async]
}
