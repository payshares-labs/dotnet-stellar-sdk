// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  struct TransactionHistoryEntry
    //  {
    //      uint32 ledgerSeq;
    //      TransactionSet txSet;
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
    public class TransactionHistoryEntry
    {
        public TransactionHistoryEntry() { }
        public Uint32 LedgerSeq { get; set; }
        public TransactionSet TxSet { get; set; }
        public TransactionHistoryEntryExt Ext { get; set; }

        public static void Encode(XdrDataOutputStream stream, TransactionHistoryEntry encodedTransactionHistoryEntry)
        {
            Uint32.Encode(stream, encodedTransactionHistoryEntry.LedgerSeq);
            TransactionSet.Encode(stream, encodedTransactionHistoryEntry.TxSet);
            TransactionHistoryEntryExt.Encode(stream, encodedTransactionHistoryEntry.Ext);
        }
        public static TransactionHistoryEntry Decode(XdrDataInputStream stream)
        {
            TransactionHistoryEntry decodedTransactionHistoryEntry = new TransactionHistoryEntry();
            decodedTransactionHistoryEntry.LedgerSeq = Uint32.Decode(stream);
            decodedTransactionHistoryEntry.TxSet = TransactionSet.Decode(stream);
            decodedTransactionHistoryEntry.Ext = TransactionHistoryEntryExt.Decode(stream);
            return decodedTransactionHistoryEntry;
        }

        public class TransactionHistoryEntryExt
        {
            public TransactionHistoryEntryExt() { }

            public int Discriminant { get; set; } = new int();

            public static void Encode(XdrDataOutputStream stream, TransactionHistoryEntryExt encodedTransactionHistoryEntryExt)
            {
                stream.WriteInt((int)encodedTransactionHistoryEntryExt.Discriminant);
                switch (encodedTransactionHistoryEntryExt.Discriminant)
                {
                    case 0:
                        break;
                }
            }
            public static TransactionHistoryEntryExt Decode(XdrDataInputStream stream)
            {
                TransactionHistoryEntryExt decodedTransactionHistoryEntryExt = new TransactionHistoryEntryExt();
                int discriminant = stream.ReadInt();
                decodedTransactionHistoryEntryExt.Discriminant = discriminant;
                switch (decodedTransactionHistoryEntryExt.Discriminant)
                {
                    case 0:
                        break;
                }
                return decodedTransactionHistoryEntryExt;
            }

        }
    }
}