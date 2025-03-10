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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.CertificateManager.V1
{
    /// <summary>Settings for <see cref="CertificateManagerClient"/> instances.</summary>
    public sealed partial class CertificateManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CertificateManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CertificateManagerSettings"/>.</returns>
        public static CertificateManagerSettings GetDefault() => new CertificateManagerSettings();

        /// <summary>Constructs a new <see cref="CertificateManagerSettings"/> object with default settings.</summary>
        public CertificateManagerSettings()
        {
        }

        private CertificateManagerSettings(CertificateManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListCertificatesSettings = existing.ListCertificatesSettings;
            GetCertificateSettings = existing.GetCertificateSettings;
            CreateCertificateSettings = existing.CreateCertificateSettings;
            CreateCertificateOperationsSettings = existing.CreateCertificateOperationsSettings.Clone();
            UpdateCertificateSettings = existing.UpdateCertificateSettings;
            UpdateCertificateOperationsSettings = existing.UpdateCertificateOperationsSettings.Clone();
            DeleteCertificateSettings = existing.DeleteCertificateSettings;
            DeleteCertificateOperationsSettings = existing.DeleteCertificateOperationsSettings.Clone();
            ListCertificateMapsSettings = existing.ListCertificateMapsSettings;
            GetCertificateMapSettings = existing.GetCertificateMapSettings;
            CreateCertificateMapSettings = existing.CreateCertificateMapSettings;
            CreateCertificateMapOperationsSettings = existing.CreateCertificateMapOperationsSettings.Clone();
            UpdateCertificateMapSettings = existing.UpdateCertificateMapSettings;
            UpdateCertificateMapOperationsSettings = existing.UpdateCertificateMapOperationsSettings.Clone();
            DeleteCertificateMapSettings = existing.DeleteCertificateMapSettings;
            DeleteCertificateMapOperationsSettings = existing.DeleteCertificateMapOperationsSettings.Clone();
            ListCertificateMapEntriesSettings = existing.ListCertificateMapEntriesSettings;
            GetCertificateMapEntrySettings = existing.GetCertificateMapEntrySettings;
            CreateCertificateMapEntrySettings = existing.CreateCertificateMapEntrySettings;
            CreateCertificateMapEntryOperationsSettings = existing.CreateCertificateMapEntryOperationsSettings.Clone();
            UpdateCertificateMapEntrySettings = existing.UpdateCertificateMapEntrySettings;
            UpdateCertificateMapEntryOperationsSettings = existing.UpdateCertificateMapEntryOperationsSettings.Clone();
            DeleteCertificateMapEntrySettings = existing.DeleteCertificateMapEntrySettings;
            DeleteCertificateMapEntryOperationsSettings = existing.DeleteCertificateMapEntryOperationsSettings.Clone();
            ListDnsAuthorizationsSettings = existing.ListDnsAuthorizationsSettings;
            GetDnsAuthorizationSettings = existing.GetDnsAuthorizationSettings;
            CreateDnsAuthorizationSettings = existing.CreateDnsAuthorizationSettings;
            CreateDnsAuthorizationOperationsSettings = existing.CreateDnsAuthorizationOperationsSettings.Clone();
            UpdateDnsAuthorizationSettings = existing.UpdateDnsAuthorizationSettings;
            UpdateDnsAuthorizationOperationsSettings = existing.UpdateDnsAuthorizationOperationsSettings.Clone();
            DeleteDnsAuthorizationSettings = existing.DeleteDnsAuthorizationSettings;
            DeleteDnsAuthorizationOperationsSettings = existing.DeleteDnsAuthorizationOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(CertificateManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.ListCertificates</c> and <c>CertificateManagerClient.ListCertificatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCertificatesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.GetCertificate</c> and <c>CertificateManagerClient.GetCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCertificateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.CreateCertificate</c> and <c>CertificateManagerClient.CreateCertificateAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCertificateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateManagerClient.CreateCertificate</c> and
        /// <c>CertificateManagerClient.CreateCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateCertificateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.UpdateCertificate</c> and <c>CertificateManagerClient.UpdateCertificateAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCertificateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateManagerClient.UpdateCertificate</c> and
        /// <c>CertificateManagerClient.UpdateCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateCertificateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.DeleteCertificate</c> and <c>CertificateManagerClient.DeleteCertificateAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCertificateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateManagerClient.DeleteCertificate</c> and
        /// <c>CertificateManagerClient.DeleteCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteCertificateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.ListCertificateMaps</c> and <c>CertificateManagerClient.ListCertificateMapsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCertificateMapsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.GetCertificateMap</c> and <c>CertificateManagerClient.GetCertificateMapAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCertificateMapSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.CreateCertificateMap</c> and
        /// <c>CertificateManagerClient.CreateCertificateMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCertificateMapSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateManagerClient.CreateCertificateMap</c> and
        /// <c>CertificateManagerClient.CreateCertificateMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateCertificateMapOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.UpdateCertificateMap</c> and
        /// <c>CertificateManagerClient.UpdateCertificateMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCertificateMapSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateManagerClient.UpdateCertificateMap</c> and
        /// <c>CertificateManagerClient.UpdateCertificateMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateCertificateMapOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.DeleteCertificateMap</c> and
        /// <c>CertificateManagerClient.DeleteCertificateMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCertificateMapSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateManagerClient.DeleteCertificateMap</c> and
        /// <c>CertificateManagerClient.DeleteCertificateMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteCertificateMapOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.ListCertificateMapEntries</c> and
        /// <c>CertificateManagerClient.ListCertificateMapEntriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCertificateMapEntriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.GetCertificateMapEntry</c> and
        /// <c>CertificateManagerClient.GetCertificateMapEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCertificateMapEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.CreateCertificateMapEntry</c> and
        /// <c>CertificateManagerClient.CreateCertificateMapEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCertificateMapEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateManagerClient.CreateCertificateMapEntry</c> and
        /// <c>CertificateManagerClient.CreateCertificateMapEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateCertificateMapEntryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.UpdateCertificateMapEntry</c> and
        /// <c>CertificateManagerClient.UpdateCertificateMapEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCertificateMapEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateManagerClient.UpdateCertificateMapEntry</c> and
        /// <c>CertificateManagerClient.UpdateCertificateMapEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateCertificateMapEntryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.DeleteCertificateMapEntry</c> and
        /// <c>CertificateManagerClient.DeleteCertificateMapEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCertificateMapEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateManagerClient.DeleteCertificateMapEntry</c> and
        /// <c>CertificateManagerClient.DeleteCertificateMapEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteCertificateMapEntryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.ListDnsAuthorizations</c> and
        /// <c>CertificateManagerClient.ListDnsAuthorizationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDnsAuthorizationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.GetDnsAuthorization</c> and <c>CertificateManagerClient.GetDnsAuthorizationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDnsAuthorizationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.CreateDnsAuthorization</c> and
        /// <c>CertificateManagerClient.CreateDnsAuthorizationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDnsAuthorizationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateManagerClient.CreateDnsAuthorization</c> and
        /// <c>CertificateManagerClient.CreateDnsAuthorizationAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateDnsAuthorizationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.UpdateDnsAuthorization</c> and
        /// <c>CertificateManagerClient.UpdateDnsAuthorizationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDnsAuthorizationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateManagerClient.UpdateDnsAuthorization</c> and
        /// <c>CertificateManagerClient.UpdateDnsAuthorizationAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateDnsAuthorizationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateManagerClient.DeleteDnsAuthorization</c> and
        /// <c>CertificateManagerClient.DeleteDnsAuthorizationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDnsAuthorizationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateManagerClient.DeleteDnsAuthorization</c> and
        /// <c>CertificateManagerClient.DeleteDnsAuthorizationAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteDnsAuthorizationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CertificateManagerSettings"/> object.</returns>
        public CertificateManagerSettings Clone() => new CertificateManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CertificateManagerClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CertificateManagerClientBuilder : gaxgrpc::ClientBuilderBase<CertificateManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CertificateManagerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CertificateManagerClientBuilder()
        {
            UseJwtAccessWithScopes = CertificateManagerClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref CertificateManagerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CertificateManagerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CertificateManagerClient Build()
        {
            CertificateManagerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CertificateManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CertificateManagerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CertificateManagerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CertificateManagerClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CertificateManagerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CertificateManagerClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CertificateManagerClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CertificateManagerClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CertificateManagerClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CertificateManager client wrapper, for convenient use.</summary>
    /// <remarks>
    /// API Overview
    /// 
    /// Certificates Manager API allows customers to see and manage all their TLS
    /// certificates.
    /// 
    /// Certificates Manager API service provides methods to manage certificates,
    /// group them into collections, and create serving configuration that can be
    /// easily applied to other Cloud resources e.g. Target Proxies.
    /// 
    /// Data Model
    /// 
    /// The Certificates Manager service exposes the following resources:
    /// 
    /// * `Certificate` which describes a single TLS certificate.
    /// * `CertificateMap` which describes a collection of certificates that can be
    /// attached to a target resource.
    /// * `CertificateMapEntry` which describes a single configuration entry that
    /// consists of a SNI and a group of certificates. It's a subresource of
    /// CertificateMap.
    /// 
    /// Certificate, CertificateMap and CertificateMapEntry IDs
    /// have to match "^[a-z0-9-]{1,63}$" regexp, which means that
    /// - only lower case letters, digits, and hyphen are allowed
    /// - length of the resource ID has to be in [1,63] range.
    /// 
    /// Provides methods to manage Cloud Certificate Manager entities.
    /// </remarks>
    public abstract partial class CertificateManagerClient
    {
        /// <summary>
        /// The default endpoint for the CertificateManager service, which is a host of
        /// "certificatemanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "certificatemanager.googleapis.com:443";

        /// <summary>The default CertificateManager scopes.</summary>
        /// <remarks>
        /// The default CertificateManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CertificateManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CertificateManagerClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CertificateManagerClient"/>.</returns>
        public static stt::Task<CertificateManagerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CertificateManagerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CertificateManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CertificateManagerClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="CertificateManagerClient"/>.</returns>
        public static CertificateManagerClient Create() => new CertificateManagerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CertificateManagerClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CertificateManagerSettings"/>.</param>
        /// <returns>The created <see cref="CertificateManagerClient"/>.</returns>
        internal static CertificateManagerClient Create(grpccore::CallInvoker callInvoker, CertificateManagerSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CertificateManager.CertificateManagerClient grpcClient = new CertificateManager.CertificateManagerClient(callInvoker);
            return new CertificateManagerClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC CertificateManager client</summary>
        public virtual CertificateManager.CertificateManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Certificates in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Certificate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificatesResponse, Certificate> ListCertificates(ListCertificatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Certificates in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Certificate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificatesResponse, Certificate> ListCertificatesAsync(ListCertificatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Certificates in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the certificate should be listed,
        /// specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Certificate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificatesResponse, Certificate> ListCertificates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificates(new ListCertificatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Certificates in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the certificate should be listed,
        /// specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Certificate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificatesResponse, Certificate> ListCertificatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificatesAsync(new ListCertificatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Certificates in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the certificate should be listed,
        /// specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Certificate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificatesResponse, Certificate> ListCertificates(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificates(new ListCertificatesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Certificates in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the certificate should be listed,
        /// specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Certificate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificatesResponse, Certificate> ListCertificatesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificatesAsync(new ListCertificatesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single Certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate GetCertificate(GetCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(GetCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(GetCertificateRequest request, st::CancellationToken cancellationToken) =>
            GetCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Certificate.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate to describe. Must be in the format
        /// `projects/*/locations/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate GetCertificate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificate(new GetCertificateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Certificate.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate to describe. Must be in the format
        /// `projects/*/locations/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAsync(new GetCertificateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Certificate.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate to describe. Must be in the format
        /// `projects/*/locations/*/certificates/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(string name, st::CancellationToken cancellationToken) =>
            GetCertificateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Certificate.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate to describe. Must be in the format
        /// `projects/*/locations/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate GetCertificate(CertificateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificate(new GetCertificateRequest
            {
                CertificateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Certificate.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate to describe. Must be in the format
        /// `projects/*/locations/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(CertificateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAsync(new GetCertificateRequest
            {
                CertificateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Certificate.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate to describe. Must be in the format
        /// `projects/*/locations/*/certificates/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(CertificateName name, st::CancellationToken cancellationToken) =>
            GetCertificateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Certificate in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Certificate, OperationMetadata> CreateCertificate(CreateCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Certificate in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Certificate, OperationMetadata>> CreateCertificateAsync(CreateCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Certificate in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Certificate, OperationMetadata>> CreateCertificateAsync(CreateCertificateRequest request, st::CancellationToken cancellationToken) =>
            CreateCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCertificate</c>.</summary>
        public virtual lro::OperationsClient CreateCertificateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCertificate</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Certificate, OperationMetadata> PollOnceCreateCertificate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Certificate, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCertificateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCertificate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Certificate, OperationMetadata>> PollOnceCreateCertificateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Certificate, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCertificateOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Certificate in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A definition of the certificate to create.
        /// </param>
        /// <param name="certificateId">
        /// Required. A user-provided name of the certificate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Certificate, OperationMetadata> CreateCertificate(string parent, Certificate certificate, string certificateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificate(new CreateCertificateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CertificateId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)),
                Certificate = gax::GaxPreconditions.CheckNotNull(certificate, nameof(certificate)),
            }, callSettings);

        /// <summary>
        /// Creates a new Certificate in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A definition of the certificate to create.
        /// </param>
        /// <param name="certificateId">
        /// Required. A user-provided name of the certificate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Certificate, OperationMetadata>> CreateCertificateAsync(string parent, Certificate certificate, string certificateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateAsync(new CreateCertificateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CertificateId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)),
                Certificate = gax::GaxPreconditions.CheckNotNull(certificate, nameof(certificate)),
            }, callSettings);

        /// <summary>
        /// Creates a new Certificate in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A definition of the certificate to create.
        /// </param>
        /// <param name="certificateId">
        /// Required. A user-provided name of the certificate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Certificate, OperationMetadata>> CreateCertificateAsync(string parent, Certificate certificate, string certificateId, st::CancellationToken cancellationToken) =>
            CreateCertificateAsync(parent, certificate, certificateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Certificate in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A definition of the certificate to create.
        /// </param>
        /// <param name="certificateId">
        /// Required. A user-provided name of the certificate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Certificate, OperationMetadata> CreateCertificate(gagr::LocationName parent, Certificate certificate, string certificateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificate(new CreateCertificateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)),
                Certificate = gax::GaxPreconditions.CheckNotNull(certificate, nameof(certificate)),
            }, callSettings);

        /// <summary>
        /// Creates a new Certificate in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A definition of the certificate to create.
        /// </param>
        /// <param name="certificateId">
        /// Required. A user-provided name of the certificate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Certificate, OperationMetadata>> CreateCertificateAsync(gagr::LocationName parent, Certificate certificate, string certificateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateAsync(new CreateCertificateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)),
                Certificate = gax::GaxPreconditions.CheckNotNull(certificate, nameof(certificate)),
            }, callSettings);

        /// <summary>
        /// Creates a new Certificate in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A definition of the certificate to create.
        /// </param>
        /// <param name="certificateId">
        /// Required. A user-provided name of the certificate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Certificate, OperationMetadata>> CreateCertificateAsync(gagr::LocationName parent, Certificate certificate, string certificateId, st::CancellationToken cancellationToken) =>
            CreateCertificateAsync(parent, certificate, certificateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Certificate, OperationMetadata> UpdateCertificate(UpdateCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Certificate, OperationMetadata>> UpdateCertificateAsync(UpdateCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Certificate, OperationMetadata>> UpdateCertificateAsync(UpdateCertificateRequest request, st::CancellationToken cancellationToken) =>
            UpdateCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCertificate</c>.</summary>
        public virtual lro::OperationsClient UpdateCertificateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCertificate</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Certificate, OperationMetadata> PollOnceUpdateCertificate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Certificate, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCertificateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCertificate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Certificate, OperationMetadata>> PollOnceUpdateCertificateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Certificate, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCertificateOperationsClient, callSettings);

        /// <summary>
        /// Updates a Certificate.
        /// </summary>
        /// <param name="certificate">
        /// Required. A definition of the certificate to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Certificate, OperationMetadata> UpdateCertificate(Certificate certificate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCertificate(new UpdateCertificateRequest
            {
                Certificate = gax::GaxPreconditions.CheckNotNull(certificate, nameof(certificate)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Certificate.
        /// </summary>
        /// <param name="certificate">
        /// Required. A definition of the certificate to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Certificate, OperationMetadata>> UpdateCertificateAsync(Certificate certificate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCertificateAsync(new UpdateCertificateRequest
            {
                Certificate = gax::GaxPreconditions.CheckNotNull(certificate, nameof(certificate)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Certificate.
        /// </summary>
        /// <param name="certificate">
        /// Required. A definition of the certificate to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Certificate, OperationMetadata>> UpdateCertificateAsync(Certificate certificate, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCertificateAsync(certificate, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificate(DeleteCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateAsync(DeleteCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateAsync(DeleteCertificateRequest request, st::CancellationToken cancellationToken) =>
            DeleteCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCertificate</c>.</summary>
        public virtual lro::OperationsClient DeleteCertificateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCertificate</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteCertificate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCertificateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCertificate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteCertificateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCertificateOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Certificate.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate to delete. Must be in the format
        /// `projects/*/locations/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificate(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificate(new DeleteCertificateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Certificate.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate to delete. Must be in the format
        /// `projects/*/locations/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateAsync(new DeleteCertificateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Certificate.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate to delete. Must be in the format
        /// `projects/*/locations/*/certificates/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCertificateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Certificate.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate to delete. Must be in the format
        /// `projects/*/locations/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificate(CertificateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificate(new DeleteCertificateRequest
            {
                CertificateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Certificate.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate to delete. Must be in the format
        /// `projects/*/locations/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateAsync(CertificateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateAsync(new DeleteCertificateRequest
            {
                CertificateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Certificate.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate to delete. Must be in the format
        /// `projects/*/locations/*/certificates/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateAsync(CertificateName name, st::CancellationToken cancellationToken) =>
            DeleteCertificateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists CertificateMaps in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateMap"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateMapsResponse, CertificateMap> ListCertificateMaps(ListCertificateMapsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CertificateMaps in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateMap"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateMapsResponse, CertificateMap> ListCertificateMapsAsync(ListCertificateMapsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CertificateMaps in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the certificate maps should be listed,
        /// specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateMap"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateMapsResponse, CertificateMap> ListCertificateMaps(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateMaps(new ListCertificateMapsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists CertificateMaps in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the certificate maps should be listed,
        /// specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateMap"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateMapsResponse, CertificateMap> ListCertificateMapsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateMapsAsync(new ListCertificateMapsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists CertificateMaps in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the certificate maps should be listed,
        /// specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateMap"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateMapsResponse, CertificateMap> ListCertificateMaps(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateMaps(new ListCertificateMapsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists CertificateMaps in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the certificate maps should be listed,
        /// specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateMap"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateMapsResponse, CertificateMap> ListCertificateMapsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateMapsAsync(new ListCertificateMapsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single CertificateMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateMap GetCertificateMap(GetCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single CertificateMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateMap> GetCertificateMapAsync(GetCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single CertificateMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateMap> GetCertificateMapAsync(GetCertificateMapRequest request, st::CancellationToken cancellationToken) =>
            GetCertificateMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single CertificateMap.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map to describe. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateMap GetCertificateMap(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateMap(new GetCertificateMapRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CertificateMap.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map to describe. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateMap> GetCertificateMapAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateMapAsync(new GetCertificateMapRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CertificateMap.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map to describe. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateMap> GetCertificateMapAsync(string name, st::CancellationToken cancellationToken) =>
            GetCertificateMapAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single CertificateMap.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map to describe. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateMap GetCertificateMap(CertificateMapName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateMap(new GetCertificateMapRequest
            {
                CertificateMapName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CertificateMap.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map to describe. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateMap> GetCertificateMapAsync(CertificateMapName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateMapAsync(new GetCertificateMapRequest
            {
                CertificateMapName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CertificateMap.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map to describe. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateMap> GetCertificateMapAsync(CertificateMapName name, st::CancellationToken cancellationToken) =>
            GetCertificateMapAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new CertificateMap in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateMap, OperationMetadata> CreateCertificateMap(CreateCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new CertificateMap in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMap, OperationMetadata>> CreateCertificateMapAsync(CreateCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new CertificateMap in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMap, OperationMetadata>> CreateCertificateMapAsync(CreateCertificateMapRequest request, st::CancellationToken cancellationToken) =>
            CreateCertificateMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCertificateMap</c>.</summary>
        public virtual lro::OperationsClient CreateCertificateMapOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCertificateMap</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateMap, OperationMetadata> PollOnceCreateCertificateMap(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateMap, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCertificateMapOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCertificateMap</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateMap, OperationMetadata>> PollOnceCreateCertificateMapAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateMap, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCertificateMapOperationsClient, callSettings);

        /// <summary>
        /// Creates a new CertificateMap in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate map. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateMap">
        /// Required. A definition of the certificate map to create.
        /// </param>
        /// <param name="certificateMapId">
        /// Required. A user-provided name of the certificate map.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateMap, OperationMetadata> CreateCertificateMap(string parent, CertificateMap certificateMap, string certificateMapId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateMap(new CreateCertificateMapRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CertificateMapId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapId, nameof(certificateMapId)),
                CertificateMap = gax::GaxPreconditions.CheckNotNull(certificateMap, nameof(certificateMap)),
            }, callSettings);

        /// <summary>
        /// Creates a new CertificateMap in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate map. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateMap">
        /// Required. A definition of the certificate map to create.
        /// </param>
        /// <param name="certificateMapId">
        /// Required. A user-provided name of the certificate map.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMap, OperationMetadata>> CreateCertificateMapAsync(string parent, CertificateMap certificateMap, string certificateMapId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateMapAsync(new CreateCertificateMapRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CertificateMapId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapId, nameof(certificateMapId)),
                CertificateMap = gax::GaxPreconditions.CheckNotNull(certificateMap, nameof(certificateMap)),
            }, callSettings);

        /// <summary>
        /// Creates a new CertificateMap in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate map. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateMap">
        /// Required. A definition of the certificate map to create.
        /// </param>
        /// <param name="certificateMapId">
        /// Required. A user-provided name of the certificate map.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMap, OperationMetadata>> CreateCertificateMapAsync(string parent, CertificateMap certificateMap, string certificateMapId, st::CancellationToken cancellationToken) =>
            CreateCertificateMapAsync(parent, certificateMap, certificateMapId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new CertificateMap in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate map. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateMap">
        /// Required. A definition of the certificate map to create.
        /// </param>
        /// <param name="certificateMapId">
        /// Required. A user-provided name of the certificate map.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateMap, OperationMetadata> CreateCertificateMap(gagr::LocationName parent, CertificateMap certificateMap, string certificateMapId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateMap(new CreateCertificateMapRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateMapId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapId, nameof(certificateMapId)),
                CertificateMap = gax::GaxPreconditions.CheckNotNull(certificateMap, nameof(certificateMap)),
            }, callSettings);

        /// <summary>
        /// Creates a new CertificateMap in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate map. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateMap">
        /// Required. A definition of the certificate map to create.
        /// </param>
        /// <param name="certificateMapId">
        /// Required. A user-provided name of the certificate map.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMap, OperationMetadata>> CreateCertificateMapAsync(gagr::LocationName parent, CertificateMap certificateMap, string certificateMapId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateMapAsync(new CreateCertificateMapRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateMapId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapId, nameof(certificateMapId)),
                CertificateMap = gax::GaxPreconditions.CheckNotNull(certificateMap, nameof(certificateMap)),
            }, callSettings);

        /// <summary>
        /// Creates a new CertificateMap in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate map. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateMap">
        /// Required. A definition of the certificate map to create.
        /// </param>
        /// <param name="certificateMapId">
        /// Required. A user-provided name of the certificate map.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMap, OperationMetadata>> CreateCertificateMapAsync(gagr::LocationName parent, CertificateMap certificateMap, string certificateMapId, st::CancellationToken cancellationToken) =>
            CreateCertificateMapAsync(parent, certificateMap, certificateMapId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a CertificateMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateMap, OperationMetadata> UpdateCertificateMap(UpdateCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a CertificateMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMap, OperationMetadata>> UpdateCertificateMapAsync(UpdateCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a CertificateMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMap, OperationMetadata>> UpdateCertificateMapAsync(UpdateCertificateMapRequest request, st::CancellationToken cancellationToken) =>
            UpdateCertificateMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCertificateMap</c>.</summary>
        public virtual lro::OperationsClient UpdateCertificateMapOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCertificateMap</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateMap, OperationMetadata> PollOnceUpdateCertificateMap(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateMap, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCertificateMapOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCertificateMap</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateMap, OperationMetadata>> PollOnceUpdateCertificateMapAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateMap, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCertificateMapOperationsClient, callSettings);

        /// <summary>
        /// Updates a CertificateMap.
        /// </summary>
        /// <param name="certificateMap">
        /// Required. A definition of the certificate map to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateMap, OperationMetadata> UpdateCertificateMap(CertificateMap certificateMap, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCertificateMap(new UpdateCertificateMapRequest
            {
                CertificateMap = gax::GaxPreconditions.CheckNotNull(certificateMap, nameof(certificateMap)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a CertificateMap.
        /// </summary>
        /// <param name="certificateMap">
        /// Required. A definition of the certificate map to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMap, OperationMetadata>> UpdateCertificateMapAsync(CertificateMap certificateMap, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCertificateMapAsync(new UpdateCertificateMapRequest
            {
                CertificateMap = gax::GaxPreconditions.CheckNotNull(certificateMap, nameof(certificateMap)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a CertificateMap.
        /// </summary>
        /// <param name="certificateMap">
        /// Required. A definition of the certificate map to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMap, OperationMetadata>> UpdateCertificateMapAsync(CertificateMap certificateMap, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCertificateMapAsync(certificateMap, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single CertificateMap. A Certificate Map can't be deleted
        /// if it contains Certificate Map Entries. Remove all the entries from
        /// the map before calling this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificateMap(DeleteCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single CertificateMap. A Certificate Map can't be deleted
        /// if it contains Certificate Map Entries. Remove all the entries from
        /// the map before calling this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateMapAsync(DeleteCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single CertificateMap. A Certificate Map can't be deleted
        /// if it contains Certificate Map Entries. Remove all the entries from
        /// the map before calling this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateMapAsync(DeleteCertificateMapRequest request, st::CancellationToken cancellationToken) =>
            DeleteCertificateMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCertificateMap</c>.</summary>
        public virtual lro::OperationsClient DeleteCertificateMapOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCertificateMap</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteCertificateMap(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCertificateMapOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCertificateMap</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteCertificateMapAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCertificateMapOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single CertificateMap. A Certificate Map can't be deleted
        /// if it contains Certificate Map Entries. Remove all the entries from
        /// the map before calling this method.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map to delete. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificateMap(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateMap(new DeleteCertificateMapRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CertificateMap. A Certificate Map can't be deleted
        /// if it contains Certificate Map Entries. Remove all the entries from
        /// the map before calling this method.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map to delete. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateMapAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateMapAsync(new DeleteCertificateMapRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CertificateMap. A Certificate Map can't be deleted
        /// if it contains Certificate Map Entries. Remove all the entries from
        /// the map before calling this method.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map to delete. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateMapAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCertificateMapAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single CertificateMap. A Certificate Map can't be deleted
        /// if it contains Certificate Map Entries. Remove all the entries from
        /// the map before calling this method.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map to delete. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificateMap(CertificateMapName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateMap(new DeleteCertificateMapRequest
            {
                CertificateMapName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CertificateMap. A Certificate Map can't be deleted
        /// if it contains Certificate Map Entries. Remove all the entries from
        /// the map before calling this method.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map to delete. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateMapAsync(CertificateMapName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateMapAsync(new DeleteCertificateMapRequest
            {
                CertificateMapName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CertificateMap. A Certificate Map can't be deleted
        /// if it contains Certificate Map Entries. Remove all the entries from
        /// the map before calling this method.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map to delete. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateMapAsync(CertificateMapName name, st::CancellationToken cancellationToken) =>
            DeleteCertificateMapAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists CertificateMapEntries in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateMapEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateMapEntriesResponse, CertificateMapEntry> ListCertificateMapEntries(ListCertificateMapEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CertificateMapEntries in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateMapEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateMapEntriesResponse, CertificateMapEntry> ListCertificateMapEntriesAsync(ListCertificateMapEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CertificateMapEntries in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project, location and certificate map from which the certificate map
        /// entries should be listed, specified in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateMapEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateMapEntriesResponse, CertificateMapEntry> ListCertificateMapEntries(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateMapEntries(new ListCertificateMapEntriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists CertificateMapEntries in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project, location and certificate map from which the certificate map
        /// entries should be listed, specified in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateMapEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateMapEntriesResponse, CertificateMapEntry> ListCertificateMapEntriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateMapEntriesAsync(new ListCertificateMapEntriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists CertificateMapEntries in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project, location and certificate map from which the certificate map
        /// entries should be listed, specified in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateMapEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateMapEntriesResponse, CertificateMapEntry> ListCertificateMapEntries(CertificateMapName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateMapEntries(new ListCertificateMapEntriesRequest
            {
                ParentAsCertificateMapName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists CertificateMapEntries in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project, location and certificate map from which the certificate map
        /// entries should be listed, specified in the format
        /// `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateMapEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateMapEntriesResponse, CertificateMapEntry> ListCertificateMapEntriesAsync(CertificateMapName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateMapEntriesAsync(new ListCertificateMapEntriesRequest
            {
                ParentAsCertificateMapName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single CertificateMapEntry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateMapEntry GetCertificateMapEntry(GetCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single CertificateMapEntry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateMapEntry> GetCertificateMapEntryAsync(GetCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single CertificateMapEntry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateMapEntry> GetCertificateMapEntryAsync(GetCertificateMapEntryRequest request, st::CancellationToken cancellationToken) =>
            GetCertificateMapEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single CertificateMapEntry.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map entry to describe. Must be in the
        /// format `projects/*/locations/*/certificateMaps/*/certificateMapEntries/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateMapEntry GetCertificateMapEntry(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateMapEntry(new GetCertificateMapEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CertificateMapEntry.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map entry to describe. Must be in the
        /// format `projects/*/locations/*/certificateMaps/*/certificateMapEntries/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateMapEntry> GetCertificateMapEntryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateMapEntryAsync(new GetCertificateMapEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CertificateMapEntry.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map entry to describe. Must be in the
        /// format `projects/*/locations/*/certificateMaps/*/certificateMapEntries/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateMapEntry> GetCertificateMapEntryAsync(string name, st::CancellationToken cancellationToken) =>
            GetCertificateMapEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single CertificateMapEntry.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map entry to describe. Must be in the
        /// format `projects/*/locations/*/certificateMaps/*/certificateMapEntries/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateMapEntry GetCertificateMapEntry(CertificateMapEntryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateMapEntry(new GetCertificateMapEntryRequest
            {
                CertificateMapEntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CertificateMapEntry.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map entry to describe. Must be in the
        /// format `projects/*/locations/*/certificateMaps/*/certificateMapEntries/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateMapEntry> GetCertificateMapEntryAsync(CertificateMapEntryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateMapEntryAsync(new GetCertificateMapEntryRequest
            {
                CertificateMapEntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CertificateMapEntry.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map entry to describe. Must be in the
        /// format `projects/*/locations/*/certificateMaps/*/certificateMapEntries/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateMapEntry> GetCertificateMapEntryAsync(CertificateMapEntryName name, st::CancellationToken cancellationToken) =>
            GetCertificateMapEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new CertificateMapEntry in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateMapEntry, OperationMetadata> CreateCertificateMapEntry(CreateCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new CertificateMapEntry in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMapEntry, OperationMetadata>> CreateCertificateMapEntryAsync(CreateCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new CertificateMapEntry in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMapEntry, OperationMetadata>> CreateCertificateMapEntryAsync(CreateCertificateMapEntryRequest request, st::CancellationToken cancellationToken) =>
            CreateCertificateMapEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCertificateMapEntry</c>.</summary>
        public virtual lro::OperationsClient CreateCertificateMapEntryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCertificateMapEntry</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateMapEntry, OperationMetadata> PollOnceCreateCertificateMapEntry(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateMapEntry, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCertificateMapEntryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCertificateMapEntry</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateMapEntry, OperationMetadata>> PollOnceCreateCertificateMapEntryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateMapEntry, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCertificateMapEntryOperationsClient, callSettings);

        /// <summary>
        /// Creates a new CertificateMapEntry in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate map entry. Must be in the
        /// format `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="certificateMapEntry">
        /// Required. A definition of the certificate map entry to create.
        /// </param>
        /// <param name="certificateMapEntryId">
        /// Required. A user-provided name of the certificate map entry.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateMapEntry, OperationMetadata> CreateCertificateMapEntry(string parent, CertificateMapEntry certificateMapEntry, string certificateMapEntryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateMapEntry(new CreateCertificateMapEntryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CertificateMapEntryId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapEntryId, nameof(certificateMapEntryId)),
                CertificateMapEntry = gax::GaxPreconditions.CheckNotNull(certificateMapEntry, nameof(certificateMapEntry)),
            }, callSettings);

        /// <summary>
        /// Creates a new CertificateMapEntry in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate map entry. Must be in the
        /// format `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="certificateMapEntry">
        /// Required. A definition of the certificate map entry to create.
        /// </param>
        /// <param name="certificateMapEntryId">
        /// Required. A user-provided name of the certificate map entry.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMapEntry, OperationMetadata>> CreateCertificateMapEntryAsync(string parent, CertificateMapEntry certificateMapEntry, string certificateMapEntryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateMapEntryAsync(new CreateCertificateMapEntryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CertificateMapEntryId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapEntryId, nameof(certificateMapEntryId)),
                CertificateMapEntry = gax::GaxPreconditions.CheckNotNull(certificateMapEntry, nameof(certificateMapEntry)),
            }, callSettings);

        /// <summary>
        /// Creates a new CertificateMapEntry in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate map entry. Must be in the
        /// format `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="certificateMapEntry">
        /// Required. A definition of the certificate map entry to create.
        /// </param>
        /// <param name="certificateMapEntryId">
        /// Required. A user-provided name of the certificate map entry.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMapEntry, OperationMetadata>> CreateCertificateMapEntryAsync(string parent, CertificateMapEntry certificateMapEntry, string certificateMapEntryId, st::CancellationToken cancellationToken) =>
            CreateCertificateMapEntryAsync(parent, certificateMapEntry, certificateMapEntryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new CertificateMapEntry in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate map entry. Must be in the
        /// format `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="certificateMapEntry">
        /// Required. A definition of the certificate map entry to create.
        /// </param>
        /// <param name="certificateMapEntryId">
        /// Required. A user-provided name of the certificate map entry.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateMapEntry, OperationMetadata> CreateCertificateMapEntry(CertificateMapName parent, CertificateMapEntry certificateMapEntry, string certificateMapEntryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateMapEntry(new CreateCertificateMapEntryRequest
            {
                ParentAsCertificateMapName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateMapEntryId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapEntryId, nameof(certificateMapEntryId)),
                CertificateMapEntry = gax::GaxPreconditions.CheckNotNull(certificateMapEntry, nameof(certificateMapEntry)),
            }, callSettings);

        /// <summary>
        /// Creates a new CertificateMapEntry in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate map entry. Must be in the
        /// format `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="certificateMapEntry">
        /// Required. A definition of the certificate map entry to create.
        /// </param>
        /// <param name="certificateMapEntryId">
        /// Required. A user-provided name of the certificate map entry.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMapEntry, OperationMetadata>> CreateCertificateMapEntryAsync(CertificateMapName parent, CertificateMapEntry certificateMapEntry, string certificateMapEntryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateMapEntryAsync(new CreateCertificateMapEntryRequest
            {
                ParentAsCertificateMapName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateMapEntryId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapEntryId, nameof(certificateMapEntryId)),
                CertificateMapEntry = gax::GaxPreconditions.CheckNotNull(certificateMapEntry, nameof(certificateMapEntry)),
            }, callSettings);

        /// <summary>
        /// Creates a new CertificateMapEntry in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the certificate map entry. Must be in the
        /// format `projects/*/locations/*/certificateMaps/*`.
        /// </param>
        /// <param name="certificateMapEntry">
        /// Required. A definition of the certificate map entry to create.
        /// </param>
        /// <param name="certificateMapEntryId">
        /// Required. A user-provided name of the certificate map entry.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMapEntry, OperationMetadata>> CreateCertificateMapEntryAsync(CertificateMapName parent, CertificateMapEntry certificateMapEntry, string certificateMapEntryId, st::CancellationToken cancellationToken) =>
            CreateCertificateMapEntryAsync(parent, certificateMapEntry, certificateMapEntryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a CertificateMapEntry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateMapEntry, OperationMetadata> UpdateCertificateMapEntry(UpdateCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a CertificateMapEntry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMapEntry, OperationMetadata>> UpdateCertificateMapEntryAsync(UpdateCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a CertificateMapEntry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMapEntry, OperationMetadata>> UpdateCertificateMapEntryAsync(UpdateCertificateMapEntryRequest request, st::CancellationToken cancellationToken) =>
            UpdateCertificateMapEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCertificateMapEntry</c>.</summary>
        public virtual lro::OperationsClient UpdateCertificateMapEntryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCertificateMapEntry</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateMapEntry, OperationMetadata> PollOnceUpdateCertificateMapEntry(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateMapEntry, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCertificateMapEntryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCertificateMapEntry</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateMapEntry, OperationMetadata>> PollOnceUpdateCertificateMapEntryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateMapEntry, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCertificateMapEntryOperationsClient, callSettings);

        /// <summary>
        /// Updates a CertificateMapEntry.
        /// </summary>
        /// <param name="certificateMapEntry">
        /// Required. A definition of the certificate map entry to create map entry.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateMapEntry, OperationMetadata> UpdateCertificateMapEntry(CertificateMapEntry certificateMapEntry, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCertificateMapEntry(new UpdateCertificateMapEntryRequest
            {
                CertificateMapEntry = gax::GaxPreconditions.CheckNotNull(certificateMapEntry, nameof(certificateMapEntry)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a CertificateMapEntry.
        /// </summary>
        /// <param name="certificateMapEntry">
        /// Required. A definition of the certificate map entry to create map entry.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMapEntry, OperationMetadata>> UpdateCertificateMapEntryAsync(CertificateMapEntry certificateMapEntry, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCertificateMapEntryAsync(new UpdateCertificateMapEntryRequest
            {
                CertificateMapEntry = gax::GaxPreconditions.CheckNotNull(certificateMapEntry, nameof(certificateMapEntry)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a CertificateMapEntry.
        /// </summary>
        /// <param name="certificateMapEntry">
        /// Required. A definition of the certificate map entry to create map entry.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateMapEntry, OperationMetadata>> UpdateCertificateMapEntryAsync(CertificateMapEntry certificateMapEntry, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCertificateMapEntryAsync(certificateMapEntry, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single CertificateMapEntry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificateMapEntry(DeleteCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single CertificateMapEntry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateMapEntryAsync(DeleteCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single CertificateMapEntry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateMapEntryAsync(DeleteCertificateMapEntryRequest request, st::CancellationToken cancellationToken) =>
            DeleteCertificateMapEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCertificateMapEntry</c>.</summary>
        public virtual lro::OperationsClient DeleteCertificateMapEntryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCertificateMapEntry</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteCertificateMapEntry(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCertificateMapEntryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCertificateMapEntry</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteCertificateMapEntryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCertificateMapEntryOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single CertificateMapEntry.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map entry to delete. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*/certificateMapEntries/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificateMapEntry(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateMapEntry(new DeleteCertificateMapEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CertificateMapEntry.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map entry to delete. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*/certificateMapEntries/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateMapEntryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateMapEntryAsync(new DeleteCertificateMapEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CertificateMapEntry.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map entry to delete. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*/certificateMapEntries/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateMapEntryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCertificateMapEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single CertificateMapEntry.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map entry to delete. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*/certificateMapEntries/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificateMapEntry(CertificateMapEntryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateMapEntry(new DeleteCertificateMapEntryRequest
            {
                CertificateMapEntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CertificateMapEntry.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map entry to delete. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*/certificateMapEntries/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateMapEntryAsync(CertificateMapEntryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateMapEntryAsync(new DeleteCertificateMapEntryRequest
            {
                CertificateMapEntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CertificateMapEntry.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the certificate map entry to delete. Must be in the format
        /// `projects/*/locations/*/certificateMaps/*/certificateMapEntries/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateMapEntryAsync(CertificateMapEntryName name, st::CancellationToken cancellationToken) =>
            DeleteCertificateMapEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists DnsAuthorizations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DnsAuthorization"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDnsAuthorizationsResponse, DnsAuthorization> ListDnsAuthorizations(ListDnsAuthorizationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DnsAuthorizations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DnsAuthorization"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDnsAuthorizationsResponse, DnsAuthorization> ListDnsAuthorizationsAsync(ListDnsAuthorizationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DnsAuthorizations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the dns authorizations should be
        /// listed, specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DnsAuthorization"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDnsAuthorizationsResponse, DnsAuthorization> ListDnsAuthorizations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDnsAuthorizations(new ListDnsAuthorizationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists DnsAuthorizations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the dns authorizations should be
        /// listed, specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DnsAuthorization"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDnsAuthorizationsResponse, DnsAuthorization> ListDnsAuthorizationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDnsAuthorizationsAsync(new ListDnsAuthorizationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists DnsAuthorizations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the dns authorizations should be
        /// listed, specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DnsAuthorization"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDnsAuthorizationsResponse, DnsAuthorization> ListDnsAuthorizations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDnsAuthorizations(new ListDnsAuthorizationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists DnsAuthorizations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the dns authorizations should be
        /// listed, specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DnsAuthorization"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDnsAuthorizationsResponse, DnsAuthorization> ListDnsAuthorizationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDnsAuthorizationsAsync(new ListDnsAuthorizationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single DnsAuthorization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DnsAuthorization GetDnsAuthorization(GetDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single DnsAuthorization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsAuthorization> GetDnsAuthorizationAsync(GetDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single DnsAuthorization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsAuthorization> GetDnsAuthorizationAsync(GetDnsAuthorizationRequest request, st::CancellationToken cancellationToken) =>
            GetDnsAuthorizationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single DnsAuthorization.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the dns authorization to describe. Must be in the format
        /// `projects/*/locations/*/dnsAuthorizations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DnsAuthorization GetDnsAuthorization(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDnsAuthorization(new GetDnsAuthorizationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DnsAuthorization.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the dns authorization to describe. Must be in the format
        /// `projects/*/locations/*/dnsAuthorizations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsAuthorization> GetDnsAuthorizationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDnsAuthorizationAsync(new GetDnsAuthorizationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DnsAuthorization.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the dns authorization to describe. Must be in the format
        /// `projects/*/locations/*/dnsAuthorizations/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsAuthorization> GetDnsAuthorizationAsync(string name, st::CancellationToken cancellationToken) =>
            GetDnsAuthorizationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single DnsAuthorization.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the dns authorization to describe. Must be in the format
        /// `projects/*/locations/*/dnsAuthorizations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DnsAuthorization GetDnsAuthorization(DnsAuthorizationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDnsAuthorization(new GetDnsAuthorizationRequest
            {
                DnsAuthorizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DnsAuthorization.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the dns authorization to describe. Must be in the format
        /// `projects/*/locations/*/dnsAuthorizations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsAuthorization> GetDnsAuthorizationAsync(DnsAuthorizationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDnsAuthorizationAsync(new GetDnsAuthorizationRequest
            {
                DnsAuthorizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DnsAuthorization.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the dns authorization to describe. Must be in the format
        /// `projects/*/locations/*/dnsAuthorizations/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsAuthorization> GetDnsAuthorizationAsync(DnsAuthorizationName name, st::CancellationToken cancellationToken) =>
            GetDnsAuthorizationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new DnsAuthorization in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DnsAuthorization, OperationMetadata> CreateDnsAuthorization(CreateDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new DnsAuthorization in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DnsAuthorization, OperationMetadata>> CreateDnsAuthorizationAsync(CreateDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new DnsAuthorization in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DnsAuthorization, OperationMetadata>> CreateDnsAuthorizationAsync(CreateDnsAuthorizationRequest request, st::CancellationToken cancellationToken) =>
            CreateDnsAuthorizationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDnsAuthorization</c>.</summary>
        public virtual lro::OperationsClient CreateDnsAuthorizationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDnsAuthorization</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DnsAuthorization, OperationMetadata> PollOnceCreateDnsAuthorization(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DnsAuthorization, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDnsAuthorizationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDnsAuthorization</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DnsAuthorization, OperationMetadata>> PollOnceCreateDnsAuthorizationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DnsAuthorization, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDnsAuthorizationOperationsClient, callSettings);

        /// <summary>
        /// Creates a new DnsAuthorization in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the dns authorization. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="dnsAuthorization">
        /// Required. A definition of the dns authorization to create.
        /// </param>
        /// <param name="dnsAuthorizationId">
        /// Required. A user-provided name of the dns authorization.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DnsAuthorization, OperationMetadata> CreateDnsAuthorization(string parent, DnsAuthorization dnsAuthorization, string dnsAuthorizationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDnsAuthorization(new CreateDnsAuthorizationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DnsAuthorizationId = gax::GaxPreconditions.CheckNotNullOrEmpty(dnsAuthorizationId, nameof(dnsAuthorizationId)),
                DnsAuthorization = gax::GaxPreconditions.CheckNotNull(dnsAuthorization, nameof(dnsAuthorization)),
            }, callSettings);

        /// <summary>
        /// Creates a new DnsAuthorization in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the dns authorization. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="dnsAuthorization">
        /// Required. A definition of the dns authorization to create.
        /// </param>
        /// <param name="dnsAuthorizationId">
        /// Required. A user-provided name of the dns authorization.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DnsAuthorization, OperationMetadata>> CreateDnsAuthorizationAsync(string parent, DnsAuthorization dnsAuthorization, string dnsAuthorizationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDnsAuthorizationAsync(new CreateDnsAuthorizationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DnsAuthorizationId = gax::GaxPreconditions.CheckNotNullOrEmpty(dnsAuthorizationId, nameof(dnsAuthorizationId)),
                DnsAuthorization = gax::GaxPreconditions.CheckNotNull(dnsAuthorization, nameof(dnsAuthorization)),
            }, callSettings);

        /// <summary>
        /// Creates a new DnsAuthorization in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the dns authorization. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="dnsAuthorization">
        /// Required. A definition of the dns authorization to create.
        /// </param>
        /// <param name="dnsAuthorizationId">
        /// Required. A user-provided name of the dns authorization.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DnsAuthorization, OperationMetadata>> CreateDnsAuthorizationAsync(string parent, DnsAuthorization dnsAuthorization, string dnsAuthorizationId, st::CancellationToken cancellationToken) =>
            CreateDnsAuthorizationAsync(parent, dnsAuthorization, dnsAuthorizationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new DnsAuthorization in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the dns authorization. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="dnsAuthorization">
        /// Required. A definition of the dns authorization to create.
        /// </param>
        /// <param name="dnsAuthorizationId">
        /// Required. A user-provided name of the dns authorization.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DnsAuthorization, OperationMetadata> CreateDnsAuthorization(gagr::LocationName parent, DnsAuthorization dnsAuthorization, string dnsAuthorizationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDnsAuthorization(new CreateDnsAuthorizationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DnsAuthorizationId = gax::GaxPreconditions.CheckNotNullOrEmpty(dnsAuthorizationId, nameof(dnsAuthorizationId)),
                DnsAuthorization = gax::GaxPreconditions.CheckNotNull(dnsAuthorization, nameof(dnsAuthorization)),
            }, callSettings);

        /// <summary>
        /// Creates a new DnsAuthorization in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the dns authorization. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="dnsAuthorization">
        /// Required. A definition of the dns authorization to create.
        /// </param>
        /// <param name="dnsAuthorizationId">
        /// Required. A user-provided name of the dns authorization.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DnsAuthorization, OperationMetadata>> CreateDnsAuthorizationAsync(gagr::LocationName parent, DnsAuthorization dnsAuthorization, string dnsAuthorizationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDnsAuthorizationAsync(new CreateDnsAuthorizationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DnsAuthorizationId = gax::GaxPreconditions.CheckNotNullOrEmpty(dnsAuthorizationId, nameof(dnsAuthorizationId)),
                DnsAuthorization = gax::GaxPreconditions.CheckNotNull(dnsAuthorization, nameof(dnsAuthorization)),
            }, callSettings);

        /// <summary>
        /// Creates a new DnsAuthorization in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the dns authorization. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="dnsAuthorization">
        /// Required. A definition of the dns authorization to create.
        /// </param>
        /// <param name="dnsAuthorizationId">
        /// Required. A user-provided name of the dns authorization.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DnsAuthorization, OperationMetadata>> CreateDnsAuthorizationAsync(gagr::LocationName parent, DnsAuthorization dnsAuthorization, string dnsAuthorizationId, st::CancellationToken cancellationToken) =>
            CreateDnsAuthorizationAsync(parent, dnsAuthorization, dnsAuthorizationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a DnsAuthorization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DnsAuthorization, OperationMetadata> UpdateDnsAuthorization(UpdateDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a DnsAuthorization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DnsAuthorization, OperationMetadata>> UpdateDnsAuthorizationAsync(UpdateDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a DnsAuthorization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DnsAuthorization, OperationMetadata>> UpdateDnsAuthorizationAsync(UpdateDnsAuthorizationRequest request, st::CancellationToken cancellationToken) =>
            UpdateDnsAuthorizationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDnsAuthorization</c>.</summary>
        public virtual lro::OperationsClient UpdateDnsAuthorizationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDnsAuthorization</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DnsAuthorization, OperationMetadata> PollOnceUpdateDnsAuthorization(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DnsAuthorization, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDnsAuthorizationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDnsAuthorization</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DnsAuthorization, OperationMetadata>> PollOnceUpdateDnsAuthorizationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DnsAuthorization, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDnsAuthorizationOperationsClient, callSettings);

        /// <summary>
        /// Updates a DnsAuthorization.
        /// </summary>
        /// <param name="dnsAuthorization">
        /// Required. A definition of the dns authorization to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DnsAuthorization, OperationMetadata> UpdateDnsAuthorization(DnsAuthorization dnsAuthorization, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDnsAuthorization(new UpdateDnsAuthorizationRequest
            {
                DnsAuthorization = gax::GaxPreconditions.CheckNotNull(dnsAuthorization, nameof(dnsAuthorization)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a DnsAuthorization.
        /// </summary>
        /// <param name="dnsAuthorization">
        /// Required. A definition of the dns authorization to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DnsAuthorization, OperationMetadata>> UpdateDnsAuthorizationAsync(DnsAuthorization dnsAuthorization, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDnsAuthorizationAsync(new UpdateDnsAuthorizationRequest
            {
                DnsAuthorization = gax::GaxPreconditions.CheckNotNull(dnsAuthorization, nameof(dnsAuthorization)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a DnsAuthorization.
        /// </summary>
        /// <param name="dnsAuthorization">
        /// Required. A definition of the dns authorization to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DnsAuthorization, OperationMetadata>> UpdateDnsAuthorizationAsync(DnsAuthorization dnsAuthorization, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDnsAuthorizationAsync(dnsAuthorization, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DnsAuthorization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDnsAuthorization(DeleteDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single DnsAuthorization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDnsAuthorizationAsync(DeleteDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single DnsAuthorization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDnsAuthorizationAsync(DeleteDnsAuthorizationRequest request, st::CancellationToken cancellationToken) =>
            DeleteDnsAuthorizationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDnsAuthorization</c>.</summary>
        public virtual lro::OperationsClient DeleteDnsAuthorizationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDnsAuthorization</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDnsAuthorization(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDnsAuthorizationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDnsAuthorization</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDnsAuthorizationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDnsAuthorizationOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single DnsAuthorization.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the dns authorization to delete. Must be in the format
        /// `projects/*/locations/*/dnsAuthorizations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDnsAuthorization(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDnsAuthorization(new DeleteDnsAuthorizationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DnsAuthorization.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the dns authorization to delete. Must be in the format
        /// `projects/*/locations/*/dnsAuthorizations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDnsAuthorizationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDnsAuthorizationAsync(new DeleteDnsAuthorizationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DnsAuthorization.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the dns authorization to delete. Must be in the format
        /// `projects/*/locations/*/dnsAuthorizations/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDnsAuthorizationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDnsAuthorizationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DnsAuthorization.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the dns authorization to delete. Must be in the format
        /// `projects/*/locations/*/dnsAuthorizations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDnsAuthorization(DnsAuthorizationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDnsAuthorization(new DeleteDnsAuthorizationRequest
            {
                DnsAuthorizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DnsAuthorization.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the dns authorization to delete. Must be in the format
        /// `projects/*/locations/*/dnsAuthorizations/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDnsAuthorizationAsync(DnsAuthorizationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDnsAuthorizationAsync(new DeleteDnsAuthorizationRequest
            {
                DnsAuthorizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DnsAuthorization.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the dns authorization to delete. Must be in the format
        /// `projects/*/locations/*/dnsAuthorizations/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDnsAuthorizationAsync(DnsAuthorizationName name, st::CancellationToken cancellationToken) =>
            DeleteDnsAuthorizationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CertificateManager client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// API Overview
    /// 
    /// Certificates Manager API allows customers to see and manage all their TLS
    /// certificates.
    /// 
    /// Certificates Manager API service provides methods to manage certificates,
    /// group them into collections, and create serving configuration that can be
    /// easily applied to other Cloud resources e.g. Target Proxies.
    /// 
    /// Data Model
    /// 
    /// The Certificates Manager service exposes the following resources:
    /// 
    /// * `Certificate` which describes a single TLS certificate.
    /// * `CertificateMap` which describes a collection of certificates that can be
    /// attached to a target resource.
    /// * `CertificateMapEntry` which describes a single configuration entry that
    /// consists of a SNI and a group of certificates. It's a subresource of
    /// CertificateMap.
    /// 
    /// Certificate, CertificateMap and CertificateMapEntry IDs
    /// have to match "^[a-z0-9-]{1,63}$" regexp, which means that
    /// - only lower case letters, digits, and hyphen are allowed
    /// - length of the resource ID has to be in [1,63] range.
    /// 
    /// Provides methods to manage Cloud Certificate Manager entities.
    /// </remarks>
    public sealed partial class CertificateManagerClientImpl : CertificateManagerClient
    {
        private readonly gaxgrpc::ApiCall<ListCertificatesRequest, ListCertificatesResponse> _callListCertificates;

        private readonly gaxgrpc::ApiCall<GetCertificateRequest, Certificate> _callGetCertificate;

        private readonly gaxgrpc::ApiCall<CreateCertificateRequest, lro::Operation> _callCreateCertificate;

        private readonly gaxgrpc::ApiCall<UpdateCertificateRequest, lro::Operation> _callUpdateCertificate;

        private readonly gaxgrpc::ApiCall<DeleteCertificateRequest, lro::Operation> _callDeleteCertificate;

        private readonly gaxgrpc::ApiCall<ListCertificateMapsRequest, ListCertificateMapsResponse> _callListCertificateMaps;

        private readonly gaxgrpc::ApiCall<GetCertificateMapRequest, CertificateMap> _callGetCertificateMap;

        private readonly gaxgrpc::ApiCall<CreateCertificateMapRequest, lro::Operation> _callCreateCertificateMap;

        private readonly gaxgrpc::ApiCall<UpdateCertificateMapRequest, lro::Operation> _callUpdateCertificateMap;

        private readonly gaxgrpc::ApiCall<DeleteCertificateMapRequest, lro::Operation> _callDeleteCertificateMap;

        private readonly gaxgrpc::ApiCall<ListCertificateMapEntriesRequest, ListCertificateMapEntriesResponse> _callListCertificateMapEntries;

        private readonly gaxgrpc::ApiCall<GetCertificateMapEntryRequest, CertificateMapEntry> _callGetCertificateMapEntry;

        private readonly gaxgrpc::ApiCall<CreateCertificateMapEntryRequest, lro::Operation> _callCreateCertificateMapEntry;

        private readonly gaxgrpc::ApiCall<UpdateCertificateMapEntryRequest, lro::Operation> _callUpdateCertificateMapEntry;

        private readonly gaxgrpc::ApiCall<DeleteCertificateMapEntryRequest, lro::Operation> _callDeleteCertificateMapEntry;

        private readonly gaxgrpc::ApiCall<ListDnsAuthorizationsRequest, ListDnsAuthorizationsResponse> _callListDnsAuthorizations;

        private readonly gaxgrpc::ApiCall<GetDnsAuthorizationRequest, DnsAuthorization> _callGetDnsAuthorization;

        private readonly gaxgrpc::ApiCall<CreateDnsAuthorizationRequest, lro::Operation> _callCreateDnsAuthorization;

        private readonly gaxgrpc::ApiCall<UpdateDnsAuthorizationRequest, lro::Operation> _callUpdateDnsAuthorization;

        private readonly gaxgrpc::ApiCall<DeleteDnsAuthorizationRequest, lro::Operation> _callDeleteDnsAuthorization;

        /// <summary>
        /// Constructs a client wrapper for the CertificateManager service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CertificateManagerSettings"/> used within this client.</param>
        public CertificateManagerClientImpl(CertificateManager.CertificateManagerClient grpcClient, CertificateManagerSettings settings)
        {
            GrpcClient = grpcClient;
            CertificateManagerSettings effectiveSettings = settings ?? CertificateManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateCertificateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCertificateOperationsSettings);
            UpdateCertificateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateCertificateOperationsSettings);
            DeleteCertificateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCertificateOperationsSettings);
            CreateCertificateMapOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCertificateMapOperationsSettings);
            UpdateCertificateMapOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateCertificateMapOperationsSettings);
            DeleteCertificateMapOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCertificateMapOperationsSettings);
            CreateCertificateMapEntryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCertificateMapEntryOperationsSettings);
            UpdateCertificateMapEntryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateCertificateMapEntryOperationsSettings);
            DeleteCertificateMapEntryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCertificateMapEntryOperationsSettings);
            CreateDnsAuthorizationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDnsAuthorizationOperationsSettings);
            UpdateDnsAuthorizationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDnsAuthorizationOperationsSettings);
            DeleteDnsAuthorizationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDnsAuthorizationOperationsSettings);
            _callListCertificates = clientHelper.BuildApiCall<ListCertificatesRequest, ListCertificatesResponse>(grpcClient.ListCertificatesAsync, grpcClient.ListCertificates, effectiveSettings.ListCertificatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCertificates);
            Modify_ListCertificatesApiCall(ref _callListCertificates);
            _callGetCertificate = clientHelper.BuildApiCall<GetCertificateRequest, Certificate>(grpcClient.GetCertificateAsync, grpcClient.GetCertificate, effectiveSettings.GetCertificateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCertificate);
            Modify_GetCertificateApiCall(ref _callGetCertificate);
            _callCreateCertificate = clientHelper.BuildApiCall<CreateCertificateRequest, lro::Operation>(grpcClient.CreateCertificateAsync, grpcClient.CreateCertificate, effectiveSettings.CreateCertificateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCertificate);
            Modify_CreateCertificateApiCall(ref _callCreateCertificate);
            _callUpdateCertificate = clientHelper.BuildApiCall<UpdateCertificateRequest, lro::Operation>(grpcClient.UpdateCertificateAsync, grpcClient.UpdateCertificate, effectiveSettings.UpdateCertificateSettings).WithGoogleRequestParam("certificate.name", request => request.Certificate?.Name);
            Modify_ApiCall(ref _callUpdateCertificate);
            Modify_UpdateCertificateApiCall(ref _callUpdateCertificate);
            _callDeleteCertificate = clientHelper.BuildApiCall<DeleteCertificateRequest, lro::Operation>(grpcClient.DeleteCertificateAsync, grpcClient.DeleteCertificate, effectiveSettings.DeleteCertificateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCertificate);
            Modify_DeleteCertificateApiCall(ref _callDeleteCertificate);
            _callListCertificateMaps = clientHelper.BuildApiCall<ListCertificateMapsRequest, ListCertificateMapsResponse>(grpcClient.ListCertificateMapsAsync, grpcClient.ListCertificateMaps, effectiveSettings.ListCertificateMapsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCertificateMaps);
            Modify_ListCertificateMapsApiCall(ref _callListCertificateMaps);
            _callGetCertificateMap = clientHelper.BuildApiCall<GetCertificateMapRequest, CertificateMap>(grpcClient.GetCertificateMapAsync, grpcClient.GetCertificateMap, effectiveSettings.GetCertificateMapSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCertificateMap);
            Modify_GetCertificateMapApiCall(ref _callGetCertificateMap);
            _callCreateCertificateMap = clientHelper.BuildApiCall<CreateCertificateMapRequest, lro::Operation>(grpcClient.CreateCertificateMapAsync, grpcClient.CreateCertificateMap, effectiveSettings.CreateCertificateMapSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCertificateMap);
            Modify_CreateCertificateMapApiCall(ref _callCreateCertificateMap);
            _callUpdateCertificateMap = clientHelper.BuildApiCall<UpdateCertificateMapRequest, lro::Operation>(grpcClient.UpdateCertificateMapAsync, grpcClient.UpdateCertificateMap, effectiveSettings.UpdateCertificateMapSettings).WithGoogleRequestParam("certificate_map.name", request => request.CertificateMap?.Name);
            Modify_ApiCall(ref _callUpdateCertificateMap);
            Modify_UpdateCertificateMapApiCall(ref _callUpdateCertificateMap);
            _callDeleteCertificateMap = clientHelper.BuildApiCall<DeleteCertificateMapRequest, lro::Operation>(grpcClient.DeleteCertificateMapAsync, grpcClient.DeleteCertificateMap, effectiveSettings.DeleteCertificateMapSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCertificateMap);
            Modify_DeleteCertificateMapApiCall(ref _callDeleteCertificateMap);
            _callListCertificateMapEntries = clientHelper.BuildApiCall<ListCertificateMapEntriesRequest, ListCertificateMapEntriesResponse>(grpcClient.ListCertificateMapEntriesAsync, grpcClient.ListCertificateMapEntries, effectiveSettings.ListCertificateMapEntriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCertificateMapEntries);
            Modify_ListCertificateMapEntriesApiCall(ref _callListCertificateMapEntries);
            _callGetCertificateMapEntry = clientHelper.BuildApiCall<GetCertificateMapEntryRequest, CertificateMapEntry>(grpcClient.GetCertificateMapEntryAsync, grpcClient.GetCertificateMapEntry, effectiveSettings.GetCertificateMapEntrySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCertificateMapEntry);
            Modify_GetCertificateMapEntryApiCall(ref _callGetCertificateMapEntry);
            _callCreateCertificateMapEntry = clientHelper.BuildApiCall<CreateCertificateMapEntryRequest, lro::Operation>(grpcClient.CreateCertificateMapEntryAsync, grpcClient.CreateCertificateMapEntry, effectiveSettings.CreateCertificateMapEntrySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCertificateMapEntry);
            Modify_CreateCertificateMapEntryApiCall(ref _callCreateCertificateMapEntry);
            _callUpdateCertificateMapEntry = clientHelper.BuildApiCall<UpdateCertificateMapEntryRequest, lro::Operation>(grpcClient.UpdateCertificateMapEntryAsync, grpcClient.UpdateCertificateMapEntry, effectiveSettings.UpdateCertificateMapEntrySettings).WithGoogleRequestParam("certificate_map_entry.name", request => request.CertificateMapEntry?.Name);
            Modify_ApiCall(ref _callUpdateCertificateMapEntry);
            Modify_UpdateCertificateMapEntryApiCall(ref _callUpdateCertificateMapEntry);
            _callDeleteCertificateMapEntry = clientHelper.BuildApiCall<DeleteCertificateMapEntryRequest, lro::Operation>(grpcClient.DeleteCertificateMapEntryAsync, grpcClient.DeleteCertificateMapEntry, effectiveSettings.DeleteCertificateMapEntrySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCertificateMapEntry);
            Modify_DeleteCertificateMapEntryApiCall(ref _callDeleteCertificateMapEntry);
            _callListDnsAuthorizations = clientHelper.BuildApiCall<ListDnsAuthorizationsRequest, ListDnsAuthorizationsResponse>(grpcClient.ListDnsAuthorizationsAsync, grpcClient.ListDnsAuthorizations, effectiveSettings.ListDnsAuthorizationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDnsAuthorizations);
            Modify_ListDnsAuthorizationsApiCall(ref _callListDnsAuthorizations);
            _callGetDnsAuthorization = clientHelper.BuildApiCall<GetDnsAuthorizationRequest, DnsAuthorization>(grpcClient.GetDnsAuthorizationAsync, grpcClient.GetDnsAuthorization, effectiveSettings.GetDnsAuthorizationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDnsAuthorization);
            Modify_GetDnsAuthorizationApiCall(ref _callGetDnsAuthorization);
            _callCreateDnsAuthorization = clientHelper.BuildApiCall<CreateDnsAuthorizationRequest, lro::Operation>(grpcClient.CreateDnsAuthorizationAsync, grpcClient.CreateDnsAuthorization, effectiveSettings.CreateDnsAuthorizationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDnsAuthorization);
            Modify_CreateDnsAuthorizationApiCall(ref _callCreateDnsAuthorization);
            _callUpdateDnsAuthorization = clientHelper.BuildApiCall<UpdateDnsAuthorizationRequest, lro::Operation>(grpcClient.UpdateDnsAuthorizationAsync, grpcClient.UpdateDnsAuthorization, effectiveSettings.UpdateDnsAuthorizationSettings).WithGoogleRequestParam("dns_authorization.name", request => request.DnsAuthorization?.Name);
            Modify_ApiCall(ref _callUpdateDnsAuthorization);
            Modify_UpdateDnsAuthorizationApiCall(ref _callUpdateDnsAuthorization);
            _callDeleteDnsAuthorization = clientHelper.BuildApiCall<DeleteDnsAuthorizationRequest, lro::Operation>(grpcClient.DeleteDnsAuthorizationAsync, grpcClient.DeleteDnsAuthorization, effectiveSettings.DeleteDnsAuthorizationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDnsAuthorization);
            Modify_DeleteDnsAuthorizationApiCall(ref _callDeleteDnsAuthorization);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListCertificatesApiCall(ref gaxgrpc::ApiCall<ListCertificatesRequest, ListCertificatesResponse> call);

        partial void Modify_GetCertificateApiCall(ref gaxgrpc::ApiCall<GetCertificateRequest, Certificate> call);

        partial void Modify_CreateCertificateApiCall(ref gaxgrpc::ApiCall<CreateCertificateRequest, lro::Operation> call);

        partial void Modify_UpdateCertificateApiCall(ref gaxgrpc::ApiCall<UpdateCertificateRequest, lro::Operation> call);

        partial void Modify_DeleteCertificateApiCall(ref gaxgrpc::ApiCall<DeleteCertificateRequest, lro::Operation> call);

        partial void Modify_ListCertificateMapsApiCall(ref gaxgrpc::ApiCall<ListCertificateMapsRequest, ListCertificateMapsResponse> call);

        partial void Modify_GetCertificateMapApiCall(ref gaxgrpc::ApiCall<GetCertificateMapRequest, CertificateMap> call);

        partial void Modify_CreateCertificateMapApiCall(ref gaxgrpc::ApiCall<CreateCertificateMapRequest, lro::Operation> call);

        partial void Modify_UpdateCertificateMapApiCall(ref gaxgrpc::ApiCall<UpdateCertificateMapRequest, lro::Operation> call);

        partial void Modify_DeleteCertificateMapApiCall(ref gaxgrpc::ApiCall<DeleteCertificateMapRequest, lro::Operation> call);

        partial void Modify_ListCertificateMapEntriesApiCall(ref gaxgrpc::ApiCall<ListCertificateMapEntriesRequest, ListCertificateMapEntriesResponse> call);

        partial void Modify_GetCertificateMapEntryApiCall(ref gaxgrpc::ApiCall<GetCertificateMapEntryRequest, CertificateMapEntry> call);

        partial void Modify_CreateCertificateMapEntryApiCall(ref gaxgrpc::ApiCall<CreateCertificateMapEntryRequest, lro::Operation> call);

        partial void Modify_UpdateCertificateMapEntryApiCall(ref gaxgrpc::ApiCall<UpdateCertificateMapEntryRequest, lro::Operation> call);

        partial void Modify_DeleteCertificateMapEntryApiCall(ref gaxgrpc::ApiCall<DeleteCertificateMapEntryRequest, lro::Operation> call);

        partial void Modify_ListDnsAuthorizationsApiCall(ref gaxgrpc::ApiCall<ListDnsAuthorizationsRequest, ListDnsAuthorizationsResponse> call);

        partial void Modify_GetDnsAuthorizationApiCall(ref gaxgrpc::ApiCall<GetDnsAuthorizationRequest, DnsAuthorization> call);

        partial void Modify_CreateDnsAuthorizationApiCall(ref gaxgrpc::ApiCall<CreateDnsAuthorizationRequest, lro::Operation> call);

        partial void Modify_UpdateDnsAuthorizationApiCall(ref gaxgrpc::ApiCall<UpdateDnsAuthorizationRequest, lro::Operation> call);

        partial void Modify_DeleteDnsAuthorizationApiCall(ref gaxgrpc::ApiCall<DeleteDnsAuthorizationRequest, lro::Operation> call);

        partial void OnConstruction(CertificateManager.CertificateManagerClient grpcClient, CertificateManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CertificateManager client</summary>
        public override CertificateManager.CertificateManagerClient GrpcClient { get; }

        partial void Modify_ListCertificatesRequest(ref ListCertificatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCertificateRequest(ref GetCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCertificateRequest(ref CreateCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCertificateRequest(ref UpdateCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCertificateRequest(ref DeleteCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCertificateMapsRequest(ref ListCertificateMapsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCertificateMapRequest(ref GetCertificateMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCertificateMapRequest(ref CreateCertificateMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCertificateMapRequest(ref UpdateCertificateMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCertificateMapRequest(ref DeleteCertificateMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCertificateMapEntriesRequest(ref ListCertificateMapEntriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCertificateMapEntryRequest(ref GetCertificateMapEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCertificateMapEntryRequest(ref CreateCertificateMapEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCertificateMapEntryRequest(ref UpdateCertificateMapEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCertificateMapEntryRequest(ref DeleteCertificateMapEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDnsAuthorizationsRequest(ref ListDnsAuthorizationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDnsAuthorizationRequest(ref GetDnsAuthorizationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDnsAuthorizationRequest(ref CreateDnsAuthorizationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDnsAuthorizationRequest(ref UpdateDnsAuthorizationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDnsAuthorizationRequest(ref DeleteDnsAuthorizationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Certificates in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Certificate"/> resources.</returns>
        public override gax::PagedEnumerable<ListCertificatesResponse, Certificate> ListCertificates(ListCertificatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCertificatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCertificatesRequest, ListCertificatesResponse, Certificate>(_callListCertificates, request, callSettings);
        }

        /// <summary>
        /// Lists Certificates in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Certificate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCertificatesResponse, Certificate> ListCertificatesAsync(ListCertificatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCertificatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCertificatesRequest, ListCertificatesResponse, Certificate>(_callListCertificates, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Certificate GetCertificate(GetCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateRequest(ref request, ref callSettings);
            return _callGetCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Certificate> GetCertificateAsync(GetCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateRequest(ref request, ref callSettings);
            return _callGetCertificate.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateCertificate</c>.</summary>
        public override lro::OperationsClient CreateCertificateOperationsClient { get; }

        /// <summary>
        /// Creates a new Certificate in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Certificate, OperationMetadata> CreateCertificate(CreateCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCertificateRequest(ref request, ref callSettings);
            return new lro::Operation<Certificate, OperationMetadata>(_callCreateCertificate.Sync(request, callSettings), CreateCertificateOperationsClient);
        }

        /// <summary>
        /// Creates a new Certificate in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Certificate, OperationMetadata>> CreateCertificateAsync(CreateCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCertificateRequest(ref request, ref callSettings);
            return new lro::Operation<Certificate, OperationMetadata>(await _callCreateCertificate.Async(request, callSettings).ConfigureAwait(false), CreateCertificateOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateCertificate</c>.</summary>
        public override lro::OperationsClient UpdateCertificateOperationsClient { get; }

        /// <summary>
        /// Updates a Certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Certificate, OperationMetadata> UpdateCertificate(UpdateCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateRequest(ref request, ref callSettings);
            return new lro::Operation<Certificate, OperationMetadata>(_callUpdateCertificate.Sync(request, callSettings), UpdateCertificateOperationsClient);
        }

        /// <summary>
        /// Updates a Certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Certificate, OperationMetadata>> UpdateCertificateAsync(UpdateCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateRequest(ref request, ref callSettings);
            return new lro::Operation<Certificate, OperationMetadata>(await _callUpdateCertificate.Async(request, callSettings).ConfigureAwait(false), UpdateCertificateOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCertificate</c>.</summary>
        public override lro::OperationsClient DeleteCertificateOperationsClient { get; }

        /// <summary>
        /// Deletes a single Certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificate(DeleteCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCertificateRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteCertificate.Sync(request, callSettings), DeleteCertificateOperationsClient);
        }

        /// <summary>
        /// Deletes a single Certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateAsync(DeleteCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCertificateRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteCertificate.Async(request, callSettings).ConfigureAwait(false), DeleteCertificateOperationsClient);
        }

        /// <summary>
        /// Lists CertificateMaps in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateMap"/> resources.</returns>
        public override gax::PagedEnumerable<ListCertificateMapsResponse, CertificateMap> ListCertificateMaps(ListCertificateMapsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCertificateMapsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCertificateMapsRequest, ListCertificateMapsResponse, CertificateMap>(_callListCertificateMaps, request, callSettings);
        }

        /// <summary>
        /// Lists CertificateMaps in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateMap"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCertificateMapsResponse, CertificateMap> ListCertificateMapsAsync(ListCertificateMapsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCertificateMapsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCertificateMapsRequest, ListCertificateMapsResponse, CertificateMap>(_callListCertificateMaps, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CertificateMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CertificateMap GetCertificateMap(GetCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateMapRequest(ref request, ref callSettings);
            return _callGetCertificateMap.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CertificateMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CertificateMap> GetCertificateMapAsync(GetCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateMapRequest(ref request, ref callSettings);
            return _callGetCertificateMap.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateCertificateMap</c>.</summary>
        public override lro::OperationsClient CreateCertificateMapOperationsClient { get; }

        /// <summary>
        /// Creates a new CertificateMap in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateMap, OperationMetadata> CreateCertificateMap(CreateCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCertificateMapRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateMap, OperationMetadata>(_callCreateCertificateMap.Sync(request, callSettings), CreateCertificateMapOperationsClient);
        }

        /// <summary>
        /// Creates a new CertificateMap in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateMap, OperationMetadata>> CreateCertificateMapAsync(CreateCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCertificateMapRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateMap, OperationMetadata>(await _callCreateCertificateMap.Async(request, callSettings).ConfigureAwait(false), CreateCertificateMapOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateCertificateMap</c>.</summary>
        public override lro::OperationsClient UpdateCertificateMapOperationsClient { get; }

        /// <summary>
        /// Updates a CertificateMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateMap, OperationMetadata> UpdateCertificateMap(UpdateCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateMapRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateMap, OperationMetadata>(_callUpdateCertificateMap.Sync(request, callSettings), UpdateCertificateMapOperationsClient);
        }

        /// <summary>
        /// Updates a CertificateMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateMap, OperationMetadata>> UpdateCertificateMapAsync(UpdateCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateMapRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateMap, OperationMetadata>(await _callUpdateCertificateMap.Async(request, callSettings).ConfigureAwait(false), UpdateCertificateMapOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCertificateMap</c>.</summary>
        public override lro::OperationsClient DeleteCertificateMapOperationsClient { get; }

        /// <summary>
        /// Deletes a single CertificateMap. A Certificate Map can't be deleted
        /// if it contains Certificate Map Entries. Remove all the entries from
        /// the map before calling this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificateMap(DeleteCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCertificateMapRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteCertificateMap.Sync(request, callSettings), DeleteCertificateMapOperationsClient);
        }

        /// <summary>
        /// Deletes a single CertificateMap. A Certificate Map can't be deleted
        /// if it contains Certificate Map Entries. Remove all the entries from
        /// the map before calling this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateMapAsync(DeleteCertificateMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCertificateMapRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteCertificateMap.Async(request, callSettings).ConfigureAwait(false), DeleteCertificateMapOperationsClient);
        }

        /// <summary>
        /// Lists CertificateMapEntries in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateMapEntry"/> resources.</returns>
        public override gax::PagedEnumerable<ListCertificateMapEntriesResponse, CertificateMapEntry> ListCertificateMapEntries(ListCertificateMapEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCertificateMapEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCertificateMapEntriesRequest, ListCertificateMapEntriesResponse, CertificateMapEntry>(_callListCertificateMapEntries, request, callSettings);
        }

        /// <summary>
        /// Lists CertificateMapEntries in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateMapEntry"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCertificateMapEntriesResponse, CertificateMapEntry> ListCertificateMapEntriesAsync(ListCertificateMapEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCertificateMapEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCertificateMapEntriesRequest, ListCertificateMapEntriesResponse, CertificateMapEntry>(_callListCertificateMapEntries, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CertificateMapEntry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CertificateMapEntry GetCertificateMapEntry(GetCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateMapEntryRequest(ref request, ref callSettings);
            return _callGetCertificateMapEntry.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CertificateMapEntry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CertificateMapEntry> GetCertificateMapEntryAsync(GetCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateMapEntryRequest(ref request, ref callSettings);
            return _callGetCertificateMapEntry.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateCertificateMapEntry</c>.</summary>
        public override lro::OperationsClient CreateCertificateMapEntryOperationsClient { get; }

        /// <summary>
        /// Creates a new CertificateMapEntry in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateMapEntry, OperationMetadata> CreateCertificateMapEntry(CreateCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCertificateMapEntryRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateMapEntry, OperationMetadata>(_callCreateCertificateMapEntry.Sync(request, callSettings), CreateCertificateMapEntryOperationsClient);
        }

        /// <summary>
        /// Creates a new CertificateMapEntry in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateMapEntry, OperationMetadata>> CreateCertificateMapEntryAsync(CreateCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCertificateMapEntryRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateMapEntry, OperationMetadata>(await _callCreateCertificateMapEntry.Async(request, callSettings).ConfigureAwait(false), CreateCertificateMapEntryOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateCertificateMapEntry</c>.</summary>
        public override lro::OperationsClient UpdateCertificateMapEntryOperationsClient { get; }

        /// <summary>
        /// Updates a CertificateMapEntry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateMapEntry, OperationMetadata> UpdateCertificateMapEntry(UpdateCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateMapEntryRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateMapEntry, OperationMetadata>(_callUpdateCertificateMapEntry.Sync(request, callSettings), UpdateCertificateMapEntryOperationsClient);
        }

        /// <summary>
        /// Updates a CertificateMapEntry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateMapEntry, OperationMetadata>> UpdateCertificateMapEntryAsync(UpdateCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateMapEntryRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateMapEntry, OperationMetadata>(await _callUpdateCertificateMapEntry.Async(request, callSettings).ConfigureAwait(false), UpdateCertificateMapEntryOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCertificateMapEntry</c>.</summary>
        public override lro::OperationsClient DeleteCertificateMapEntryOperationsClient { get; }

        /// <summary>
        /// Deletes a single CertificateMapEntry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificateMapEntry(DeleteCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCertificateMapEntryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteCertificateMapEntry.Sync(request, callSettings), DeleteCertificateMapEntryOperationsClient);
        }

        /// <summary>
        /// Deletes a single CertificateMapEntry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateMapEntryAsync(DeleteCertificateMapEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCertificateMapEntryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteCertificateMapEntry.Async(request, callSettings).ConfigureAwait(false), DeleteCertificateMapEntryOperationsClient);
        }

        /// <summary>
        /// Lists DnsAuthorizations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DnsAuthorization"/> resources.</returns>
        public override gax::PagedEnumerable<ListDnsAuthorizationsResponse, DnsAuthorization> ListDnsAuthorizations(ListDnsAuthorizationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDnsAuthorizationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDnsAuthorizationsRequest, ListDnsAuthorizationsResponse, DnsAuthorization>(_callListDnsAuthorizations, request, callSettings);
        }

        /// <summary>
        /// Lists DnsAuthorizations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DnsAuthorization"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDnsAuthorizationsResponse, DnsAuthorization> ListDnsAuthorizationsAsync(ListDnsAuthorizationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDnsAuthorizationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDnsAuthorizationsRequest, ListDnsAuthorizationsResponse, DnsAuthorization>(_callListDnsAuthorizations, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single DnsAuthorization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DnsAuthorization GetDnsAuthorization(GetDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDnsAuthorizationRequest(ref request, ref callSettings);
            return _callGetDnsAuthorization.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single DnsAuthorization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DnsAuthorization> GetDnsAuthorizationAsync(GetDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDnsAuthorizationRequest(ref request, ref callSettings);
            return _callGetDnsAuthorization.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDnsAuthorization</c>.</summary>
        public override lro::OperationsClient CreateDnsAuthorizationOperationsClient { get; }

        /// <summary>
        /// Creates a new DnsAuthorization in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DnsAuthorization, OperationMetadata> CreateDnsAuthorization(CreateDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDnsAuthorizationRequest(ref request, ref callSettings);
            return new lro::Operation<DnsAuthorization, OperationMetadata>(_callCreateDnsAuthorization.Sync(request, callSettings), CreateDnsAuthorizationOperationsClient);
        }

        /// <summary>
        /// Creates a new DnsAuthorization in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DnsAuthorization, OperationMetadata>> CreateDnsAuthorizationAsync(CreateDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDnsAuthorizationRequest(ref request, ref callSettings);
            return new lro::Operation<DnsAuthorization, OperationMetadata>(await _callCreateDnsAuthorization.Async(request, callSettings).ConfigureAwait(false), CreateDnsAuthorizationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDnsAuthorization</c>.</summary>
        public override lro::OperationsClient UpdateDnsAuthorizationOperationsClient { get; }

        /// <summary>
        /// Updates a DnsAuthorization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DnsAuthorization, OperationMetadata> UpdateDnsAuthorization(UpdateDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDnsAuthorizationRequest(ref request, ref callSettings);
            return new lro::Operation<DnsAuthorization, OperationMetadata>(_callUpdateDnsAuthorization.Sync(request, callSettings), UpdateDnsAuthorizationOperationsClient);
        }

        /// <summary>
        /// Updates a DnsAuthorization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DnsAuthorization, OperationMetadata>> UpdateDnsAuthorizationAsync(UpdateDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDnsAuthorizationRequest(ref request, ref callSettings);
            return new lro::Operation<DnsAuthorization, OperationMetadata>(await _callUpdateDnsAuthorization.Async(request, callSettings).ConfigureAwait(false), UpdateDnsAuthorizationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDnsAuthorization</c>.</summary>
        public override lro::OperationsClient DeleteDnsAuthorizationOperationsClient { get; }

        /// <summary>
        /// Deletes a single DnsAuthorization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDnsAuthorization(DeleteDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDnsAuthorizationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDnsAuthorization.Sync(request, callSettings), DeleteDnsAuthorizationOperationsClient);
        }

        /// <summary>
        /// Deletes a single DnsAuthorization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDnsAuthorizationAsync(DeleteDnsAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDnsAuthorizationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDnsAuthorization.Async(request, callSettings).ConfigureAwait(false), DeleteDnsAuthorizationOperationsClient);
        }
    }

    public partial class ListCertificatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCertificateMapsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCertificateMapEntriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDnsAuthorizationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCertificatesResponse : gaxgrpc::IPageResponse<Certificate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Certificate> GetEnumerator() => Certificates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCertificateMapsResponse : gaxgrpc::IPageResponse<CertificateMap>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CertificateMap> GetEnumerator() => CertificateMaps.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCertificateMapEntriesResponse : gaxgrpc::IPageResponse<CertificateMapEntry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CertificateMapEntry> GetEnumerator() => CertificateMapEntries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDnsAuthorizationsResponse : gaxgrpc::IPageResponse<DnsAuthorization>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DnsAuthorization> GetEnumerator() => DnsAuthorizations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CertificateManager
    {
        public partial class CertificateManagerClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
