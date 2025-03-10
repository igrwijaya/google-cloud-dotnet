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

namespace Google.Cloud.ApiGateway.V1.Snippets
{
    // [START apigateway_v1_generated_ApiGatewayService_GetApi_sync]
    using Google.Cloud.ApiGateway.V1;

    public sealed partial class GeneratedApiGatewayServiceClientSnippets
    {
        /// <summary>Snippet for GetApi</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetApiRequestObject()
        {
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = ApiGatewayServiceClient.Create();
            // Initialize request argument(s)
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectApi("[PROJECT]", "[API]"),
            };
            // Make the request
            Api response = apiGatewayServiceClient.GetApi(request);
        }
    }
    // [END apigateway_v1_generated_ApiGatewayService_GetApi_sync]
}
