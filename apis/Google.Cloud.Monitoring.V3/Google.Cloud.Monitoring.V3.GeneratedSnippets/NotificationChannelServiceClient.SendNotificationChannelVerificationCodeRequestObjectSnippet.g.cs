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

namespace Google.Cloud.Monitoring.V3.Snippets
{
    // [START monitoring_v3_generated_NotificationChannelService_SendNotificationChannelVerificationCode_sync]
    using Google.Cloud.Monitoring.V3;

    public sealed partial class GeneratedNotificationChannelServiceClientSnippets
    {
        /// <summary>Snippet for SendNotificationChannelVerificationCode</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void SendNotificationChannelVerificationCodeRequestObject()
        {
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            // Make the request
            notificationChannelServiceClient.SendNotificationChannelVerificationCode(request);
        }
    }
    // [END monitoring_v3_generated_NotificationChannelService_SendNotificationChannelVerificationCode_sync]
}
