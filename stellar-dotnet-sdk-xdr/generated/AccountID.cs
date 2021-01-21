// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================
    //  typedef PublicKey AccountID;
    //  ===========================================================================
    public class AccountID
    {
        public PublicKey InnerValue { get; set; } = default(PublicKey);
        public AccountID() { }
        public AccountID(PublicKey value)
        {
            InnerValue = value;
        }
        public static void Encode(XdrDataOutputStream stream, AccountID encodedAccountID)
        {
            PublicKey.Encode(stream, encodedAccountID.InnerValue);
        }
        public static AccountID Decode(XdrDataInputStream stream)
        {
            AccountID decodedAccountID = new AccountID();
            decodedAccountID.InnerValue = PublicKey.Decode(stream);
            return decodedAccountID;
        }
    }
}
