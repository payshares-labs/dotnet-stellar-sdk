// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================
    //  union ClaimPredicate switch (ClaimPredicateType type)
    //  {
    //  case CLAIM_PREDICATE_UNCONDITIONAL:
    //      void;
    //  case CLAIM_PREDICATE_AND:
    //      ClaimPredicate andPredicates<2>;
    //  case CLAIM_PREDICATE_OR:
    //      ClaimPredicate orPredicates<2>;
    //  case CLAIM_PREDICATE_NOT:
    //      ClaimPredicate* notPredicate;
    //  case CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME:
    //      int64 absBefore; // Predicate will be true if closeTime < absBefore
    //  case CLAIM_PREDICATE_BEFORE_RELATIVE_TIME:
    //      int64 relBefore; // Seconds since closeTime of the ledger in which the
    //                       // ClaimableBalanceEntry was created
    //  };
    //  ===========================================================================
    public class ClaimPredicate
    {
        public ClaimPredicate() { }
        public ClaimPredicateType Discriminant { get; set; } = new ClaimPredicateType();
        public ClaimPredicate[] AndPredicates { get; set; }
        public ClaimPredicate[] OrPredicates { get; set; }
        public ClaimPredicate NotPredicate { get; set; }
        public Int64 AbsBefore { get; set; }
        public Int64 RelBefore { get; set; }
        public static void Encode(XdrDataOutputStream stream, ClaimPredicate encodedClaimPredicate)
        {
            stream.WriteInt((int)encodedClaimPredicate.Discriminant.InnerValue);
            switch (encodedClaimPredicate.Discriminant.InnerValue)
            {
                case ClaimPredicateType.ClaimPredicateTypeEnum.CLAIM_PREDICATE_UNCONDITIONAL:
                    break;
                case ClaimPredicateType.ClaimPredicateTypeEnum.CLAIM_PREDICATE_AND:
                    int andPredicatessize = encodedClaimPredicate.AndPredicates.Length;
                    stream.WriteInt(andPredicatessize);
                    for (int i = 0; i < andPredicatessize; i++)
                    {
                        ClaimPredicate.Encode(stream, encodedClaimPredicate.AndPredicates[i]);
                    }
                    break;
                case ClaimPredicateType.ClaimPredicateTypeEnum.CLAIM_PREDICATE_OR:
                    int orPredicatessize = encodedClaimPredicate.OrPredicates.Length;
                    stream.WriteInt(orPredicatessize);
                    for (int i = 0; i < orPredicatessize; i++)
                    {
                        ClaimPredicate.Encode(stream, encodedClaimPredicate.OrPredicates[i]);
                    }
                    break;
                case ClaimPredicateType.ClaimPredicateTypeEnum.CLAIM_PREDICATE_NOT:
                    if (encodedClaimPredicate.NotPredicate != null)
                    {
                        stream.WriteInt(1);
                        ClaimPredicate.Encode(stream, encodedClaimPredicate.NotPredicate);
                    }
                    else
                    {
                        stream.WriteInt(0);
                    }
                    break;
                case ClaimPredicateType.ClaimPredicateTypeEnum.CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME:
                    Int64.Encode(stream, encodedClaimPredicate.AbsBefore);
                    break;
                case ClaimPredicateType.ClaimPredicateTypeEnum.CLAIM_PREDICATE_BEFORE_RELATIVE_TIME:
                    Int64.Encode(stream, encodedClaimPredicate.RelBefore);
                    break;
            }
        }
        public static ClaimPredicate Decode(XdrDataInputStream stream)
        {
            ClaimPredicate decodedClaimPredicate = new ClaimPredicate();
            ClaimPredicateType discriminant = ClaimPredicateType.Decode(stream);
            decodedClaimPredicate.Discriminant = discriminant;
            switch (decodedClaimPredicate.Discriminant.InnerValue)
            {
                case ClaimPredicateType.ClaimPredicateTypeEnum.CLAIM_PREDICATE_UNCONDITIONAL:
                    break;
                case ClaimPredicateType.ClaimPredicateTypeEnum.CLAIM_PREDICATE_AND:
                    int andPredicatessize = stream.ReadInt();
                    decodedClaimPredicate.AndPredicates = new ClaimPredicate[andPredicatessize];
                    for (int i = 0; i < andPredicatessize; i++)
                    {
                        decodedClaimPredicate.AndPredicates[i] = ClaimPredicate.Decode(stream);
                    }
                    break;
                case ClaimPredicateType.ClaimPredicateTypeEnum.CLAIM_PREDICATE_OR:
                    int orPredicatessize = stream.ReadInt();
                    decodedClaimPredicate.OrPredicates = new ClaimPredicate[orPredicatessize];
                    for (int i = 0; i < orPredicatessize; i++)
                    {
                        decodedClaimPredicate.OrPredicates[i] = ClaimPredicate.Decode(stream);
                    }
                    break;
                case ClaimPredicateType.ClaimPredicateTypeEnum.CLAIM_PREDICATE_NOT:
                    int NotPredicatePresent = stream.ReadInt();
                    if (NotPredicatePresent != 0)
                    {
                        decodedClaimPredicate.NotPredicate = ClaimPredicate.Decode(stream);
                    }
                    break;
                case ClaimPredicateType.ClaimPredicateTypeEnum.CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME:
                    decodedClaimPredicate.AbsBefore = Int64.Decode(stream);
                    break;
                case ClaimPredicateType.ClaimPredicateTypeEnum.CLAIM_PREDICATE_BEFORE_RELATIVE_TIME:
                    decodedClaimPredicate.RelBefore = Int64.Decode(stream);
                    break;
            }
            return decodedClaimPredicate;
        }
    }
}
