// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/errors/mutate_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/errors/mutate_error.proto</summary>
  public static partial class MutateErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/errors/mutate_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MutateErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnMvbXV0YXRlX2Vycm9y",
            "LnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5lcnJvcnMaHGdvb2ds",
            "ZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i7gEKD011dGF0ZUVycm9yRW51bSLa",
            "AQoLTXV0YXRlRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAES",
            "FgoSUkVTT1VSQ0VfTk9UX0ZPVU5EEAMSIQodSURfRVhJU1RTX0lOX01VTFRJ",
            "UExFX01VVEFURVMQBxIdChlJTkNPTlNJU1RFTlRfRklFTERfVkFMVUVTEAgS",
            "FgoSTVVUQVRFX05PVF9BTExPV0VEEAkSHgoaUkVTT1VSQ0VfTk9UX0lOX0dP",
            "T0dMRV9BRFMQChIbChdSRVNPVVJDRV9BTFJFQURZX0VYSVNUUxALQusBCiJj",
            "b20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuZXJyb3JzQhBNdXRhdGVFcnJv",
            "clByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFw",
            "aXMvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnM7ZXJyb3JzogIDR0FBqgIeR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjEuRXJyb3JzygIeR29vZ2xlXEFkc1xHb29n",
            "bGVBZHNcVjFcRXJyb3Jz6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE6",
            "OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Errors.MutateErrorEnum), global::Google.Ads.GoogleAds.V1.Errors.MutateErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Errors.MutateErrorEnum.Types.MutateError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible mutate errors.
  /// </summary>
  public sealed partial class MutateErrorEnum : pb::IMessage<MutateErrorEnum> {
    private static readonly pb::MessageParser<MutateErrorEnum> _parser = new pb::MessageParser<MutateErrorEnum>(() => new MutateErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Errors.MutateErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateErrorEnum(MutateErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateErrorEnum Clone() {
      return new MutateErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the MutateErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible mutate errors.
      /// </summary>
      public enum MutateError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Requested resource was not found.
        /// </summary>
        [pbr::OriginalName("RESOURCE_NOT_FOUND")] ResourceNotFound = 3,
        /// <summary>
        /// Cannot mutate the same resource twice in one request.
        /// </summary>
        [pbr::OriginalName("ID_EXISTS_IN_MULTIPLE_MUTATES")] IdExistsInMultipleMutates = 7,
        /// <summary>
        /// The field's contents don't match another field that represents the same
        /// data.
        /// </summary>
        [pbr::OriginalName("INCONSISTENT_FIELD_VALUES")] InconsistentFieldValues = 8,
        /// <summary>
        /// Mutates are not allowed for the requested resource.
        /// </summary>
        [pbr::OriginalName("MUTATE_NOT_ALLOWED")] MutateNotAllowed = 9,
        /// <summary>
        /// The resource isn't in Google Ads. It belongs to another ads system.
        /// </summary>
        [pbr::OriginalName("RESOURCE_NOT_IN_GOOGLE_ADS")] ResourceNotInGoogleAds = 10,
        /// <summary>
        /// The resource being created already exists.
        /// </summary>
        [pbr::OriginalName("RESOURCE_ALREADY_EXISTS")] ResourceAlreadyExists = 11,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code