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

namespace Google.Cloud.Dlp.V2.Snippets
{
    // [START dlp_v2_generated_DlpService_UpdateInspectTemplate_async_flattened_resourceNames]
    using Google.Cloud.Dlp.V2;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDlpServiceClientSnippets
    {
        /// <summary>Snippet for UpdateInspectTemplateAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdateInspectTemplateResourceNamesAsync()
        {
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            InspectTemplateName name = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]");
            InspectTemplate inspectTemplate = new InspectTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            InspectTemplate response = await dlpServiceClient.UpdateInspectTemplateAsync(name, inspectTemplate, updateMask);
        }
    }
    // [END dlp_v2_generated_DlpService_UpdateInspectTemplate_async_flattened_resourceNames]
}
