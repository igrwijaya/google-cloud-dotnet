// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1/mitre_attack.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1/mitre_attack.proto</summary>
  public static partial class MitreAttackReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1/mitre_attack.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MitreAttackReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjEvbWl0cmVfYXR0YWNr",
            "LnByb3RvEh5nb29nbGUuY2xvdWQuc2VjdXJpdHljZW50ZXIudjEi2AsKC01p",
            "dHJlQXR0YWNrEkoKDnByaW1hcnlfdGFjdGljGAEgASgOMjIuZ29vZ2xlLmNs",
            "b3VkLnNlY3VyaXR5Y2VudGVyLnYxLk1pdHJlQXR0YWNrLlRhY3RpYxJRChJw",
            "cmltYXJ5X3RlY2huaXF1ZXMYAiADKA4yNS5nb29nbGUuY2xvdWQuc2VjdXJp",
            "dHljZW50ZXIudjEuTWl0cmVBdHRhY2suVGVjaG5pcXVlEk4KEmFkZGl0aW9u",
            "YWxfdGFjdGljcxgDIAMoDjIyLmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRl",
            "ci52MS5NaXRyZUF0dGFjay5UYWN0aWMSVAoVYWRkaXRpb25hbF90ZWNobmlx",
            "dWVzGAQgAygOMjUuZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYxLk1p",
            "dHJlQXR0YWNrLlRlY2huaXF1ZRIPCgd2ZXJzaW9uGAUgASgJIrQCCgZUYWN0",
            "aWMSFgoSVEFDVElDX1VOU1BFQ0lGSUVEEAASEgoOUkVDT05OQUlTU0FOQ0UQ",
            "ARIYChRSRVNPVVJDRV9ERVZFTE9QTUVOVBACEhIKDklOSVRJQUxfQUNDRVNT",
            "EAUSDQoJRVhFQ1VUSU9OEAMSDwoLUEVSU0lTVEVOQ0UQBhIYChRQUklWSUxF",
            "R0VfRVNDQUxBVElPThAIEhMKD0RFRkVOU0VfRVZBU0lPThAHEhUKEUNSRURF",
            "TlRJQUxfQUNDRVNTEAkSDQoJRElTQ09WRVJZEAoSFAoQTEFURVJBTF9NT1ZF",
            "TUVOVBALEg4KCkNPTExFQ1RJT04QDBIXChNDT01NQU5EX0FORF9DT05UUk9M",
            "EAQSEAoMRVhGSUxUUkFUSU9OEA0SCgoGSU1QQUNUEA4iuwYKCVRlY2huaXF1",
            "ZRIZChVURUNITklRVUVfVU5TUEVDSUZJRUQQABITCg9BQ1RJVkVfU0NBTk5J",
            "TkcQARIWChJTQ0FOTklOR19JUF9CTE9DS1MQAhIZChVJTkdSRVNTX1RPT0xf",
            "VFJBTlNGRVIQAxIOCgpOQVRJVkVfQVBJEAQSEgoOU0hBUkVEX01PRFVMRVMQ",
            "BRIlCiFDT01NQU5EX0FORF9TQ1JJUFRJTkdfSU5URVJQUkVURVIQBhIOCgpV",
            "TklYX1NIRUxMEAcSFgoSUkVTT1VSQ0VfSElKQUNLSU5HEAgSCQoFUFJPWFkQ",
            "CRISCg5FWFRFUk5BTF9QUk9YWRAKEhMKD01VTFRJX0hPUF9QUk9YWRALEhYK",
            "EkRZTkFNSUNfUkVTT0xVVElPThAMEhkKFVVOU0VDVVJFRF9DUkVERU5USUFM",
            "UxANEhIKDlZBTElEX0FDQ09VTlRTEA4SEgoOTE9DQUxfQUNDT1VOVFMQDxIS",
            "Cg5DTE9VRF9BQ0NPVU5UUxAQEh0KGU5FVFdPUktfREVOSUFMX09GX1NFUlZJ",
            "Q0UQERIfChtQRVJNSVNTSU9OX0dST1VQU19ESVNDT1ZFUlkQEhIQCgxDTE9V",
            "RF9HUk9VUFMQExIhCh1FWEZJTFRSQVRJT05fT1ZFUl9XRUJfU0VSVklDRRAU",
            "EiEKHUVYRklMVFJBVElPTl9UT19DTE9VRF9TVE9SQUdFEBUSGAoUQUNDT1VO",
            "VF9NQU5JUFVMQVRJT04QFhIXChNTU0hfQVVUSE9SSVpFRF9LRVlTEBcSIwof",
            "Q1JFQVRFX09SX01PRElGWV9TWVNURU1fUFJPQ0VTUxAYEhwKGFNURUFMX1dF",
            "Ql9TRVNTSU9OX0NPT0tJRRAZEicKI01PRElGWV9DTE9VRF9DT01QVVRFX0lO",
            "RlJBU1RSVUNUVVJFEBoSJQohRVhQTE9JVF9QVUJMSUNfRkFDSU5HX0FQUExJ",
            "Q0FUSU9OEBsSIQodTU9ESUZZX0FVVEhFTlRJQ0FUSU9OX1BST0NFU1MQHBIU",
            "ChBEQVRBX0RFU1RSVUNUSU9OEB0SHgoaRE9NQUlOX1BPTElDWV9NT0RJRklD",
            "QVRJT04QHkLsAQoiY29tLmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci52",
            "MUIQTWl0cmVBdHRhY2tQcm90b1ABWkxnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Nsb3VkL3NlY3VyaXR5Y2VudGVyL3YxO3NlY3Vy",
            "aXR5Y2VudGVyqgIeR29vZ2xlLkNsb3VkLlNlY3VyaXR5Q2VudGVyLlYxygIe",
            "R29vZ2xlXENsb3VkXFNlY3VyaXR5Q2VudGVyXFYx6gIhR29vZ2xlOjpDbG91",
            "ZDo6U2VjdXJpdHlDZW50ZXI6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1.MitreAttack), global::Google.Cloud.SecurityCenter.V1.MitreAttack.Parser, new[]{ "PrimaryTactic", "PrimaryTechniques", "AdditionalTactics", "AdditionalTechniques", "Version" }, null, new[]{ typeof(global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic), typeof(global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Technique) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// MITRE ATT&amp;CK tactics and techniques related to this finding.
  /// See: https://attack.mitre.org
  /// </summary>
  public sealed partial class MitreAttack : pb::IMessage<MitreAttack>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MitreAttack> _parser = new pb::MessageParser<MitreAttack>(() => new MitreAttack());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MitreAttack> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1.MitreAttackReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MitreAttack() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MitreAttack(MitreAttack other) : this() {
      primaryTactic_ = other.primaryTactic_;
      primaryTechniques_ = other.primaryTechniques_.Clone();
      additionalTactics_ = other.additionalTactics_.Clone();
      additionalTechniques_ = other.additionalTechniques_.Clone();
      version_ = other.version_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MitreAttack Clone() {
      return new MitreAttack(this);
    }

    /// <summary>Field number for the "primary_tactic" field.</summary>
    public const int PrimaryTacticFieldNumber = 1;
    private global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic primaryTactic_ = global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic.Unspecified;
    /// <summary>
    /// The MITRE ATT&amp;CK tactic most closely represented by this finding, if any.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic PrimaryTactic {
      get { return primaryTactic_; }
      set {
        primaryTactic_ = value;
      }
    }

    /// <summary>Field number for the "primary_techniques" field.</summary>
    public const int PrimaryTechniquesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Technique> _repeated_primaryTechniques_codec
        = pb::FieldCodec.ForEnum(18, x => (int) x, x => (global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Technique) x);
    private readonly pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Technique> primaryTechniques_ = new pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Technique>();
    /// <summary>
    /// The MITRE ATT&amp;CK technique most closely represented by this finding, if
    /// any. primary_techniques is a repeated field because there are multiple
    /// levels of MITRE ATT&amp;CK techniques.  If the technique most closely
    /// represented by this finding is a sub-technique (e.g. `SCANNING_IP_BLOCKS`),
    /// both the sub-technique and its parent technique(s) will be listed (e.g.
    /// `SCANNING_IP_BLOCKS`, `ACTIVE_SCANNING`).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Technique> PrimaryTechniques {
      get { return primaryTechniques_; }
    }

    /// <summary>Field number for the "additional_tactics" field.</summary>
    public const int AdditionalTacticsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic> _repeated_additionalTactics_codec
        = pb::FieldCodec.ForEnum(26, x => (int) x, x => (global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic) x);
    private readonly pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic> additionalTactics_ = new pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic>();
    /// <summary>
    /// Additional MITRE ATT&amp;CK tactics related to this finding, if any.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic> AdditionalTactics {
      get { return additionalTactics_; }
    }

    /// <summary>Field number for the "additional_techniques" field.</summary>
    public const int AdditionalTechniquesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Technique> _repeated_additionalTechniques_codec
        = pb::FieldCodec.ForEnum(34, x => (int) x, x => (global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Technique) x);
    private readonly pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Technique> additionalTechniques_ = new pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Technique>();
    /// <summary>
    /// Additional MITRE ATT&amp;CK techniques related to this finding, if any, along
    /// with any of their respective parent techniques.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Technique> AdditionalTechniques {
      get { return additionalTechniques_; }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 5;
    private string version_ = "";
    /// <summary>
    /// The MITRE ATT&amp;CK version referenced by the above fields. E.g. "8".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MitreAttack);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MitreAttack other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PrimaryTactic != other.PrimaryTactic) return false;
      if(!primaryTechniques_.Equals(other.primaryTechniques_)) return false;
      if(!additionalTactics_.Equals(other.additionalTactics_)) return false;
      if(!additionalTechniques_.Equals(other.additionalTechniques_)) return false;
      if (Version != other.Version) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PrimaryTactic != global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic.Unspecified) hash ^= PrimaryTactic.GetHashCode();
      hash ^= primaryTechniques_.GetHashCode();
      hash ^= additionalTactics_.GetHashCode();
      hash ^= additionalTechniques_.GetHashCode();
      if (Version.Length != 0) hash ^= Version.GetHashCode();
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
      if (PrimaryTactic != global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) PrimaryTactic);
      }
      primaryTechniques_.WriteTo(output, _repeated_primaryTechniques_codec);
      additionalTactics_.WriteTo(output, _repeated_additionalTactics_codec);
      additionalTechniques_.WriteTo(output, _repeated_additionalTechniques_codec);
      if (Version.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Version);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (PrimaryTactic != global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) PrimaryTactic);
      }
      primaryTechniques_.WriteTo(ref output, _repeated_primaryTechniques_codec);
      additionalTactics_.WriteTo(ref output, _repeated_additionalTactics_codec);
      additionalTechniques_.WriteTo(ref output, _repeated_additionalTechniques_codec);
      if (Version.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Version);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (PrimaryTactic != global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PrimaryTactic);
      }
      size += primaryTechniques_.CalculateSize(_repeated_primaryTechniques_codec);
      size += additionalTactics_.CalculateSize(_repeated_additionalTactics_codec);
      size += additionalTechniques_.CalculateSize(_repeated_additionalTechniques_codec);
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MitreAttack other) {
      if (other == null) {
        return;
      }
      if (other.PrimaryTactic != global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic.Unspecified) {
        PrimaryTactic = other.PrimaryTactic;
      }
      primaryTechniques_.Add(other.primaryTechniques_);
      additionalTactics_.Add(other.additionalTactics_);
      additionalTechniques_.Add(other.additionalTechniques_);
      if (other.Version.Length != 0) {
        Version = other.Version;
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
          case 8: {
            PrimaryTactic = (global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            primaryTechniques_.AddEntriesFrom(input, _repeated_primaryTechniques_codec);
            break;
          }
          case 26:
          case 24: {
            additionalTactics_.AddEntriesFrom(input, _repeated_additionalTactics_codec);
            break;
          }
          case 34:
          case 32: {
            additionalTechniques_.AddEntriesFrom(input, _repeated_additionalTechniques_codec);
            break;
          }
          case 42: {
            Version = input.ReadString();
            break;
          }
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
          case 8: {
            PrimaryTactic = (global::Google.Cloud.SecurityCenter.V1.MitreAttack.Types.Tactic) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            primaryTechniques_.AddEntriesFrom(ref input, _repeated_primaryTechniques_codec);
            break;
          }
          case 26:
          case 24: {
            additionalTactics_.AddEntriesFrom(ref input, _repeated_additionalTactics_codec);
            break;
          }
          case 34:
          case 32: {
            additionalTechniques_.AddEntriesFrom(ref input, _repeated_additionalTechniques_codec);
            break;
          }
          case 42: {
            Version = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the MitreAttack message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// MITRE ATT&amp;CK tactics that can be referenced by SCC findings.
      /// See: https://attack.mitre.org/tactics/enterprise/
      /// </summary>
      public enum Tactic {
        /// <summary>
        /// Unspecified value.
        /// </summary>
        [pbr::OriginalName("TACTIC_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// TA0043
        /// </summary>
        [pbr::OriginalName("RECONNAISSANCE")] Reconnaissance = 1,
        /// <summary>
        /// TA0042
        /// </summary>
        [pbr::OriginalName("RESOURCE_DEVELOPMENT")] ResourceDevelopment = 2,
        /// <summary>
        /// TA0001
        /// </summary>
        [pbr::OriginalName("INITIAL_ACCESS")] InitialAccess = 5,
        /// <summary>
        /// TA0002
        /// </summary>
        [pbr::OriginalName("EXECUTION")] Execution = 3,
        /// <summary>
        /// TA0003
        /// </summary>
        [pbr::OriginalName("PERSISTENCE")] Persistence = 6,
        /// <summary>
        /// TA0004
        /// </summary>
        [pbr::OriginalName("PRIVILEGE_ESCALATION")] PrivilegeEscalation = 8,
        /// <summary>
        /// TA0005
        /// </summary>
        [pbr::OriginalName("DEFENSE_EVASION")] DefenseEvasion = 7,
        /// <summary>
        /// TA0006
        /// </summary>
        [pbr::OriginalName("CREDENTIAL_ACCESS")] CredentialAccess = 9,
        /// <summary>
        /// TA0007
        /// </summary>
        [pbr::OriginalName("DISCOVERY")] Discovery = 10,
        /// <summary>
        /// TA0008
        /// </summary>
        [pbr::OriginalName("LATERAL_MOVEMENT")] LateralMovement = 11,
        /// <summary>
        /// TA0009
        /// </summary>
        [pbr::OriginalName("COLLECTION")] Collection = 12,
        /// <summary>
        /// TA0011
        /// </summary>
        [pbr::OriginalName("COMMAND_AND_CONTROL")] CommandAndControl = 4,
        /// <summary>
        /// TA0010
        /// </summary>
        [pbr::OriginalName("EXFILTRATION")] Exfiltration = 13,
        /// <summary>
        /// TA0040
        /// </summary>
        [pbr::OriginalName("IMPACT")] Impact = 14,
      }

      /// <summary>
      /// MITRE ATT&amp;CK techniques that can be referenced by SCC findings.
      /// See: https://attack.mitre.org/techniques/enterprise/
      /// Next ID: 31
      /// </summary>
      public enum Technique {
        /// <summary>
        /// Unspecified value.
        /// </summary>
        [pbr::OriginalName("TECHNIQUE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// T1595
        /// </summary>
        [pbr::OriginalName("ACTIVE_SCANNING")] ActiveScanning = 1,
        /// <summary>
        /// T1595.001
        /// </summary>
        [pbr::OriginalName("SCANNING_IP_BLOCKS")] ScanningIpBlocks = 2,
        /// <summary>
        /// T1105
        /// </summary>
        [pbr::OriginalName("INGRESS_TOOL_TRANSFER")] IngressToolTransfer = 3,
        /// <summary>
        /// T1106
        /// </summary>
        [pbr::OriginalName("NATIVE_API")] NativeApi = 4,
        /// <summary>
        /// T1129
        /// </summary>
        [pbr::OriginalName("SHARED_MODULES")] SharedModules = 5,
        /// <summary>
        /// T1059
        /// </summary>
        [pbr::OriginalName("COMMAND_AND_SCRIPTING_INTERPRETER")] CommandAndScriptingInterpreter = 6,
        /// <summary>
        /// T1059.004
        /// </summary>
        [pbr::OriginalName("UNIX_SHELL")] UnixShell = 7,
        /// <summary>
        /// T1496
        /// </summary>
        [pbr::OriginalName("RESOURCE_HIJACKING")] ResourceHijacking = 8,
        /// <summary>
        /// T1090
        /// </summary>
        [pbr::OriginalName("PROXY")] Proxy = 9,
        /// <summary>
        /// T1090.002
        /// </summary>
        [pbr::OriginalName("EXTERNAL_PROXY")] ExternalProxy = 10,
        /// <summary>
        /// T1090.003
        /// </summary>
        [pbr::OriginalName("MULTI_HOP_PROXY")] MultiHopProxy = 11,
        /// <summary>
        /// T1568
        /// </summary>
        [pbr::OriginalName("DYNAMIC_RESOLUTION")] DynamicResolution = 12,
        /// <summary>
        /// T1552
        /// </summary>
        [pbr::OriginalName("UNSECURED_CREDENTIALS")] UnsecuredCredentials = 13,
        /// <summary>
        /// T1078
        /// </summary>
        [pbr::OriginalName("VALID_ACCOUNTS")] ValidAccounts = 14,
        /// <summary>
        /// T1078.003
        /// </summary>
        [pbr::OriginalName("LOCAL_ACCOUNTS")] LocalAccounts = 15,
        /// <summary>
        /// T1078.004
        /// </summary>
        [pbr::OriginalName("CLOUD_ACCOUNTS")] CloudAccounts = 16,
        /// <summary>
        /// T1498
        /// </summary>
        [pbr::OriginalName("NETWORK_DENIAL_OF_SERVICE")] NetworkDenialOfService = 17,
        /// <summary>
        /// T1069
        /// </summary>
        [pbr::OriginalName("PERMISSION_GROUPS_DISCOVERY")] PermissionGroupsDiscovery = 18,
        /// <summary>
        /// T1069.003
        /// </summary>
        [pbr::OriginalName("CLOUD_GROUPS")] CloudGroups = 19,
        /// <summary>
        /// T1567
        /// </summary>
        [pbr::OriginalName("EXFILTRATION_OVER_WEB_SERVICE")] ExfiltrationOverWebService = 20,
        /// <summary>
        /// T1567.002
        /// </summary>
        [pbr::OriginalName("EXFILTRATION_TO_CLOUD_STORAGE")] ExfiltrationToCloudStorage = 21,
        /// <summary>
        /// T1098
        /// </summary>
        [pbr::OriginalName("ACCOUNT_MANIPULATION")] AccountManipulation = 22,
        /// <summary>
        /// T1098.004
        /// </summary>
        [pbr::OriginalName("SSH_AUTHORIZED_KEYS")] SshAuthorizedKeys = 23,
        /// <summary>
        /// T1543
        /// </summary>
        [pbr::OriginalName("CREATE_OR_MODIFY_SYSTEM_PROCESS")] CreateOrModifySystemProcess = 24,
        /// <summary>
        /// T1539
        /// </summary>
        [pbr::OriginalName("STEAL_WEB_SESSION_COOKIE")] StealWebSessionCookie = 25,
        /// <summary>
        /// T1578
        /// </summary>
        [pbr::OriginalName("MODIFY_CLOUD_COMPUTE_INFRASTRUCTURE")] ModifyCloudComputeInfrastructure = 26,
        /// <summary>
        /// T1190
        /// </summary>
        [pbr::OriginalName("EXPLOIT_PUBLIC_FACING_APPLICATION")] ExploitPublicFacingApplication = 27,
        /// <summary>
        /// T1556
        /// </summary>
        [pbr::OriginalName("MODIFY_AUTHENTICATION_PROCESS")] ModifyAuthenticationProcess = 28,
        /// <summary>
        /// T1485
        /// </summary>
        [pbr::OriginalName("DATA_DESTRUCTION")] DataDestruction = 29,
        /// <summary>
        /// T1484
        /// </summary>
        [pbr::OriginalName("DOMAIN_POLICY_MODIFICATION")] DomainPolicyModification = 30,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
