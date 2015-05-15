using System.Collections.Generic;

namespace HelloSign
{
    public class Signature
    {
        public string SignatureId { get; set; }
        public string SignerEmailAddress { get; set; }
        public string SignerName { get; set; }
        public int? Order { get; set; }
        public string StatusCode { get; set; }
        //SignedAt
        //LastViewedAt
        //LastRemindedAt
        public bool HasPin { get; set; }
    }
}
