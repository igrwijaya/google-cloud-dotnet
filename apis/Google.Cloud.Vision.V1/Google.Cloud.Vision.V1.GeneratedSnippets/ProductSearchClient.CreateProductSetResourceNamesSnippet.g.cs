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

namespace Google.Cloud.Vision.V1.Snippets
{
    // [START vision_v1_generated_ProductSearch_CreateProductSet_sync_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Vision.V1;

    public sealed partial class GeneratedProductSearchClientSnippets
    {
        /// <summary>Snippet for CreateProductSet</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateProductSetResourceNames()
        {
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ProductSet productSet = new ProductSet();
            string productSetId = "";
            // Make the request
            ProductSet response = productSearchClient.CreateProductSet(parent, productSet, productSetId);
        }
    }
    // [END vision_v1_generated_ProductSearch_CreateProductSet_sync_flattened_resourceNames]
}
