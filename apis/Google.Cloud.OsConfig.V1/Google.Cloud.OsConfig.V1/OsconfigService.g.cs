// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/osconfig/v1/osconfig_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.OsConfig.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/osconfig/v1/osconfig_service.proto</summary>
  public static partial class OsconfigServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/osconfig/v1/osconfig_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OsconfigServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvY2xvdWQvb3Njb25maWcvdjEvb3Njb25maWdfc2VydmljZS5w",
            "cm90bxIYZ29vZ2xlLmNsb3VkLm9zY29uZmlnLnYxGhdnb29nbGUvYXBpL2Ns",
            "aWVudC5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90bxowZ29vZ2xl",
            "L2Nsb3VkL29zY29uZmlnL3YxL3BhdGNoX2RlcGxveW1lbnRzLnByb3RvGiln",
            "b29nbGUvY2xvdWQvb3Njb25maWcvdjEvcGF0Y2hfam9icy5wcm90bxobZ29v",
            "Z2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRp",
            "b25zLnByb3RvMqwSCg9Pc0NvbmZpZ1NlcnZpY2USnQEKD0V4ZWN1dGVQYXRj",
            "aEpvYhIwLmdvb2dsZS5jbG91ZC5vc2NvbmZpZy52MS5FeGVjdXRlUGF0Y2hK",
            "b2JSZXF1ZXN0GiIuZ29vZ2xlLmNsb3VkLm9zY29uZmlnLnYxLlBhdGNoSm9i",
            "IjSC0+STAi4iKS92MS97cGFyZW50PXByb2plY3RzLyp9L3BhdGNoSm9iczpl",
            "eGVjdXRlOgEqEpEBCgtHZXRQYXRjaEpvYhIsLmdvb2dsZS5jbG91ZC5vc2Nv",
            "bmZpZy52MS5HZXRQYXRjaEpvYlJlcXVlc3QaIi5nb29nbGUuY2xvdWQub3Nj",
            "b25maWcudjEuUGF0Y2hKb2IiMILT5JMCIxIhL3YxL3tuYW1lPXByb2plY3Rz",
            "LyovcGF0Y2hKb2JzLyp92kEEbmFtZRKaAQoOQ2FuY2VsUGF0Y2hKb2ISLy5n",
            "b29nbGUuY2xvdWQub3Njb25maWcudjEuQ2FuY2VsUGF0Y2hKb2JSZXF1ZXN0",
            "GiIuZ29vZ2xlLmNsb3VkLm9zY29uZmlnLnYxLlBhdGNoSm9iIjOC0+STAi0i",
            "KC92MS97bmFtZT1wcm9qZWN0cy8qL3BhdGNoSm9icy8qfTpjYW5jZWw6ASoS",
            "pAEKDUxpc3RQYXRjaEpvYnMSLi5nb29nbGUuY2xvdWQub3Njb25maWcudjEu",
            "TGlzdFBhdGNoSm9ic1JlcXVlc3QaLy5nb29nbGUuY2xvdWQub3Njb25maWcu",
            "djEuTGlzdFBhdGNoSm9ic1Jlc3BvbnNlIjKC0+STAiMSIS92MS97cGFyZW50",
            "PXByb2plY3RzLyp9L3BhdGNoSm9ic9pBBnBhcmVudBLgAQobTGlzdFBhdGNo",
            "Sm9iSW5zdGFuY2VEZXRhaWxzEjwuZ29vZ2xlLmNsb3VkLm9zY29uZmlnLnYx",
            "Lkxpc3RQYXRjaEpvYkluc3RhbmNlRGV0YWlsc1JlcXVlc3QaPS5nb29nbGUu",
            "Y2xvdWQub3Njb25maWcudjEuTGlzdFBhdGNoSm9iSW5zdGFuY2VEZXRhaWxz",
            "UmVzcG9uc2UiRILT5JMCNRIzL3YxL3twYXJlbnQ9cHJvamVjdHMvKi9wYXRj",
            "aEpvYnMvKn0vaW5zdGFuY2VEZXRhaWxz2kEGcGFyZW50EuwBChVDcmVhdGVQ",
            "YXRjaERlcGxveW1lbnQSNi5nb29nbGUuY2xvdWQub3Njb25maWcudjEuQ3Jl",
            "YXRlUGF0Y2hEZXBsb3ltZW50UmVxdWVzdBopLmdvb2dsZS5jbG91ZC5vc2Nv",
            "bmZpZy52MS5QYXRjaERlcGxveW1lbnQicILT5JMCPCIoL3YxL3twYXJlbnQ9",
            "cHJvamVjdHMvKn0vcGF0Y2hEZXBsb3ltZW50czoQcGF0Y2hfZGVwbG95bWVu",
            "dNpBK3BhcmVudCxwYXRjaF9kZXBsb3ltZW50LHBhdGNoX2RlcGxveW1lbnRf",
            "aWQSrQEKEkdldFBhdGNoRGVwbG95bWVudBIzLmdvb2dsZS5jbG91ZC5vc2Nv",
            "bmZpZy52MS5HZXRQYXRjaERlcGxveW1lbnRSZXF1ZXN0GikuZ29vZ2xlLmNs",
            "b3VkLm9zY29uZmlnLnYxLlBhdGNoRGVwbG95bWVudCI3gtPkkwIqEigvdjEv",
            "e25hbWU9cHJvamVjdHMvKi9wYXRjaERlcGxveW1lbnRzLyp92kEEbmFtZRLA",
            "AQoUTGlzdFBhdGNoRGVwbG95bWVudHMSNS5nb29nbGUuY2xvdWQub3Njb25m",
            "aWcudjEuTGlzdFBhdGNoRGVwbG95bWVudHNSZXF1ZXN0GjYuZ29vZ2xlLmNs",
            "b3VkLm9zY29uZmlnLnYxLkxpc3RQYXRjaERlcGxveW1lbnRzUmVzcG9uc2Ui",
            "OYLT5JMCKhIoL3YxL3twYXJlbnQ9cHJvamVjdHMvKn0vcGF0Y2hEZXBsb3lt",
            "ZW50c9pBBnBhcmVudBKgAQoVRGVsZXRlUGF0Y2hEZXBsb3ltZW50EjYuZ29v",
            "Z2xlLmNsb3VkLm9zY29uZmlnLnYxLkRlbGV0ZVBhdGNoRGVwbG95bWVudFJl",
            "cXVlc3QaFi5nb29nbGUucHJvdG9idWYuRW1wdHkiN4LT5JMCKiooL3YxL3tu",
            "YW1lPXByb2plY3RzLyovcGF0Y2hEZXBsb3ltZW50cy8qfdpBBG5hbWUS7gEK",
            "FVVwZGF0ZVBhdGNoRGVwbG95bWVudBI2Lmdvb2dsZS5jbG91ZC5vc2NvbmZp",
            "Zy52MS5VcGRhdGVQYXRjaERlcGxveW1lbnRSZXF1ZXN0GikuZ29vZ2xlLmNs",
            "b3VkLm9zY29uZmlnLnYxLlBhdGNoRGVwbG95bWVudCJygtPkkwJNMjkvdjEv",
            "e3BhdGNoX2RlcGxveW1lbnQubmFtZT1wcm9qZWN0cy8qL3BhdGNoRGVwbG95",
            "bWVudHMvKn06EHBhdGNoX2RlcGxveW1lbnTaQRxwYXRjaF9kZXBsb3ltZW50",
            "LHVwZGF0ZV9tYXNrEroBChRQYXVzZVBhdGNoRGVwbG95bWVudBI1Lmdvb2ds",
            "ZS5jbG91ZC5vc2NvbmZpZy52MS5QYXVzZVBhdGNoRGVwbG95bWVudFJlcXVl",
            "c3QaKS5nb29nbGUuY2xvdWQub3Njb25maWcudjEuUGF0Y2hEZXBsb3ltZW50",
            "IkCC0+STAjMiLi92MS97bmFtZT1wcm9qZWN0cy8qL3BhdGNoRGVwbG95bWVu",
            "dHMvKn06cGF1c2U6ASraQQRuYW1lEr0BChVSZXN1bWVQYXRjaERlcGxveW1l",
            "bnQSNi5nb29nbGUuY2xvdWQub3Njb25maWcudjEuUmVzdW1lUGF0Y2hEZXBs",
            "b3ltZW50UmVxdWVzdBopLmdvb2dsZS5jbG91ZC5vc2NvbmZpZy52MS5QYXRj",
            "aERlcGxveW1lbnQiQYLT5JMCNCIvL3YxL3tuYW1lPXByb2plY3RzLyovcGF0",
            "Y2hEZXBsb3ltZW50cy8qfTpyZXN1bWU6ASraQQRuYW1lGkvKQRdvc2NvbmZp",
            "Zy5nb29nbGVhcGlzLmNvbdJBLmh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29t",
            "L2F1dGgvY2xvdWQtcGxhdGZvcm1C3AIKHGNvbS5nb29nbGUuY2xvdWQub3Nj",
            "b25maWcudjFCDU9zQ29uZmlnUHJvdG9aQGdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvb3Njb25maWcvdjE7b3Njb25maWeq",
            "AhhHb29nbGUuQ2xvdWQuT3NDb25maWcuVjHKAhhHb29nbGVcQ2xvdWRcT3ND",
            "b25maWdcVjHqAhtHb29nbGU6OkNsb3VkOjpPc0NvbmZpZzo6VjHqQZUBCh9j",
            "b21wdXRlLmdvb2dsZWFwaXMuY29tL0luc3RhbmNlEjRwcm9qZWN0cy97cHJv",
            "amVjdH0vem9uZXMve3pvbmV9L2luc3RhbmNlcy97aW5zdGFuY2V9Ejxwcm9q",
            "ZWN0cy97cHJvamVjdH0vbG9jYXRpb25zL3tsb2NhdGlvbn0vaW5zdGFuY2Vz",
            "L3tpbnN0YW5jZX1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.ClientReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.OsConfig.V1.PatchDeploymentsReflection.Descriptor, global::Google.Cloud.OsConfig.V1.PatchJobsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code
