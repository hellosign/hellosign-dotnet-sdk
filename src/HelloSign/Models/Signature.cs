using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
        public string SignerRole { get; set; }
        public int? Order { get; set; }
        public string StatusCode { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime SignedAt { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime LastViewedAt { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime LastRemindedAt { get; set; }

        public bool HasPin { get; set; }
        public string DeclineReason { get; set; }
        public string Error { get; set; }
        public string ReassignedBy { get; set; }
        public string ReassignmentReason { get; set; }
    }
}
