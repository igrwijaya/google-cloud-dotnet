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

using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGlobalNetworkEndpointGroupsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlobalNetworkEndpointGroupRequest request = new GetGlobalNetworkEndpointGroupRequest
            {
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
            };
            NetworkEndpointGroup expectedResponse = new NetworkEndpointGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                CloudRun = new NetworkEndpointGroupCloudRun(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkEndpointType = "network_endpoint_typecc2da78a",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                PscTargetService = "psc_target_service718e45ab",
                Subnetwork = "subnetworkf55bf572",
                AppEngine = new NetworkEndpointGroupAppEngine(),
                Description = "description2cf9da67",
                DefaultPort = 4850952,
                SelfLink = "self_link7e87f12d",
                CloudFunction = new NetworkEndpointGroupCloudFunction(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlobalNetworkEndpointGroupRequest request = new GetGlobalNetworkEndpointGroupRequest
            {
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
            };
            NetworkEndpointGroup expectedResponse = new NetworkEndpointGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                CloudRun = new NetworkEndpointGroupCloudRun(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkEndpointType = "network_endpoint_typecc2da78a",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                PscTargetService = "psc_target_service718e45ab",
                Subnetwork = "subnetworkf55bf572",
                AppEngine = new NetworkEndpointGroupAppEngine(),
                Description = "description2cf9da67",
                DefaultPort = 4850952,
                SelfLink = "self_link7e87f12d",
                CloudFunction = new NetworkEndpointGroupCloudFunction(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworkEndpointGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroup responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlobalNetworkEndpointGroupRequest request = new GetGlobalNetworkEndpointGroupRequest
            {
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
            };
            NetworkEndpointGroup expectedResponse = new NetworkEndpointGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                CloudRun = new NetworkEndpointGroupCloudRun(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkEndpointType = "network_endpoint_typecc2da78a",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                PscTargetService = "psc_target_service718e45ab",
                Subnetwork = "subnetworkf55bf572",
                AppEngine = new NetworkEndpointGroupAppEngine(),
                Description = "description2cf9da67",
                DefaultPort = 4850952,
                SelfLink = "self_link7e87f12d",
                CloudFunction = new NetworkEndpointGroupCloudFunction(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup response = client.Get(request.Project, request.NetworkEndpointGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlobalNetworkEndpointGroupRequest request = new GetGlobalNetworkEndpointGroupRequest
            {
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
            };
            NetworkEndpointGroup expectedResponse = new NetworkEndpointGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                CloudRun = new NetworkEndpointGroupCloudRun(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkEndpointType = "network_endpoint_typecc2da78a",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                PscTargetService = "psc_target_service718e45ab",
                Subnetwork = "subnetworkf55bf572",
                AppEngine = new NetworkEndpointGroupAppEngine(),
                Description = "description2cf9da67",
                DefaultPort = 4850952,
                SelfLink = "self_link7e87f12d",
                CloudFunction = new NetworkEndpointGroupCloudFunction(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworkEndpointGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup responseCallSettings = await client.GetAsync(request.Project, request.NetworkEndpointGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroup responseCancellationToken = await client.GetAsync(request.Project, request.NetworkEndpointGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
