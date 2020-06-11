// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/ad_group_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/ad_group_type.proto</summary>
  public static partial class AdGroupTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/ad_group_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9hZF9ncm91cF90eXBl",
            "LnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5lbnVtcxocZ29vZ2xl",
            "L2FwaS9hbm5vdGF0aW9ucy5wcm90byLxAgoPQWRHcm91cFR5cGVFbnVtIt0C",
            "CgtBZEdyb3VwVHlwZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIT",
            "Cg9TRUFSQ0hfU1RBTkRBUkQQAhIUChBESVNQTEFZX1NUQU5EQVJEEAMSGAoU",
            "U0hPUFBJTkdfUFJPRFVDVF9BRFMQBBINCglIT1RFTF9BRFMQBhIWChJTSE9Q",
            "UElOR19TTUFSVF9BRFMQBxIQCgxWSURFT19CVU1QRVIQCBIdChlWSURFT19U",
            "UlVFX1ZJRVdfSU5fU1RSRUFNEAkSHgoaVklERU9fVFJVRV9WSUVXX0lOX0RJ",
            "U1BMQVkQChIhCh1WSURFT19OT05fU0tJUFBBQkxFX0lOX1NUUkVBTRALEhMK",
            "D1ZJREVPX09VVFNUUkVBTRAMEhYKElNFQVJDSF9EWU5BTUlDX0FEUxANEiMK",
            "H1NIT1BQSU5HX0NPTVBBUklTT05fTElTVElOR19BRFMQDkLlAQohY29tLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmVudW1zQhBBZEdyb3VwVHlwZVByb3Rv",
            "UAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRz",
            "L2dvb2dsZWFkcy92MS9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMu",
            "R29vZ2xlQWRzLlYxLkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjFc",
            "RW51bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTo6RW51bXNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.AdGroupTypeEnum), global::Google.Ads.GoogleAds.V1.Enums.AdGroupTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.AdGroupTypeEnum.Types.AdGroupType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Defines types of an ad group, specific to a particular campaign channel
  /// type. This type drives validations that restrict which entities can be
  /// added to the ad group.
  /// </summary>
  public sealed partial class AdGroupTypeEnum : pb::IMessage<AdGroupTypeEnum> {
    private static readonly pb::MessageParser<AdGroupTypeEnum> _parser = new pb::MessageParser<AdGroupTypeEnum>(() => new AdGroupTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.AdGroupTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupTypeEnum(AdGroupTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupTypeEnum Clone() {
      return new AdGroupTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupTypeEnum other) {
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
    public void MergeFrom(AdGroupTypeEnum other) {
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
    /// <summary>Container for nested types declared in the AdGroupTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum listing the possible types of an ad group.
      /// </summary>
      public enum AdGroupType {
        /// <summary>
        /// The type has not been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The default ad group type for Search campaigns.
        /// </summary>
        [pbr::OriginalName("SEARCH_STANDARD")] SearchStandard = 2,
        /// <summary>
        /// The default ad group type for Display campaigns.
        /// </summary>
        [pbr::OriginalName("DISPLAY_STANDARD")] DisplayStandard = 3,
        /// <summary>
        /// The ad group type for Shopping campaigns serving standard product ads.
        /// </summary>
        [pbr::OriginalName("SHOPPING_PRODUCT_ADS")] ShoppingProductAds = 4,
        /// <summary>
        /// The default ad group type for Hotel campaigns.
        /// </summary>
        [pbr::OriginalName("HOTEL_ADS")] HotelAds = 6,
        /// <summary>
        /// The type for ad groups in Smart Shopping campaigns.
        /// </summary>
        [pbr::OriginalName("SHOPPING_SMART_ADS")] ShoppingSmartAds = 7,
        /// <summary>
        /// Short unskippable in-stream video ads.
        /// </summary>
        [pbr::OriginalName("VIDEO_BUMPER")] VideoBumper = 8,
        /// <summary>
        /// TrueView (skippable) in-stream video ads.
        /// </summary>
        [pbr::OriginalName("VIDEO_TRUE_VIEW_IN_STREAM")] VideoTrueViewInStream = 9,
        /// <summary>
        /// TrueView in-display video ads.
        /// </summary>
        [pbr::OriginalName("VIDEO_TRUE_VIEW_IN_DISPLAY")] VideoTrueViewInDisplay = 10,
        /// <summary>
        /// Unskippable in-stream video ads.
        /// </summary>
        [pbr::OriginalName("VIDEO_NON_SKIPPABLE_IN_STREAM")] VideoNonSkippableInStream = 11,
        /// <summary>
        /// Outstream video ads.
        /// </summary>
        [pbr::OriginalName("VIDEO_OUTSTREAM")] VideoOutstream = 12,
        /// <summary>
        /// Ad group type for Dynamic Search Ads ad groups.
        /// </summary>
        [pbr::OriginalName("SEARCH_DYNAMIC_ADS")] SearchDynamicAds = 13,
        /// <summary>
        /// The type for ad groups in Shopping Comparison Listing campaigns.
        /// </summary>
        [pbr::OriginalName("SHOPPING_COMPARISON_LISTING_ADS")] ShoppingComparisonListingAds = 14,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code