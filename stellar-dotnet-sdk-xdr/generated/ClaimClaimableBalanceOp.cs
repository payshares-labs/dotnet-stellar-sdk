// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================
    //  struct ClaimClaimableBalanceOp
    //  {
    //      ClaimableBalanceID balanceID;
    //  };
    //  ===========================================================================
    public class ClaimClaimableBalanceOp
    {
        public ClaimClaimableBalanceOp() { }
        public ClaimableBalanceID BalanceID { get; set; }

        public static void Encode(XdrDataOutputStream stream, ClaimClaimableBalanceOp encodedClaimClaimableBalanceOp)
        {
            ClaimableBalanceID.Encode(stream, encodedClaimClaimableBalanceOp.BalanceID);
        }
        public static ClaimClaimableBalanceOp Decode(XdrDataInputStream stream)
        {
            ClaimClaimableBalanceOp decodedClaimClaimableBalanceOp = new ClaimClaimableBalanceOp();
            decodedClaimClaimableBalanceOp.BalanceID = ClaimableBalanceID.Decode(stream);
            return decodedClaimClaimableBalanceOp;
        }
    }
}
