using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HelloSign
{
    /// <summary>
    /// Information about a HelloSign Bulk Send Job object.
    /// </summary>
    public class BulkSendJobInfo
    {
        public string BulkSendJobId { get; set; }

        /// <summary>
        /// The total amount of SignatureRequests queued via this job.
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// True if you are the owner of this BulkSendJob.
        /// </summary>
        public bool IsCreator { get; set; }

        /// <summary>
        /// Time that the BulkSendJob was created.
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime CreatedAt { get; set; }
    }
}
