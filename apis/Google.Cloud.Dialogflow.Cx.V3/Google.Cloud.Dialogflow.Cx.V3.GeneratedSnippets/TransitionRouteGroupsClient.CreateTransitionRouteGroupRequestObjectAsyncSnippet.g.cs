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

namespace Google.Cloud.Dialogflow.Cx.V3.Snippets
{
    // [START dialogflow_v3_generated_TransitionRouteGroups_CreateTransitionRouteGroup_async]
    using Google.Cloud.Dialogflow.Cx.V3;
    using System.Threading.Tasks;

    public sealed partial class GeneratedTransitionRouteGroupsClientSnippets
    {
        /// <summary>Snippet for CreateTransitionRouteGroupAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateTransitionRouteGroupRequestObjectAsync()
        {
            // Create client
            TransitionRouteGroupsClient transitionRouteGroupsClient = await TransitionRouteGroupsClient.CreateAsync();
            // Initialize request argument(s)
            CreateTransitionRouteGroupRequest request = new CreateTransitionRouteGroupRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                TransitionRouteGroup = new TransitionRouteGroup(),
                LanguageCode = "",
            };
            // Make the request
            TransitionRouteGroup response = await transitionRouteGroupsClient.CreateTransitionRouteGroupAsync(request);
        }
    }
    // [END dialogflow_v3_generated_TransitionRouteGroups_CreateTransitionRouteGroup_async]
}
