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

namespace Google.Cloud.Eventarc.V1.Snippets
{
    // [START eventarc_v1_generated_Eventarc_CreateChannelConnection_sync_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Eventarc.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedEventarcClientSnippets
    {
        /// <summary>Snippet for CreateChannelConnection</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateChannelConnectionResourceNames()
        {
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ChannelConnection channelConnection = new ChannelConnection();
            string channelConnectionId = "";
            // Make the request
            Operation<ChannelConnection, OperationMetadata> response = eventarcClient.CreateChannelConnection(parent, channelConnection, channelConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<ChannelConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ChannelConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ChannelConnection, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateChannelConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ChannelConnection retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END eventarc_v1_generated_Eventarc_CreateChannelConnection_sync_flattened_resourceNames]
}
