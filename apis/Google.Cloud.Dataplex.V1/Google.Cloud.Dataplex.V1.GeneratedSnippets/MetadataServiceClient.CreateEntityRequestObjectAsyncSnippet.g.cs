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

namespace Google.Cloud.Dataplex.V1.Snippets
{
    // [START dataplex_v1_generated_MetadataService_CreateEntity_async]
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    public sealed partial class GeneratedMetadataServiceClientSnippets
    {
        /// <summary>Snippet for CreateEntityAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateEntityRequestObjectAsync()
        {
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEntityRequest request = new CreateEntityRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                Entity = new Entity(),
                ValidateOnly = false,
            };
            // Make the request
            Entity response = await metadataServiceClient.CreateEntityAsync(request);
        }
    }
    // [END dataplex_v1_generated_MetadataService_CreateEntity_async]
}
