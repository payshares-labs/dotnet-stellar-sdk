// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================
    //  struct StellarValue
    //  {
    //      Hash txSetHash;      // transaction set to apply to previous ledger
    //      TimePoint closeTime; // network close time
    //  
    //      // upgrades to apply to the previous ledger (usually empty)
    //      // this is a vector of encoded 'LedgerUpgrade' so that nodes can drop
    //      // unknown steps during consensus if needed.
    //      // see notes below on 'LedgerUpgrade' for more detail
    //      // max size is dictated by number of upgrade types (+ room for future)
    //      UpgradeType upgrades<6>;
    //  
    //      // reserved for future use
    //      union switch (StellarValueType v)
    //      {
    //      case STELLAR_VALUE_BASIC:
    //          void;
    //      case STELLAR_VALUE_SIGNED:
    //          LedgerCloseValueSignature lcValueSignature;
    //      }
    //      ext;
    //  };
    //  ===========================================================================
    public class StellarValue
    {
        public StellarValue() { }
        public Hash TxSetHash { get; set; }
        public TimePoint CloseTime { get; set; }
        public UpgradeType[] Upgrades { get; set; }
        public StellarValueExt Ext { get; set; }

        public static void Encode(XdrDataOutputStream stream, StellarValue encodedStellarValue)
        {
            Hash.Encode(stream, encodedStellarValue.TxSetHash);
            TimePoint.Encode(stream, encodedStellarValue.CloseTime);
            int upgradessize = encodedStellarValue.Upgrades.Length;
            stream.WriteInt(upgradessize);
            for (int i = 0; i < upgradessize; i++)
            {
                UpgradeType.Encode(stream, encodedStellarValue.Upgrades[i]);
            }
            StellarValueExt.Encode(stream, encodedStellarValue.Ext);
        }
        public static StellarValue Decode(XdrDataInputStream stream)
        {
            StellarValue decodedStellarValue = new StellarValue();
            decodedStellarValue.TxSetHash = Hash.Decode(stream);
            decodedStellarValue.CloseTime = TimePoint.Decode(stream);
            int upgradessize = stream.ReadInt();
            decodedStellarValue.Upgrades = new UpgradeType[upgradessize];
            for (int i = 0; i < upgradessize; i++)
            {
                decodedStellarValue.Upgrades[i] = UpgradeType.Decode(stream);
            }
            decodedStellarValue.Ext = StellarValueExt.Decode(stream);
            return decodedStellarValue;
        }

        public class StellarValueExt
        {
            public StellarValueExt() { }
            public StellarValueType Discriminant { get; set; } = new StellarValueType();
            public LedgerCloseValueSignature LcValueSignature { get; set; }
            public static void Encode(XdrDataOutputStream stream, StellarValueExt encodedStellarValueExt)
            {
                stream.WriteInt((int)encodedStellarValueExt.Discriminant.InnerValue);
                switch (encodedStellarValueExt.Discriminant.InnerValue)
                {
                    case StellarValueType.StellarValueTypeEnum.STELLAR_VALUE_BASIC:
                        break;
                    case StellarValueType.StellarValueTypeEnum.STELLAR_VALUE_SIGNED:
                        LedgerCloseValueSignature.Encode(stream, encodedStellarValueExt.LcValueSignature);
                        break;
                }
            }
            public static StellarValueExt Decode(XdrDataInputStream stream)
            {
                StellarValueExt decodedStellarValueExt = new StellarValueExt();
                StellarValueType discriminant = StellarValueType.Decode(stream);
                decodedStellarValueExt.Discriminant = discriminant;
                switch (decodedStellarValueExt.Discriminant.InnerValue)
                {
                    case StellarValueType.StellarValueTypeEnum.STELLAR_VALUE_BASIC:
                        break;
                    case StellarValueType.StellarValueTypeEnum.STELLAR_VALUE_SIGNED:
                        decodedStellarValueExt.LcValueSignature = LedgerCloseValueSignature.Decode(stream);
                        break;
                }
                return decodedStellarValueExt;
            }

        }
    }
}
