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

namespace Google.Analytics.Data.V1Beta.Snippets
{
    // [START analyticsdata_v1beta_generated_BetaAnalyticsData_RunRealtimeReport_sync]
    using Google.Analytics.Data.V1Beta;

    public sealed partial class GeneratedBetaAnalyticsDataClientSnippets
    {
        /// <summary>Snippet for RunRealtimeReport</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void RunRealtimeReportRequestObject()
        {
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            RunRealtimeReportRequest request = new RunRealtimeReportRequest
            {
                Property = "",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                Limit = 0L,
                MetricAggregations =
                {
                    MetricAggregation.Unspecified,
                },
                OrderBys = { new OrderBy(), },
                ReturnPropertyQuota = false,
                MinuteRanges = { new MinuteRange(), },
            };
            // Make the request
            RunRealtimeReportResponse response = betaAnalyticsDataClient.RunRealtimeReport(request);
        }
    }
    // [END analyticsdata_v1beta_generated_BetaAnalyticsData_RunRealtimeReport_sync]
}
