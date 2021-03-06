// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/resources/ad_parameter.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/resources/ad_parameter.proto</summary>
  public static partial class AdParameterReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/resources/ad_parameter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdParameterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXMvYWRfcGFyYW1l",
            "dGVyLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5yZXNvdXJjZXMa",
            "H2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkv",
            "cmVzb3VyY2UucHJvdG8aHmdvb2dsZS9wcm90b2J1Zi93cmFwcGVycy5wcm90",
            "bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKNAwoLQWRQYXJhbWV0",
            "ZXISQwoNcmVzb3VyY2VfbmFtZRgBIAEoCUIs4EEF+kEmCiRnb29nbGVhZHMu",
            "Z29vZ2xlYXBpcy5jb20vQWRQYXJhbWV0ZXISawoSYWRfZ3JvdXBfY3JpdGVy",
            "aW9uGAIgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQjHgQQX6",
            "QSsKKWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9BZEdyb3VwQ3JpdGVyaW9u",
            "EjkKD3BhcmFtZXRlcl9pbmRleBgDIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5J",
            "bnQ2NFZhbHVlQgPgQQUSNAoOaW5zZXJ0aW9uX3RleHQYBCABKAsyHC5nb29n",
            "bGUucHJvdG9idWYuU3RyaW5nVmFsdWU6W+pBWAokZ29vZ2xlYWRzLmdvb2ds",
            "ZWFwaXMuY29tL0FkUGFyYW1ldGVyEjBjdXN0b21lcnMve2N1c3RvbWVyfS9h",
            "ZFBhcmFtZXRlcnMve2FkX3BhcmFtZXRlcn1C/QEKJWNvbS5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52Mi5yZXNvdXJjZXNCEEFkUGFyYW1ldGVyUHJvdG9QAVpK",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29v",
            "Z2xlYWRzL3YyL3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUu",
            "QWRzLkdvb2dsZUFkcy5WMi5SZXNvdXJjZXPKAiFHb29nbGVcQWRzXEdvb2ds",
            "ZUFkc1xWMlxSZXNvdXJjZXPqAiVHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpW",
            "Mjo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Resources.AdParameter), global::Google.Ads.GoogleAds.V2.Resources.AdParameter.Parser, new[]{ "ResourceName", "AdGroupCriterion", "ParameterIndex", "InsertionText" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An ad parameter that is used to update numeric values (such as prices or
  /// inventory levels) in any text line of an ad (including URLs). There can
  /// be a maximum of two AdParameters per ad group criterion. (One with
  /// parameter_index = 1 and one with parameter_index = 2.)
  /// In the ad the parameters are referenced by a placeholder of the form
  /// "{param#:value}". E.g. "{param1:$17}"
  /// </summary>
  public sealed partial class AdParameter : pb::IMessage<AdParameter>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdParameter> _parser = new pb::MessageParser<AdParameter>(() => new AdParameter());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdParameter> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Resources.AdParameterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdParameter() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdParameter(AdParameter other) : this() {
      resourceName_ = other.resourceName_;
      AdGroupCriterion = other.AdGroupCriterion;
      ParameterIndex = other.ParameterIndex;
      InsertionText = other.InsertionText;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdParameter Clone() {
      return new AdParameter(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the ad parameter.
    /// Ad parameter resource names have the form:
    ///
    /// `customers/{customer_id}/adParameters/{ad_group_id}~{criterion_id}~{parameter_index}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ad_group_criterion" field.</summary>
    public const int AdGroupCriterionFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_adGroupCriterion_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string adGroupCriterion_;
    /// <summary>
    /// Immutable. The ad group criterion that this ad parameter belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroupCriterion {
      get { return adGroupCriterion_; }
      set {
        adGroupCriterion_ = value;
      }
    }


    /// <summary>Field number for the "parameter_index" field.</summary>
    public const int ParameterIndexFieldNumber = 3;
    private static readonly pb::FieldCodec<long?> _single_parameterIndex_codec = pb::FieldCodec.ForStructWrapper<long>(26);
    private long? parameterIndex_;
    /// <summary>
    /// Immutable. The unique index of this ad parameter. Must be either 1 or 2.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? ParameterIndex {
      get { return parameterIndex_; }
      set {
        parameterIndex_ = value;
      }
    }


    /// <summary>Field number for the "insertion_text" field.</summary>
    public const int InsertionTextFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_insertionText_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string insertionText_;
    /// <summary>
    /// Numeric value to insert into the ad text. The following restrictions
    ///  apply:
    ///  - Can use comma or period as a separator, with an optional period or
    ///    comma (respectively) for fractional values. For example, 1,000,000.00
    ///    and 2.000.000,10 are valid.
    ///  - Can be prepended or appended with a currency symbol. For example,
    ///    $99.99 is valid.
    ///  - Can be prepended or appended with a currency code. For example, 99.99USD
    ///    and EUR200 are valid.
    ///  - Can use '%'. For example, 1.0% and 1,0% are valid.
    ///  - Can use plus or minus. For example, -10.99 and 25+ are valid.
    ///  - Can use '/' between two numbers. For example 4/1 and 0.95/0.45 are
    ///    valid.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InsertionText {
      get { return insertionText_; }
      set {
        insertionText_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdParameter);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdParameter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AdGroupCriterion != other.AdGroupCriterion) return false;
      if (ParameterIndex != other.ParameterIndex) return false;
      if (InsertionText != other.InsertionText) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (adGroupCriterion_ != null) hash ^= AdGroupCriterion.GetHashCode();
      if (parameterIndex_ != null) hash ^= ParameterIndex.GetHashCode();
      if (insertionText_ != null) hash ^= InsertionText.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (adGroupCriterion_ != null) {
        _single_adGroupCriterion_codec.WriteTagAndValue(output, AdGroupCriterion);
      }
      if (parameterIndex_ != null) {
        _single_parameterIndex_codec.WriteTagAndValue(output, ParameterIndex);
      }
      if (insertionText_ != null) {
        _single_insertionText_codec.WriteTagAndValue(output, InsertionText);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (adGroupCriterion_ != null) {
        _single_adGroupCriterion_codec.WriteTagAndValue(ref output, AdGroupCriterion);
      }
      if (parameterIndex_ != null) {
        _single_parameterIndex_codec.WriteTagAndValue(ref output, ParameterIndex);
      }
      if (insertionText_ != null) {
        _single_insertionText_codec.WriteTagAndValue(ref output, InsertionText);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (adGroupCriterion_ != null) {
        size += _single_adGroupCriterion_codec.CalculateSizeWithTag(AdGroupCriterion);
      }
      if (parameterIndex_ != null) {
        size += _single_parameterIndex_codec.CalculateSizeWithTag(ParameterIndex);
      }
      if (insertionText_ != null) {
        size += _single_insertionText_codec.CalculateSizeWithTag(InsertionText);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdParameter other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.adGroupCriterion_ != null) {
        if (adGroupCriterion_ == null || other.AdGroupCriterion != "") {
          AdGroupCriterion = other.AdGroupCriterion;
        }
      }
      if (other.parameterIndex_ != null) {
        if (parameterIndex_ == null || other.ParameterIndex != 0L) {
          ParameterIndex = other.ParameterIndex;
        }
      }
      if (other.insertionText_ != null) {
        if (insertionText_ == null || other.InsertionText != "") {
          InsertionText = other.InsertionText;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            string value = _single_adGroupCriterion_codec.Read(input);
            if (adGroupCriterion_ == null || value != "") {
              AdGroupCriterion = value;
            }
            break;
          }
          case 26: {
            long? value = _single_parameterIndex_codec.Read(input);
            if (parameterIndex_ == null || value != 0L) {
              ParameterIndex = value;
            }
            break;
          }
          case 34: {
            string value = _single_insertionText_codec.Read(input);
            if (insertionText_ == null || value != "") {
              InsertionText = value;
            }
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            string value = _single_adGroupCriterion_codec.Read(ref input);
            if (adGroupCriterion_ == null || value != "") {
              AdGroupCriterion = value;
            }
            break;
          }
          case 26: {
            long? value = _single_parameterIndex_codec.Read(ref input);
            if (parameterIndex_ == null || value != 0L) {
              ParameterIndex = value;
            }
            break;
          }
          case 34: {
            string value = _single_insertionText_codec.Read(ref input);
            if (insertionText_ == null || value != "") {
              InsertionText = value;
            }
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
