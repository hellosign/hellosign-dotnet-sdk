namespace HelloSign
{
    /// <summary>
    /// Representation of a HelloSign Event.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Event timestamp (may become a DateTime in future releases).
        /// </summary>
        public int? EventTime { get; set; }
        /// <summary>
        /// Type of this event (see HelloSign API Documentation for a list of possible constants).
        /// </summary>
        public string EventType { get; set; }
        /// <summary>
        /// Cryptographic hash used to uniquely identify this event.
        /// </summary>
        public string EventHash { get; set; }
        public EventMetadata EventMetadata { get; set; }
        /// <summary>
        /// Related Signature Request, or null if not applicable.
        /// </summary>
        public SignatureRequest SignatureRequest { get; set; }
        /// <summary>
        /// Related Template, or null if not applicable.
        /// </summary>
        public Template Template { get; set; }
        /// <summary>
        /// Related Account, or null if not applicable.
        /// </summary>
        public Account Account { get; set; }
    }

    public class EventMetadata
    {
        public string EventMessage { get; set; }
        public string RelatedSignatureId { get; set; }
        public string ReportedForAccountId { get; set; }
        public string ReportedForAppId { get; set; }
    }
    
    
    /// <summary>
    /// Internal class used for parsing event hash verification info.
    /// </summary>
    public class EventHashInfo
    {
        public string EventTime { get; set; }
        public string EventType { get; set; }
    }
}
