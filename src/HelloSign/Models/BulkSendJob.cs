using System.Collections.Generic;

namespace HelloSign
{
    /// <summary>
    /// Representation of a HelloSign Bulk Send Job object with a list of its
    /// Signature Requests present.
    /// </summary>
    public class BulkSendJob : ObjectList<SignatureRequest>
    {
        /// <summary>
        /// The page of Signature Requests for this Bulk Send Job that was fetched.
        /// See NumPages/NumResults/Page/PageSize properties for pagination details.
        /// </summary>
        /// <value></value>
        public new List<SignatureRequest> Items { get; set; }

        /// <summary>
        /// Information about this Bulk Send Job
        /// </summary>
        /// <value></value>
        public BulkSendJobInfo JobInfo { get; set; }
    }
}
