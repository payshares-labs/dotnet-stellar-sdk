// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================
    //  enum ClawbackResultCode
    //  {
    //      // codes considered as "success" for the operation
    //      CLAWBACK_SUCCESS = 0,
    //  
    //      // codes considered as "failure" for the operation
    //      CLAWBACK_MALFORMED = -1,
    //      CLAWBACK_NOT_CLAWBACK_ENABLED = -2,
    //      CLAWBACK_NO_TRUST = -3,
    //      CLAWBACK_UNDERFUNDED = -4
    //  };
    //  ===========================================================================
    public class ClawbackResultCode
    {
        public enum ClawbackResultCodeEnum
        {
            CLAWBACK_SUCCESS = 0,
            CLAWBACK_MALFORMED = -1,
            CLAWBACK_NOT_CLAWBACK_ENABLED = -2,
            CLAWBACK_NO_TRUST = -3,
            CLAWBACK_UNDERFUNDED = -4,
        }
        public ClawbackResultCodeEnum InnerValue { get; set; } = default(ClawbackResultCodeEnum);
        public static ClawbackResultCode Create(ClawbackResultCodeEnum v)
        {
            return new ClawbackResultCode
            {
                InnerValue = v
            };
        }
        public static ClawbackResultCode Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(ClawbackResultCodeEnum.CLAWBACK_SUCCESS);
                case -1: return Create(ClawbackResultCodeEnum.CLAWBACK_MALFORMED);
                case -2: return Create(ClawbackResultCodeEnum.CLAWBACK_NOT_CLAWBACK_ENABLED);
                case -3: return Create(ClawbackResultCodeEnum.CLAWBACK_NO_TRUST);
                case -4: return Create(ClawbackResultCodeEnum.CLAWBACK_UNDERFUNDED);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }
        public static void Encode(XdrDataOutputStream stream, ClawbackResultCode value)
        {
            stream.WriteInt((int)value.InnerValue);
        }
    }
}
