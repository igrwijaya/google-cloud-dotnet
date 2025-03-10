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
    public sealed class GeneratedRegionHealthCheckServicesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionHealthCheckServiceRequest request = new GetRegionHealthCheckServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
            };
            HealthCheckService expectedResponse = new HealthCheckService
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                NetworkEndpointGroups =
                {
                    "network_endpoint_groupsb3b03e25",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                HealthStatusAggregationPolicy = "health_status_aggregation_policy3f437d39",
                NotificationEndpoints =
                {
                    "notification_endpoints507ebc27",
                },
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            HealthCheckService response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionHealthCheckServiceRequest request = new GetRegionHealthCheckServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
            };
            HealthCheckService expectedResponse = new HealthCheckService
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                NetworkEndpointGroups =
                {
                    "network_endpoint_groupsb3b03e25",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                HealthStatusAggregationPolicy = "health_status_aggregation_policy3f437d39",
                NotificationEndpoints =
                {
                    "notification_endpoints507ebc27",
                },
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HealthCheckService>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            HealthCheckService responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HealthCheckService responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionHealthCheckServiceRequest request = new GetRegionHealthCheckServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
            };
            HealthCheckService expectedResponse = new HealthCheckService
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                NetworkEndpointGroups =
                {
                    "network_endpoint_groupsb3b03e25",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                HealthStatusAggregationPolicy = "health_status_aggregation_policy3f437d39",
                NotificationEndpoints =
                {
                    "notification_endpoints507ebc27",
                },
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            HealthCheckService response = client.Get(request.Project, request.Region, request.HealthCheckService);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionHealthCheckServiceRequest request = new GetRegionHealthCheckServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
            };
            HealthCheckService expectedResponse = new HealthCheckService
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                NetworkEndpointGroups =
                {
                    "network_endpoint_groupsb3b03e25",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                HealthStatusAggregationPolicy = "health_status_aggregation_policy3f437d39",
                NotificationEndpoints =
                {
                    "notification_endpoints507ebc27",
                },
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HealthCheckService>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            HealthCheckService responseCallSettings = await client.GetAsync(request.Project, request.Region, request.HealthCheckService, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HealthCheckService responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.HealthCheckService, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
