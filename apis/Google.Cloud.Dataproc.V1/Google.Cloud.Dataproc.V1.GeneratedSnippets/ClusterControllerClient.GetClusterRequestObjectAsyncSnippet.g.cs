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

namespace Google.Cloud.Dataproc.V1.Snippets
{
    // [START dataproc_v1_generated_ClusterController_GetCluster_async]
    using Google.Cloud.Dataproc.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedClusterControllerClientSnippets
    {
        /// <summary>Snippet for GetClusterAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetClusterRequestObjectAsync()
        {
            // Create client
            ClusterControllerClient clusterControllerClient = await ClusterControllerClient.CreateAsync();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "",
                ClusterName = "",
                Region = "",
            };
            // Make the request
            Cluster response = await clusterControllerClient.GetClusterAsync(request);
        }
    }
    // [END dataproc_v1_generated_ClusterController_GetCluster_async]
}
