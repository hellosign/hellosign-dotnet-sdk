using System.Collections.Generic;

namespace HelloSign
{
    public class Signature
    {
        string SignatureId { get; set; }
        string SignerEmailAddress { get; set; }
        string SignerName { get; set; }
        int? Order { get; set; }
        string StatusCode { get; set; }
        //SignedAt
        //LastViewedAt
        //LastRemindedAt
        bool HasPin { get; set; }
    }
}
