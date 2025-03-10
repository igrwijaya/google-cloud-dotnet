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

namespace Google.Cloud.Notebooks.V1.Snippets
{
    // [START notebooks_v1_generated_NotebookService_GetInstance_sync_flattened]
    using Google.Cloud.Notebooks.V1;

    public sealed partial class GeneratedNotebookServiceClientSnippets
    {
        /// <summary>Snippet for GetInstance</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetInstance()
        {
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Instance response = notebookServiceClient.GetInstance(name);
        }
    }
    // [END notebooks_v1_generated_NotebookService_GetInstance_sync_flattened]
}
