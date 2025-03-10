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

namespace Google.Cloud.ResourceManager.V3.Snippets
{
    // [START cloudresourcemanager_v3_generated_TagKeys_DeleteTagKey_sync]
    using Google.Cloud.ResourceManager.V3;
    using Google.LongRunning;

    public sealed partial class GeneratedTagKeysClientSnippets
    {
        /// <summary>Snippet for DeleteTagKey</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void DeleteTagKeyRequestObject()
        {
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            DeleteTagKeyRequest request = new DeleteTagKeyRequest
            {
                TagKeyName = TagKeyName.FromTagKey("[TAG_KEY]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<TagKey, DeleteTagKeyMetadata> response = tagKeysClient.DeleteTagKey(request);

            // Poll until the returned long-running operation is complete
            Operation<TagKey, DeleteTagKeyMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TagKey result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TagKey, DeleteTagKeyMetadata> retrievedResponse = tagKeysClient.PollOnceDeleteTagKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TagKey retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END cloudresourcemanager_v3_generated_TagKeys_DeleteTagKey_sync]
}
