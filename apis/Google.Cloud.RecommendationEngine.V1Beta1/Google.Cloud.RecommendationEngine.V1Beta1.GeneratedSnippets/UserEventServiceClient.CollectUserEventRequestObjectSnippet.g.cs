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

namespace Google.Cloud.RecommendationEngine.V1Beta1.Snippets
{
    // [START recommendationengine_v1beta1_generated_UserEventService_CollectUserEvent_sync]
    using Google.Api;
    using Google.Cloud.RecommendationEngine.V1Beta1;

    public sealed partial class GeneratedUserEventServiceClientSnippets
    {
        /// <summary>Snippet for CollectUserEvent</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CollectUserEventRequestObject()
        {
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            CollectUserEventRequest request = new CollectUserEventRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = "",
                Uri = "",
                Ets = 0L,
            };
            // Make the request
            HttpBody response = userEventServiceClient.CollectUserEvent(request);
        }
    }
    // [END recommendationengine_v1beta1_generated_UserEventService_CollectUserEvent_sync]
}
