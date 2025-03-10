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

namespace Google.Cloud.Tasks.V2.Snippets
{
    // [START cloudtasks_v2_generated_CloudTasks_RunTask_async]
    using System.Threading.Tasks;
    using gctv = Google.Cloud.Tasks.V2;

    public sealed partial class GeneratedCloudTasksClientSnippets
    {
        /// <summary>Snippet for RunTaskAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task RunTaskRequestObjectAsync()
        {
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = await cloudTasksClient.RunTaskAsync(request);
        }
    }
    // [END cloudtasks_v2_generated_CloudTasks_RunTask_async]
}
