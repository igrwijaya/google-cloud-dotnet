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

namespace Google.Cloud.AIPlatform.V1.Snippets
{
    // [START aiplatform_v1_generated_PredictionService_Explain_sync]
    using Google.Cloud.AIPlatform.V1;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedPredictionServiceClientSnippets
    {
        /// <summary>Snippet for Explain</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ExplainRequestObject()
        {
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            ExplainRequest request = new ExplainRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                DeployedModelId = "",
                Parameters = new wkt::Value(),
                ExplanationSpecOverride = new ExplanationSpecOverride(),
            };
            // Make the request
            ExplainResponse response = predictionServiceClient.Explain(request);
        }
    }
    // [END aiplatform_v1_generated_PredictionService_Explain_sync]
}
