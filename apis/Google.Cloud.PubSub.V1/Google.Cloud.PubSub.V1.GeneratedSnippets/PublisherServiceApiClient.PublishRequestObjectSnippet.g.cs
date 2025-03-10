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

namespace Google.Cloud.PubSub.V1.Snippets
{
    // [START pubsub_v1_generated_PublisherServiceApi_Publish_sync]
    using Google.Cloud.PubSub.V1;

    public sealed partial class GeneratedPublisherServiceApiClientSnippets
    {
        /// <summary>Snippet for Publish</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void PublishRequestObject()
        {
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            PublishRequest request = new PublishRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Messages =
                {
                    new PubsubMessage(),
                },
            };
            // Make the request
            PublishResponse response = publisherServiceApiClient.Publish(request);
        }
    }
    // [END pubsub_v1_generated_PublisherServiceApi_Publish_sync]
}
