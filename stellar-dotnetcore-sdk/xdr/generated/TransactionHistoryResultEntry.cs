// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnetcore_sdk.xdr {

// === xdr source ============================================================

//  struct TransactionHistoryResultEntry
//  {
//      uint32 ledgerSeq;
//      TransactionResultSet txResultSet;
//  
//      // reserved for future use
//      union switch (int v)
//      {
//      case 0:
//          void;
//      }
//      ext;
//  };

//  ===========================================================================
public class TransactionHistoryResultEntry  {
  public TransactionHistoryResultEntry () {}
  public Uint32 LedgerSeq {get; set;}
  public TransactionResultSet TxResultSet {get; set;}
  public TransactionHistoryResultEntryExt Ext {get; set;}

  public static void Encode(IByteWriter stream, TransactionHistoryResultEntry encodedTransactionHistoryResultEntry) {
    Uint32.Encode(stream, encodedTransactionHistoryResultEntry.LedgerSeq);
    TransactionResultSet.Encode(stream, encodedTransactionHistoryResultEntry.TxResultSet);
    TransactionHistoryResultEntryExt.Encode(stream, encodedTransactionHistoryResultEntry.Ext);
  }
  public static TransactionHistoryResultEntry Decode(IByteReader stream) {
    TransactionHistoryResultEntry decodedTransactionHistoryResultEntry = new TransactionHistoryResultEntry();
    decodedTransactionHistoryResultEntry.LedgerSeq = Uint32.Decode(stream);
    decodedTransactionHistoryResultEntry.TxResultSet = TransactionResultSet.Decode(stream);
    decodedTransactionHistoryResultEntry.Ext = TransactionHistoryResultEntryExt.Decode(stream);
    return decodedTransactionHistoryResultEntry;
  }

  public class TransactionHistoryResultEntryExt {
    public TransactionHistoryResultEntryExt () {}

    public int Discriminant { get; set; } = new int();

    public static void Encode(IByteWriter stream, TransactionHistoryResultEntryExt encodedTransactionHistoryResultEntryExt) {
    XdrEncoding.EncodeInt32((int)encodedTransactionHistoryResultEntryExt.Discriminant, stream);
    switch (encodedTransactionHistoryResultEntryExt.Discriminant) {
    case 0:
    break;
    }
    }
    public static TransactionHistoryResultEntryExt Decode(IByteReader stream) {
    TransactionHistoryResultEntryExt decodedTransactionHistoryResultEntryExt = new TransactionHistoryResultEntryExt();
    int discriminant =  XdrEncoding.DecodeInt32(stream);
    decodedTransactionHistoryResultEntryExt.Discriminant = discriminant;
    switch (decodedTransactionHistoryResultEntryExt.Discriminant) {
    case 0:
    break;
    }
      return decodedTransactionHistoryResultEntryExt;
    }

  }
}
}
