// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/resources/ad_group_ad_label.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/resources/ad_group_ad_label.proto</summary>
  public static partial class AdGroupAdLabelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/resources/ad_group_ad_label.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupAdLabelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXMvYWRfZ3JvdXBf",
            "YWRfbGFiZWwucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLnJlc291",
            "cmNlcxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xl",
            "L2FwaS9yZXNvdXJjZS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJz",
            "LnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIvQCCg5BZEdy",
            "b3VwQWRMYWJlbBJGCg1yZXNvdXJjZV9uYW1lGAEgASgJQi/gQQX6QSkKJ2dv",
            "b2dsZWFkcy5nb29nbGVhcGlzLmNvbS9BZEdyb3VwQWRMYWJlbBJdCgthZF9n",
            "cm91cF9hZBgCIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZUIq",
            "4EEF+kEkCiJnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQWRHcm91cEFkElMK",
            "BWxhYmVsGAMgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQibg",
            "QQX6QSAKHmdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9MYWJlbDpm6kFjCidn",
            "b29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQWRHcm91cEFkTGFiZWwSOGN1c3Rv",
            "bWVycy97Y3VzdG9tZXJ9L2FkR3JvdXBBZExhYmVscy97YWRfZ3JvdXBfYWRf",
            "bGFiZWx9QoACCiVjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIucmVzb3Vy",
            "Y2VzQhNBZEdyb3VwQWRMYWJlbFByb3RvUAFaSmdvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJj",
            "ZXM7cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIu",
            "UmVzb3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNcVjJcUmVzb3VyY2Vz",
            "6gIlR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjI6OlJlc291cmNlc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Resources.AdGroupAdLabel), global::Google.Ads.GoogleAds.V2.Resources.AdGroupAdLabel.Parser, new[]{ "ResourceName", "AdGroupAd", "Label" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A relationship between an ad group ad and a label.
  /// </summary>
  public sealed partial class AdGroupAdLabel : pb::IMessage<AdGroupAdLabel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupAdLabel> _parser = new pb::MessageParser<AdGroupAdLabel>(() => new AdGroupAdLabel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupAdLabel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Resources.AdGroupAdLabelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAdLabel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAdLabel(AdGroupAdLabel other) : this() {
      resourceName_ = other.resourceName_;
      AdGroupAd = other.AdGroupAd;
      Label = other.Label;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAdLabel Clone() {
      return new AdGroupAdLabel(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the ad group ad label.
    /// Ad group ad label resource names have the form:
    /// `customers/{customer_id}/adGroupAdLabels/{ad_group_id}~{ad_id}~{label_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ad_group_ad" field.</summary>
    public const int AdGroupAdFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_adGroupAd_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string adGroupAd_;
    /// <summary>
    /// Immutable. The ad group ad to which the label is attached.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroupAd {
      get { return adGroupAd_; }
      set {
        adGroupAd_ = value;
      }
    }


    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_label_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string label_;
    /// <summary>
    /// Immutable. The label assigned to the ad group ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Label {
      get { return label_; }
      set {
        label_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupAdLabel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupAdLabel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AdGroupAd != other.AdGroupAd) return false;
      if (Label != other.Label) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (adGroupAd_ != null) hash ^= AdGroupAd.GetHashCode();
      if (label_ != null) hash ^= Label.GetHashCode();
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
      if (adGroupAd_ != null) {
        _single_adGroupAd_codec.WriteTagAndValue(output, AdGroupAd);
      }
      if (label_ != null) {
        _single_label_codec.WriteTagAndValue(output, Label);
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
      if (adGroupAd_ != null) {
        _single_adGroupAd_codec.WriteTagAndValue(ref output, AdGroupAd);
      }
      if (label_ != null) {
        _single_label_codec.WriteTagAndValue(ref output, Label);
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
      if (adGroupAd_ != null) {
        size += _single_adGroupAd_codec.CalculateSizeWithTag(AdGroupAd);
      }
      if (label_ != null) {
        size += _single_label_codec.CalculateSizeWithTag(Label);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdGroupAdLabel other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.adGroupAd_ != null) {
        if (adGroupAd_ == null || other.AdGroupAd != "") {
          AdGroupAd = other.AdGroupAd;
        }
      }
      if (other.label_ != null) {
        if (label_ == null || other.Label != "") {
          Label = other.Label;
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
            string value = _single_adGroupAd_codec.Read(input);
            if (adGroupAd_ == null || value != "") {
              AdGroupAd = value;
            }
            break;
          }
          case 26: {
            string value = _single_label_codec.Read(input);
            if (label_ == null || value != "") {
              Label = value;
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
            string value = _single_adGroupAd_codec.Read(ref input);
            if (adGroupAd_ == null || value != "") {
              AdGroupAd = value;
            }
            break;
          }
          case 26: {
            string value = _single_label_codec.Read(ref input);
            if (label_ == null || value != "") {
              Label = value;
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
