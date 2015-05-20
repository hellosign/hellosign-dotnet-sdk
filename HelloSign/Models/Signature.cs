using System;
using System.Collections.Generic;

namespace HelloSign
{
    /// <summary>
    /// Information corresponding to a signer on an existing Signature Request
    /// and their activity.
    /// </summary>
    public class Signature
    {
        public string SignatureId { get; set; }
        public string SignerEmailAddress { get; set; }
        public string SignerName { get; set; }
        public int? Order { get; set; }
        public string StatusCode { get; set; }
        public DateTime SignedAt { get; set; }
        public DateTime LastViewedAt { get; set; }
        public DateTime LastRemindedAt { get; set; }
        public bool HasPin { get; set; }
    }
}
