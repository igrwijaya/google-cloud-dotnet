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

namespace Google.Cloud.BigQuery.DataExchange.V1Beta1.Snippets
{
    // [START analyticshub_v1beta1_generated_AnalyticsHubService_DeleteListing_async_flattened_resourceNames]
    using Google.Cloud.BigQuery.DataExchange.V1Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAnalyticsHubServiceClientSnippets
    {
        /// <summary>Snippet for DeleteListingAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task DeleteListingResourceNamesAsync()
        {
            // Create client
            AnalyticsHubServiceClient analyticsHubServiceClient = await AnalyticsHubServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListingName name = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]");
            // Make the request
            await analyticsHubServiceClient.DeleteListingAsync(name);
        }
    }
    // [END analyticshub_v1beta1_generated_AnalyticsHubService_DeleteListing_async_flattened_resourceNames]
}
