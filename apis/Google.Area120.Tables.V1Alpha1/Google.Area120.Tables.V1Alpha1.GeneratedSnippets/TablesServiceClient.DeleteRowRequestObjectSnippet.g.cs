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

namespace Google.Area120.Tables.V1Alpha1.Snippets
{
    // [START area120tables_v1alpha1_generated_TablesService_DeleteRow_sync]
    using Google.Area120.Tables.V1Alpha1;

    public sealed partial class GeneratedTablesServiceClientSnippets
    {
        /// <summary>Snippet for DeleteRow</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void DeleteRowRequestObject()
        {
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            DeleteRowRequest request = new DeleteRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
            };
            // Make the request
            tablesServiceClient.DeleteRow(request);
        }
    }
    // [END area120tables_v1alpha1_generated_TablesService_DeleteRow_sync]
}
