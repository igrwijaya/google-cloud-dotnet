// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/devtools/artifactregistry/v1beta2/service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.ArtifactRegistry.V1Beta2 {

  /// <summary>Holder for reflection information generated from google/devtools/artifactregistry/v1beta2/service.proto</summary>
  public static partial class ServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/devtools/artifactregistry/v1beta2/service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvZGV2dG9vbHMvYXJ0aWZhY3RyZWdpc3RyeS92MWJldGEyL3Nl",
            "cnZpY2UucHJvdG8SKGdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5",
            "LnYxYmV0YTIaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aF2dvb2ds",
            "ZS9hcGkvY2xpZW50LnByb3RvGjtnb29nbGUvZGV2dG9vbHMvYXJ0aWZhY3Ry",
            "ZWdpc3RyeS92MWJldGEyL2FwdF9hcnRpZmFjdC5wcm90bxozZ29vZ2xlL2Rl",
            "dnRvb2xzL2FydGlmYWN0cmVnaXN0cnkvdjFiZXRhMi9maWxlLnByb3RvGjZn",
            "b29nbGUvZGV2dG9vbHMvYXJ0aWZhY3RyZWdpc3RyeS92MWJldGEyL3BhY2th",
            "Z2UucHJvdG8aOWdvb2dsZS9kZXZ0b29scy9hcnRpZmFjdHJlZ2lzdHJ5L3Yx",
            "YmV0YTIvcmVwb3NpdG9yeS5wcm90bxo3Z29vZ2xlL2RldnRvb2xzL2FydGlm",
            "YWN0cmVnaXN0cnkvdjFiZXRhMi9zZXR0aW5ncy5wcm90bxoyZ29vZ2xlL2Rl",
            "dnRvb2xzL2FydGlmYWN0cmVnaXN0cnkvdjFiZXRhMi90YWcucHJvdG8aNmdv",
            "b2dsZS9kZXZ0b29scy9hcnRpZmFjdHJlZ2lzdHJ5L3YxYmV0YTIvdmVyc2lv",
            "bi5wcm90bxo7Z29vZ2xlL2RldnRvb2xzL2FydGlmYWN0cmVnaXN0cnkvdjFi",
            "ZXRhMi95dW1fYXJ0aWZhY3QucHJvdG8aHmdvb2dsZS9pYW0vdjEvaWFtX3Bv",
            "bGljeS5wcm90bxoaZ29vZ2xlL2lhbS92MS9wb2xpY3kucHJvdG8aI2dvb2ds",
            "ZS9sb25ncnVubmluZy9vcGVyYXRpb25zLnByb3RvGhtnb29nbGUvcHJvdG9i",
            "dWYvZW1wdHkucHJvdG8iEwoRT3BlcmF0aW9uTWV0YWRhdGEy5i8KEEFydGlm",
            "YWN0UmVnaXN0cnkS3wIKEkltcG9ydEFwdEFydGlmYWN0cxJDLmdvb2dsZS5k",
            "ZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuSW1wb3J0QXB0QXJ0",
            "aWZhY3RzUmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24i",
            "5AGC0+STAlAiSy92MWJldGEyL3twYXJlbnQ9cHJvamVjdHMvKi9sb2NhdGlv",
            "bnMvKi9yZXBvc2l0b3JpZXMvKn0vYXB0QXJ0aWZhY3RzOmltcG9ydDoBKspB",
            "igEKQ2dvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIu",
            "SW1wb3J0QXB0QXJ0aWZhY3RzUmVzcG9uc2USQ2dvb2dsZS5kZXZ0b29scy5h",
            "cnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuSW1wb3J0QXB0QXJ0aWZhY3RzTWV0",
            "YWRhdGES3wIKEkltcG9ydFl1bUFydGlmYWN0cxJDLmdvb2dsZS5kZXZ0b29s",
            "cy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuSW1wb3J0WXVtQXJ0aWZhY3Rz",
            "UmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24i5AGC0+ST",
            "AlAiSy92MWJldGEyL3twYXJlbnQ9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9y",
            "ZXBvc2l0b3JpZXMvKn0veXVtQXJ0aWZhY3RzOmltcG9ydDoBKspBigEKQ2dv",
            "b2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuSW1wb3J0",
            "WXVtQXJ0aWZhY3RzUmVzcG9uc2USQ2dvb2dsZS5kZXZ0b29scy5hcnRpZmFj",
            "dHJlZ2lzdHJ5LnYxYmV0YTIuSW1wb3J0WXVtQXJ0aWZhY3RzTWV0YWRhdGES",
            "4QEKEExpc3RSZXBvc2l0b3JpZXMSQS5nb29nbGUuZGV2dG9vbHMuYXJ0aWZh",
            "Y3RyZWdpc3RyeS52MWJldGEyLkxpc3RSZXBvc2l0b3JpZXNSZXF1ZXN0GkIu",
            "Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMi5MaXN0",
            "UmVwb3NpdG9yaWVzUmVzcG9uc2UiRoLT5JMCNxI1L3YxYmV0YTIve3BhcmVu",
            "dD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfS9yZXBvc2l0b3JpZXPaQQZwYXJl",
            "bnQSywEKDUdldFJlcG9zaXRvcnkSPi5nb29nbGUuZGV2dG9vbHMuYXJ0aWZh",
            "Y3RyZWdpc3RyeS52MWJldGEyLkdldFJlcG9zaXRvcnlSZXF1ZXN0GjQuZ29v",
            "Z2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMi5SZXBvc2l0",
            "b3J5IkSC0+STAjcSNS92MWJldGEyL3tuYW1lPXByb2plY3RzLyovbG9jYXRp",
            "b25zLyovcmVwb3NpdG9yaWVzLyp92kEEbmFtZRLWAgoQQ3JlYXRlUmVwb3Np",
            "dG9yeRJBLmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0",
            "YTIuQ3JlYXRlUmVwb3NpdG9yeVJlcXVlc3QaHS5nb29nbGUubG9uZ3J1bm5p",
            "bmcuT3BlcmF0aW9uIt8BgtPkkwJDIjUvdjFiZXRhMi97cGFyZW50PXByb2pl",
            "Y3RzLyovbG9jYXRpb25zLyp9L3JlcG9zaXRvcmllczoKcmVwb3NpdG9yedpB",
            "H3BhcmVudCxyZXBvc2l0b3J5LHJlcG9zaXRvcnlfaWTKQXEKM2dvb2dsZS5k",
            "ZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuUmVwb3NpdG9yeRI6",
            "Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMi5PcGVy",
            "YXRpb25NZXRhZGF0YRL6AQoQVXBkYXRlUmVwb3NpdG9yeRJBLmdvb2dsZS5k",
            "ZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuVXBkYXRlUmVwb3Np",
            "dG9yeVJlcXVlc3QaNC5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3Ry",
            "eS52MWJldGEyLlJlcG9zaXRvcnkibYLT5JMCTjJAL3YxYmV0YTIve3JlcG9z",
            "aXRvcnkubmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmll",
            "cy8qfToKcmVwb3NpdG9yedpBFnJlcG9zaXRvcnksdXBkYXRlX21hc2sSkQIK",
            "EERlbGV0ZVJlcG9zaXRvcnkSQS5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3Ry",
            "ZWdpc3RyeS52MWJldGEyLkRlbGV0ZVJlcG9zaXRvcnlSZXF1ZXN0Gh0uZ29v",
            "Z2xlLmxvbmdydW5uaW5nLk9wZXJhdGlvbiKaAYLT5JMCNyo1L3YxYmV0YTIv",
            "e25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKn3a",
            "QQRuYW1lykFTChVnb29nbGUucHJvdG9idWYuRW1wdHkSOmdvb2dsZS5kZXZ0",
            "b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuT3BlcmF0aW9uTWV0YWRh",
            "dGES4AEKDExpc3RQYWNrYWdlcxI9Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFj",
            "dHJlZ2lzdHJ5LnYxYmV0YTIuTGlzdFBhY2thZ2VzUmVxdWVzdBo+Lmdvb2ds",
            "ZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuTGlzdFBhY2th",
            "Z2VzUmVzcG9uc2UiUYLT5JMCQhJAL3YxYmV0YTIve3BhcmVudD1wcm9qZWN0",
            "cy8qL2xvY2F0aW9ucy8qL3JlcG9zaXRvcmllcy8qfS9wYWNrYWdlc9pBBnBh",
            "cmVudBLNAQoKR2V0UGFja2FnZRI7Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFj",
            "dHJlZ2lzdHJ5LnYxYmV0YTIuR2V0UGFja2FnZVJlcXVlc3QaMS5nb29nbGUu",
            "ZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJldGEyLlBhY2thZ2UiT4LT",
            "5JMCQhJAL3YxYmV0YTIve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9y",
            "ZXBvc2l0b3JpZXMvKi9wYWNrYWdlcy8qfdpBBG5hbWUSlgIKDURlbGV0ZVBh",
            "Y2thZ2USPi5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJl",
            "dGEyLkRlbGV0ZVBhY2thZ2VSZXF1ZXN0Gh0uZ29vZ2xlLmxvbmdydW5uaW5n",
            "Lk9wZXJhdGlvbiKlAYLT5JMCQipAL3YxYmV0YTIve25hbWU9cHJvamVjdHMv",
            "Ki9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKi9wYWNrYWdlcy8qfdpBBG5h",
            "bWXKQVMKFWdvb2dsZS5wcm90b2J1Zi5FbXB0eRI6Z29vZ2xlLmRldnRvb2xz",
            "LmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMi5PcGVyYXRpb25NZXRhZGF0YRLr",
            "AQoMTGlzdFZlcnNpb25zEj0uZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVn",
            "aXN0cnkudjFiZXRhMi5MaXN0VmVyc2lvbnNSZXF1ZXN0Gj4uZ29vZ2xlLmRl",
            "dnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMi5MaXN0VmVyc2lvbnNS",
            "ZXNwb25zZSJcgtPkkwJNEksvdjFiZXRhMi97cGFyZW50PXByb2plY3RzLyov",
            "bG9jYXRpb25zLyovcmVwb3NpdG9yaWVzLyovcGFja2FnZXMvKn0vdmVyc2lv",
            "bnPaQQZwYXJlbnQS2AEKCkdldFZlcnNpb24SOy5nb29nbGUuZGV2dG9vbHMu",
            "YXJ0aWZhY3RyZWdpc3RyeS52MWJldGEyLkdldFZlcnNpb25SZXF1ZXN0GjEu",
            "Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMi5WZXJz",
            "aW9uIlqC0+STAk0SSy92MWJldGEyL3tuYW1lPXByb2plY3RzLyovbG9jYXRp",
            "b25zLyovcmVwb3NpdG9yaWVzLyovcGFja2FnZXMvKi92ZXJzaW9ucy8qfdpB",
            "BG5hbWUSoQIKDURlbGV0ZVZlcnNpb24SPi5nb29nbGUuZGV2dG9vbHMuYXJ0",
            "aWZhY3RyZWdpc3RyeS52MWJldGEyLkRlbGV0ZVZlcnNpb25SZXF1ZXN0Gh0u",
            "Z29vZ2xlLmxvbmdydW5uaW5nLk9wZXJhdGlvbiKwAYLT5JMCTSpLL3YxYmV0",
            "YTIve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMv",
            "Ki9wYWNrYWdlcy8qL3ZlcnNpb25zLyp92kEEbmFtZcpBUwoVZ29vZ2xlLnBy",
            "b3RvYnVmLkVtcHR5Ejpnb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3Ry",
            "eS52MWJldGEyLk9wZXJhdGlvbk1ldGFkYXRhEtQBCglMaXN0RmlsZXMSOi5n",
            "b29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJldGEyLkxpc3RG",
            "aWxlc1JlcXVlc3QaOy5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3Ry",
            "eS52MWJldGEyLkxpc3RGaWxlc1Jlc3BvbnNlIk6C0+STAj8SPS92MWJldGEy",
            "L3twYXJlbnQ9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMv",
            "Kn0vZmlsZXPaQQZwYXJlbnQSwgEKB0dldEZpbGUSOC5nb29nbGUuZGV2dG9v",
            "bHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJldGEyLkdldEZpbGVSZXF1ZXN0Gi4u",
            "Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMi5GaWxl",
            "Ik2C0+STAkASPi92MWJldGEyL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25z",
            "LyovcmVwb3NpdG9yaWVzLyovZmlsZXMvKip92kEEbmFtZRLbAQoITGlzdFRh",
            "Z3MSOS5nb29nbGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJldGEy",
            "Lkxpc3RUYWdzUmVxdWVzdBo6Lmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJl",
            "Z2lzdHJ5LnYxYmV0YTIuTGlzdFRhZ3NSZXNwb25zZSJYgtPkkwJJEkcvdjFi",
            "ZXRhMi97cGFyZW50PXByb2plY3RzLyovbG9jYXRpb25zLyovcmVwb3NpdG9y",
            "aWVzLyovcGFja2FnZXMvKn0vdGFnc9pBBnBhcmVudBLIAQoGR2V0VGFnEjcu",
            "Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMi5HZXRU",
            "YWdSZXF1ZXN0Gi0uZ29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnku",
            "djFiZXRhMi5UYWciVoLT5JMCSRJHL3YxYmV0YTIve25hbWU9cHJvamVjdHMv",
            "Ki9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKi9wYWNrYWdlcy8qL3RhZ3Mv",
            "Kn3aQQRuYW1lEuABCglDcmVhdGVUYWcSOi5nb29nbGUuZGV2dG9vbHMuYXJ0",
            "aWZhY3RyZWdpc3RyeS52MWJldGEyLkNyZWF0ZVRhZ1JlcXVlc3QaLS5nb29n",
            "bGUuZGV2dG9vbHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJldGEyLlRhZyJogtPk",
            "kwJOIkcvdjFiZXRhMi97cGFyZW50PXByb2plY3RzLyovbG9jYXRpb25zLyov",
            "cmVwb3NpdG9yaWVzLyovcGFja2FnZXMvKn0vdGFnczoDdGFn2kERcGFyZW50",
            "LHRhZyx0YWdfaWQS4gEKCVVwZGF0ZVRhZxI6Lmdvb2dsZS5kZXZ0b29scy5h",
            "cnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuVXBkYXRlVGFnUmVxdWVzdBotLmdv",
            "b2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuVGFnImqC",
            "0+STAlIySy92MWJldGEyL3t0YWcubmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9u",
            "cy8qL3JlcG9zaXRvcmllcy8qL3BhY2thZ2VzLyovdGFncy8qfToDdGFn2kEP",
            "dGFnLHVwZGF0ZV9tYXNrErcBCglEZWxldGVUYWcSOi5nb29nbGUuZGV2dG9v",
            "bHMuYXJ0aWZhY3RyZWdpc3RyeS52MWJldGEyLkRlbGV0ZVRhZ1JlcXVlc3Qa",
            "Fi5nb29nbGUucHJvdG9idWYuRW1wdHkiVoLT5JMCSSpHL3YxYmV0YTIve25h",
            "bWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKi9wYWNr",
            "YWdlcy8qL3RhZ3MvKn3aQQRuYW1lEpwBCgxTZXRJYW1Qb2xpY3kSIi5nb29n",
            "bGUuaWFtLnYxLlNldElhbVBvbGljeVJlcXVlc3QaFS5nb29nbGUuaWFtLnYx",
            "LlBvbGljeSJRgtPkkwJLIkYvdjFiZXRhMi97cmVzb3VyY2U9cHJvamVjdHMv",
            "Ki9sb2NhdGlvbnMvKi9yZXBvc2l0b3JpZXMvKn06c2V0SWFtUG9saWN5OgEq",
            "EpkBCgxHZXRJYW1Qb2xpY3kSIi5nb29nbGUuaWFtLnYxLkdldElhbVBvbGlj",
            "eVJlcXVlc3QaFS5nb29nbGUuaWFtLnYxLlBvbGljeSJOgtPkkwJIEkYvdjFi",
            "ZXRhMi97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZXBvc2l0",
            "b3JpZXMvKn06Z2V0SWFtUG9saWN5EsIBChJUZXN0SWFtUGVybWlzc2lvbnMS",
            "KC5nb29nbGUuaWFtLnYxLlRlc3RJYW1QZXJtaXNzaW9uc1JlcXVlc3QaKS5n",
            "b29nbGUuaWFtLnYxLlRlc3RJYW1QZXJtaXNzaW9uc1Jlc3BvbnNlIleC0+ST",
            "AlEiTC92MWJldGEyL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8q",
            "L3JlcG9zaXRvcmllcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASoSzwEKEkdl",
            "dFByb2plY3RTZXR0aW5ncxJDLmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJl",
            "Z2lzdHJ5LnYxYmV0YTIuR2V0UHJvamVjdFNldHRpbmdzUmVxdWVzdBo5Lmdv",
            "b2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuUHJvamVj",
            "dFNldHRpbmdzIjmC0+STAiwSKi92MWJldGEyL3tuYW1lPXByb2plY3RzLyov",
            "cHJvamVjdFNldHRpbmdzfdpBBG5hbWUSkAIKFVVwZGF0ZVByb2plY3RTZXR0",
            "aW5ncxJGLmdvb2dsZS5kZXZ0b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0",
            "YTIuVXBkYXRlUHJvamVjdFNldHRpbmdzUmVxdWVzdBo5Lmdvb2dsZS5kZXZ0",
            "b29scy5hcnRpZmFjdHJlZ2lzdHJ5LnYxYmV0YTIuUHJvamVjdFNldHRpbmdz",
            "InSC0+STAk8yOy92MWJldGEyL3twcm9qZWN0X3NldHRpbmdzLm5hbWU9cHJv",
            "amVjdHMvKi9wcm9qZWN0U2V0dGluZ3N9OhBwcm9qZWN0X3NldHRpbmdz2kEc",
            "cHJvamVjdF9zZXR0aW5ncyx1cGRhdGVfbWFzaxqMAcpBH2FydGlmYWN0cmVn",
            "aXN0cnkuZ29vZ2xlYXBpcy5jb23SQWdodHRwczovL3d3dy5nb29nbGVhcGlz",
            "LmNvbS9hdXRoL2Nsb3VkLXBsYXRmb3JtLGh0dHBzOi8vd3d3Lmdvb2dsZWFw",
            "aXMuY29tL2F1dGgvY2xvdWQtcGxhdGZvcm0ucmVhZC1vbmx5QpMCCixjb20u",
            "Z29vZ2xlLmRldnRvb2xzLmFydGlmYWN0cmVnaXN0cnkudjFiZXRhMkIMU2Vy",
            "dmljZVByb3RvUAFaWGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvZGV2dG9vbHMvYXJ0aWZhY3RyZWdpc3RyeS92MWJldGEyO2FydGlm",
            "YWN0cmVnaXN0cnmqAiVHb29nbGUuQ2xvdWQuQXJ0aWZhY3RSZWdpc3RyeS5W",
            "MUJldGEyygIlR29vZ2xlXENsb3VkXEFydGlmYWN0UmVnaXN0cnlcVjFiZXRh",
            "MuoCKEdvb2dsZTo6Q2xvdWQ6OkFydGlmYWN0UmVnaXN0cnk6OlYxYmV0YTJi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.AptArtifactReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.FileReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.PackageReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.RepositoryReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.SettingsReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.TagReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.VersionReflection.Descriptor, global::Google.Cloud.ArtifactRegistry.V1Beta2.YumArtifactReflection.Descriptor, global::Google.Cloud.Iam.V1.IamPolicyReflection.Descriptor, global::Google.Cloud.Iam.V1.PolicyReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ArtifactRegistry.V1Beta2.OperationMetadata), global::Google.Cloud.ArtifactRegistry.V1Beta2.OperationMetadata.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Metadata type for longrunning-operations, currently empty.
  /// </summary>
  public sealed partial class OperationMetadata : pb::IMessage<OperationMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OperationMetadata> _parser = new pb::MessageParser<OperationMetadata>(() => new OperationMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OperationMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ArtifactRegistry.V1Beta2.ServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata(OperationMetadata other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperationMetadata Clone() {
      return new OperationMetadata(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OperationMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OperationMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OperationMetadata other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
