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

namespace Google.Cloud.Logging.V2.Snippets
{
    // [START logging_v2_generated_LoggingServiceV2_DeleteLog_sync_flattened_resourceNames]
    using Google.Cloud.Logging.V2;

    public sealed partial class GeneratedLoggingServiceV2ClientSnippets
    {
        /// <summary>Snippet for DeleteLog</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void DeleteLogResourceNames()
        {
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            LogName logName = LogName.FromProjectLog("[PROJECT]", "[LOG]");
            // Make the request
            loggingServiceV2Client.DeleteLog(logName);
        }
    }
    // [END logging_v2_generated_LoggingServiceV2_DeleteLog_sync_flattened_resourceNames]
}
