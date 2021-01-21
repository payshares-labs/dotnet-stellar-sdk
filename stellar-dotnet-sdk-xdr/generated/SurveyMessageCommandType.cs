// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================
    //  enum SurveyMessageCommandType
    //  {
    //      SURVEY_TOPOLOGY = 0
    //  };
    //  ===========================================================================
    public class SurveyMessageCommandType
    {
        public enum SurveyMessageCommandTypeEnum
        {
            SURVEY_TOPOLOGY = 0,
        }
        public SurveyMessageCommandTypeEnum InnerValue { get; set; } = default(SurveyMessageCommandTypeEnum);
        public static SurveyMessageCommandType Create(SurveyMessageCommandTypeEnum v)
        {
            return new SurveyMessageCommandType
            {
                InnerValue = v
            };
        }
        public static SurveyMessageCommandType Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(SurveyMessageCommandTypeEnum.SURVEY_TOPOLOGY);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }
        public static void Encode(XdrDataOutputStream stream, SurveyMessageCommandType value)
        {
            stream.WriteInt((int)value.InnerValue);
        }
    }
}
