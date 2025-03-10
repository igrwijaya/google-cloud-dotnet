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

namespace Google.Cloud.BigQuery.Storage.V1.Snippets
{
    // [START bigquerystorage_v1_generated_BigQueryWrite_FinalizeWriteStream_async_flattened]
    using Google.Cloud.BigQuery.Storage.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBigQueryWriteClientSnippets
    {
        /// <summary>Snippet for FinalizeWriteStreamAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task FinalizeWriteStreamAsync()
        {
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]/tables/[TABLE]/streams/[STREAM]";
            // Make the request
            FinalizeWriteStreamResponse response = await bigQueryWriteClient.FinalizeWriteStreamAsync(name);
        }
    }
    // [END bigquerystorage_v1_generated_BigQueryWrite_FinalizeWriteStream_async_flattened]
}
