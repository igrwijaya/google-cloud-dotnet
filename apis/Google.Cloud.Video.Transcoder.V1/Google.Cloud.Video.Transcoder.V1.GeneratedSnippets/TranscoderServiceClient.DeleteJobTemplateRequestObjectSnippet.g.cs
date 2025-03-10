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

namespace Google.Cloud.Video.Transcoder.V1.Snippets
{
    // [START transcoder_v1_generated_TranscoderService_DeleteJobTemplate_sync]
    using Google.Cloud.Video.Transcoder.V1;

    public sealed partial class GeneratedTranscoderServiceClientSnippets
    {
        /// <summary>Snippet for DeleteJobTemplate</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void DeleteJobTemplateRequestObject()
        {
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            DeleteJobTemplateRequest request = new DeleteJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                AllowMissing = false,
            };
            // Make the request
            transcoderServiceClient.DeleteJobTemplate(request);
        }
    }
    // [END transcoder_v1_generated_TranscoderService_DeleteJobTemplate_sync]
}
