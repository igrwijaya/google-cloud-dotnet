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

namespace Google.Cloud.AutoML.V1.Snippets
{
    // [START automl_v1_generated_PredictionService_Predict_sync]
    using Google.Cloud.AutoML.V1;

    public sealed partial class GeneratedPredictionServiceClientSnippets
    {
        /// <summary>Snippet for Predict</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void PredictRequestObject()
        {
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            PredictRequest request = new PredictRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Payload = new ExamplePayload(),
                Params = { { "", "" }, },
            };
            // Make the request
            PredictResponse response = predictionServiceClient.Predict(request);
        }
    }
    // [END automl_v1_generated_PredictionService_Predict_sync]
}
