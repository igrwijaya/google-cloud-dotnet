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

namespace Google.Cloud.Spanner.V1.Snippets
{
    // [START spanner_v1_generated_Spanner_CreateSession_sync_flattened]
    using Google.Cloud.Spanner.V1;

    public sealed partial class GeneratedSpannerClientSnippets
    {
        /// <summary>Snippet for CreateSession</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateSession()
        {
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            Session response = spannerClient.CreateSession(database);
        }
    }
    // [END spanner_v1_generated_Spanner_CreateSession_sync_flattened]
}
