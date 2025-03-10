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
    // [START monitoring_v3_generated_MetricService_CreateTimeSeries_async_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Monitoring.V3;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedMetricServiceClientSnippets
    {
        /// <summary>Snippet for CreateTimeSeriesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateTimeSeriesResourceNamesAsync()
        {
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            IEnumerable<TimeSeries> timeSeries = new TimeSeries[] { new TimeSeries(), };
            // Make the request
            await metricServiceClient.CreateTimeSeriesAsync(name, timeSeries);
        }
    }
    // [END monitoring_v3_generated_MetricService_CreateTimeSeries_async_flattened_resourceNames]
}
