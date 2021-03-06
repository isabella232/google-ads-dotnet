// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/common/click_location.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/common/click_location.proto</summary>
  public static partial class ClickLocationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/common/click_location.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClickLocationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9jb21tb24vY2xpY2tfbG9jYXRp",
            "b24ucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LmNvbW1vbhoeZ29v",
            "Z2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGhxnb29nbGUvYXBpL2Fubm90",
            "YXRpb25zLnByb3RvIvoBCg1DbGlja0xvY2F0aW9uEioKBGNpdHkYASABKAsy",
            "HC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUSLQoHY291bnRyeRgCIAEo",
            "CzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZRIrCgVtZXRybxgDIAEo",
            "CzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZRIzCg1tb3N0X3NwZWNp",
            "ZmljGAQgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlEiwKBnJl",
            "Z2lvbhgFIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZULtAQoi",
            "Y29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LmNvbW1vbkISQ2xpY2tMb2Nh",
            "dGlvblByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvYWRzL2dvb2dsZWFkcy92NC9jb21tb247Y29tbW9uogIDR0FBqgIe",
            "R29vZ2xlLkFkcy5Hb29nbGVBZHMuVjQuQ29tbW9uygIeR29vZ2xlXEFkc1xH",
            "b29nbGVBZHNcVjRcQ29tbW9u6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6",
            "VjQ6OkNvbW1vbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Common.ClickLocation), global::Google.Ads.GoogleAds.V4.Common.ClickLocation.Parser, new[]{ "City", "Country", "Metro", "MostSpecific", "Region" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Location criteria associated with a click.
  /// </summary>
  public sealed partial class ClickLocation : pb::IMessage<ClickLocation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClickLocation> _parser = new pb::MessageParser<ClickLocation>(() => new ClickLocation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClickLocation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Common.ClickLocationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClickLocation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClickLocation(ClickLocation other) : this() {
      City = other.City;
      Country = other.Country;
      Metro = other.Metro;
      MostSpecific = other.MostSpecific;
      Region = other.Region;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClickLocation Clone() {
      return new ClickLocation(this);
    }

    /// <summary>Field number for the "city" field.</summary>
    public const int CityFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_city_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string city_;
    /// <summary>
    /// The city location criterion associated with the impression.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string City {
      get { return city_; }
      set {
        city_ = value;
      }
    }


    /// <summary>Field number for the "country" field.</summary>
    public const int CountryFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_country_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string country_;
    /// <summary>
    /// The country location criterion associated with the impression.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Country {
      get { return country_; }
      set {
        country_ = value;
      }
    }


    /// <summary>Field number for the "metro" field.</summary>
    public const int MetroFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_metro_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string metro_;
    /// <summary>
    /// The metro location criterion associated with the impression.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Metro {
      get { return metro_; }
      set {
        metro_ = value;
      }
    }


    /// <summary>Field number for the "most_specific" field.</summary>
    public const int MostSpecificFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_mostSpecific_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string mostSpecific_;
    /// <summary>
    /// The most specific location criterion associated with the impression.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MostSpecific {
      get { return mostSpecific_; }
      set {
        mostSpecific_ = value;
      }
    }


    /// <summary>Field number for the "region" field.</summary>
    public const int RegionFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_region_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string region_;
    /// <summary>
    /// The region location criterion associated with the impression.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Region {
      get { return region_; }
      set {
        region_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClickLocation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClickLocation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (City != other.City) return false;
      if (Country != other.Country) return false;
      if (Metro != other.Metro) return false;
      if (MostSpecific != other.MostSpecific) return false;
      if (Region != other.Region) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (city_ != null) hash ^= City.GetHashCode();
      if (country_ != null) hash ^= Country.GetHashCode();
      if (metro_ != null) hash ^= Metro.GetHashCode();
      if (mostSpecific_ != null) hash ^= MostSpecific.GetHashCode();
      if (region_ != null) hash ^= Region.GetHashCode();
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
      if (city_ != null) {
        _single_city_codec.WriteTagAndValue(output, City);
      }
      if (country_ != null) {
        _single_country_codec.WriteTagAndValue(output, Country);
      }
      if (metro_ != null) {
        _single_metro_codec.WriteTagAndValue(output, Metro);
      }
      if (mostSpecific_ != null) {
        _single_mostSpecific_codec.WriteTagAndValue(output, MostSpecific);
      }
      if (region_ != null) {
        _single_region_codec.WriteTagAndValue(output, Region);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (city_ != null) {
        _single_city_codec.WriteTagAndValue(ref output, City);
      }
      if (country_ != null) {
        _single_country_codec.WriteTagAndValue(ref output, Country);
      }
      if (metro_ != null) {
        _single_metro_codec.WriteTagAndValue(ref output, Metro);
      }
      if (mostSpecific_ != null) {
        _single_mostSpecific_codec.WriteTagAndValue(ref output, MostSpecific);
      }
      if (region_ != null) {
        _single_region_codec.WriteTagAndValue(ref output, Region);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (city_ != null) {
        size += _single_city_codec.CalculateSizeWithTag(City);
      }
      if (country_ != null) {
        size += _single_country_codec.CalculateSizeWithTag(Country);
      }
      if (metro_ != null) {
        size += _single_metro_codec.CalculateSizeWithTag(Metro);
      }
      if (mostSpecific_ != null) {
        size += _single_mostSpecific_codec.CalculateSizeWithTag(MostSpecific);
      }
      if (region_ != null) {
        size += _single_region_codec.CalculateSizeWithTag(Region);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClickLocation other) {
      if (other == null) {
        return;
      }
      if (other.city_ != null) {
        if (city_ == null || other.City != "") {
          City = other.City;
        }
      }
      if (other.country_ != null) {
        if (country_ == null || other.Country != "") {
          Country = other.Country;
        }
      }
      if (other.metro_ != null) {
        if (metro_ == null || other.Metro != "") {
          Metro = other.Metro;
        }
      }
      if (other.mostSpecific_ != null) {
        if (mostSpecific_ == null || other.MostSpecific != "") {
          MostSpecific = other.MostSpecific;
        }
      }
      if (other.region_ != null) {
        if (region_ == null || other.Region != "") {
          Region = other.Region;
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
            string value = _single_city_codec.Read(input);
            if (city_ == null || value != "") {
              City = value;
            }
            break;
          }
          case 18: {
            string value = _single_country_codec.Read(input);
            if (country_ == null || value != "") {
              Country = value;
            }
            break;
          }
          case 26: {
            string value = _single_metro_codec.Read(input);
            if (metro_ == null || value != "") {
              Metro = value;
            }
            break;
          }
          case 34: {
            string value = _single_mostSpecific_codec.Read(input);
            if (mostSpecific_ == null || value != "") {
              MostSpecific = value;
            }
            break;
          }
          case 42: {
            string value = _single_region_codec.Read(input);
            if (region_ == null || value != "") {
              Region = value;
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
            string value = _single_city_codec.Read(ref input);
            if (city_ == null || value != "") {
              City = value;
            }
            break;
          }
          case 18: {
            string value = _single_country_codec.Read(ref input);
            if (country_ == null || value != "") {
              Country = value;
            }
            break;
          }
          case 26: {
            string value = _single_metro_codec.Read(ref input);
            if (metro_ == null || value != "") {
              Metro = value;
            }
            break;
          }
          case 34: {
            string value = _single_mostSpecific_codec.Read(ref input);
            if (mostSpecific_ == null || value != "") {
              MostSpecific = value;
            }
            break;
          }
          case 42: {
            string value = _single_region_codec.Read(ref input);
            if (region_ == null || value != "") {
              Region = value;
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
