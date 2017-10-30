// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnetcore_sdk.xdr {

// === xdr source ============================================================

//  typedef LedgerEntryChange LedgerEntryChanges<>;

//  ===========================================================================
public class LedgerEntryChanges  {
  public LedgerEntryChange[] InnerValue {get; set;} = default(LedgerEntryChange[]);

  public LedgerEntryChanges() {}

  public LedgerEntryChanges(LedgerEntryChange[] value)
  {
    InnerValue = value;
  }

  public static void Encode(XdrDataOutputStream stream, LedgerEntryChanges  encodedLedgerEntryChanges) {
  int LedgerEntryChangessize = encodedLedgerEntryChanges.InnerValue.Length;
  stream.WriteInt(LedgerEntryChangessize);
  for (int i = 0; i < LedgerEntryChangessize; i++) {
    LedgerEntryChange.Encode(stream, encodedLedgerEntryChanges.InnerValue[i]);
  }
  }
  public static LedgerEntryChanges Decode(XdrDataInputStream stream) {
    LedgerEntryChanges decodedLedgerEntryChanges = new LedgerEntryChanges();
  int LedgerEntryChangessize = stream.ReadInt();
  decodedLedgerEntryChanges.InnerValue = new LedgerEntryChange[LedgerEntryChangessize];
  for (int i = 0; i < LedgerEntryChangessize; i++) {
    decodedLedgerEntryChanges.InnerValue[i] = LedgerEntryChange.Decode(stream);
  }
    return decodedLedgerEntryChanges;
  }
}
}
