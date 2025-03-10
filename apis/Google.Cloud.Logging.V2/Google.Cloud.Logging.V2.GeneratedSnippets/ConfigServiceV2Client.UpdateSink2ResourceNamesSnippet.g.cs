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
    // [START logging_v2_generated_ConfigServiceV2_UpdateSink_sync_flattened2_resourceNames]
    using Google.Cloud.Logging.V2;

    public sealed partial class GeneratedConfigServiceV2ClientSnippets
    {
        /// <summary>Snippet for UpdateSink</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void UpdateSink2ResourceNames()
        {
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            LogSinkName sinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]");
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = configServiceV2Client.UpdateSink(sinkName, sink);
        }
    }
    // [END logging_v2_generated_ConfigServiceV2_UpdateSink_sync_flattened2_resourceNames]
}
