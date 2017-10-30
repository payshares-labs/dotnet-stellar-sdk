// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnetcore_sdk.xdr {

// === xdr source ============================================================

//  enum OfferEntryFlags
//  {
//      // issuer has authorized account to perform transactions with its credit
//      PASSIVE_FLAG = 1
//  };

//  ===========================================================================
public class OfferEntryFlags  {
  public enum OfferEntryFlagsEnum {
  PASSIVE_FLAG = 1,
  }
  public OfferEntryFlagsEnum InnerValue {get; set;} = default(OfferEntryFlagsEnum);

  public static OfferEntryFlags Create(OfferEntryFlagsEnum v)
  {
    return new OfferEntryFlags {
      InnerValue = v
    };
  }

  public static OfferEntryFlags Decode(XdrDataInputStream stream) {
    int value = stream.ReadInt();
    switch (value) {
      case 1: return Create(OfferEntryFlagsEnum.PASSIVE_FLAG);
      default:
        throw new Exception("Unknown enum value: " + value);
    }
  }

  public static void Encode(XdrDataOutputStream stream, OfferEntryFlags value) {
    stream.WriteInt((int)value.InnerValue);
  }
}
}
