// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/appengine/v1/location.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AppEngine.V1 {

  /// <summary>Holder for reflection information generated from google/appengine/v1/location.proto</summary>
  public static partial class LocationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/appengine/v1/location.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJnb29nbGUvYXBwZW5naW5lL3YxL2xvY2F0aW9uLnByb3RvEhNnb29nbGUu",
            "YXBwZW5naW5lLnYxGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3Rv",
            "IoUBChBMb2NhdGlvbk1ldGFkYXRhEiYKHnN0YW5kYXJkX2Vudmlyb25tZW50",
            "X2F2YWlsYWJsZRgCIAEoCBImCh5mbGV4aWJsZV9lbnZpcm9ubWVudF9hdmFp",
            "bGFibGUYBCABKAgSIQoUc2VhcmNoX2FwaV9hdmFpbGFibGUYBiABKAhCA+BB",
            "A0K/AQoXY29tLmdvb2dsZS5hcHBlbmdpbmUudjFCDUxvY2F0aW9uUHJvdG9Q",
            "AVo8Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hcHBl",
            "bmdpbmUvdjE7YXBwZW5naW5lqgIZR29vZ2xlLkNsb3VkLkFwcEVuZ2luZS5W",
            "McoCGUdvb2dsZVxDbG91ZFxBcHBFbmdpbmVcVjHqAhxHb29nbGU6OkNsb3Vk",
            "OjpBcHBFbmdpbmU6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AppEngine.V1.LocationMetadata), global::Google.Cloud.AppEngine.V1.LocationMetadata.Parser, new[]{ "StandardEnvironmentAvailable", "FlexibleEnvironmentAvailable", "SearchApiAvailable" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Metadata for the given [google.cloud.location.Location][google.cloud.location.Location].
  /// </summary>
  public sealed partial class LocationMetadata : pb::IMessage<LocationMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LocationMetadata> _parser = new pb::MessageParser<LocationMetadata>(() => new LocationMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LocationMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AppEngine.V1.LocationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocationMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocationMetadata(LocationMetadata other) : this() {
      standardEnvironmentAvailable_ = other.standardEnvironmentAvailable_;
      flexibleEnvironmentAvailable_ = other.flexibleEnvironmentAvailable_;
      searchApiAvailable_ = other.searchApiAvailable_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocationMetadata Clone() {
      return new LocationMetadata(this);
    }

    /// <summary>Field number for the "standard_environment_available" field.</summary>
    public const int StandardEnvironmentAvailableFieldNumber = 2;
    private bool standardEnvironmentAvailable_;
    /// <summary>
    /// App Engine standard environment is available in the given location.
    ///
    /// @OutputOnly
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool StandardEnvironmentAvailable {
      get { return standardEnvironmentAvailable_; }
      set {
        standardEnvironmentAvailable_ = value;
      }
    }

    /// <summary>Field number for the "flexible_environment_available" field.</summary>
    public const int FlexibleEnvironmentAvailableFieldNumber = 4;
    private bool flexibleEnvironmentAvailable_;
    /// <summary>
    /// App Engine flexible environment is available in the given location.
    ///
    /// @OutputOnly
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool FlexibleEnvironmentAvailable {
      get { return flexibleEnvironmentAvailable_; }
      set {
        flexibleEnvironmentAvailable_ = value;
      }
    }

    /// <summary>Field number for the "search_api_available" field.</summary>
    public const int SearchApiAvailableFieldNumber = 6;
    private bool searchApiAvailable_;
    /// <summary>
    /// Output only. [Search API](https://cloud.google.com/appengine/docs/standard/python/search)
    /// is available in the given location.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool SearchApiAvailable {
      get { return searchApiAvailable_; }
      set {
        searchApiAvailable_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LocationMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LocationMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StandardEnvironmentAvailable != other.StandardEnvironmentAvailable) return false;
      if (FlexibleEnvironmentAvailable != other.FlexibleEnvironmentAvailable) return false;
      if (SearchApiAvailable != other.SearchApiAvailable) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StandardEnvironmentAvailable != false) hash ^= StandardEnvironmentAvailable.GetHashCode();
      if (FlexibleEnvironmentAvailable != false) hash ^= FlexibleEnvironmentAvailable.GetHashCode();
      if (SearchApiAvailable != false) hash ^= SearchApiAvailable.GetHashCode();
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
      if (StandardEnvironmentAvailable != false) {
        output.WriteRawTag(16);
        output.WriteBool(StandardEnvironmentAvailable);
      }
      if (FlexibleEnvironmentAvailable != false) {
        output.WriteRawTag(32);
        output.WriteBool(FlexibleEnvironmentAvailable);
      }
      if (SearchApiAvailable != false) {
        output.WriteRawTag(48);
        output.WriteBool(SearchApiAvailable);
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
      if (StandardEnvironmentAvailable != false) {
        output.WriteRawTag(16);
        output.WriteBool(StandardEnvironmentAvailable);
      }
      if (FlexibleEnvironmentAvailable != false) {
        output.WriteRawTag(32);
        output.WriteBool(FlexibleEnvironmentAvailable);
      }
      if (SearchApiAvailable != false) {
        output.WriteRawTag(48);
        output.WriteBool(SearchApiAvailable);
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
      if (StandardEnvironmentAvailable != false) {
        size += 1 + 1;
      }
      if (FlexibleEnvironmentAvailable != false) {
        size += 1 + 1;
      }
      if (SearchApiAvailable != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LocationMetadata other) {
      if (other == null) {
        return;
      }
      if (other.StandardEnvironmentAvailable != false) {
        StandardEnvironmentAvailable = other.StandardEnvironmentAvailable;
      }
      if (other.FlexibleEnvironmentAvailable != false) {
        FlexibleEnvironmentAvailable = other.FlexibleEnvironmentAvailable;
      }
      if (other.SearchApiAvailable != false) {
        SearchApiAvailable = other.SearchApiAvailable;
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
          case 16: {
            StandardEnvironmentAvailable = input.ReadBool();
            break;
          }
          case 32: {
            FlexibleEnvironmentAvailable = input.ReadBool();
            break;
          }
          case 48: {
            SearchApiAvailable = input.ReadBool();
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
          case 16: {
            StandardEnvironmentAvailable = input.ReadBool();
            break;
          }
          case 32: {
            FlexibleEnvironmentAvailable = input.ReadBool();
            break;
          }
          case 48: {
            SearchApiAvailable = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
