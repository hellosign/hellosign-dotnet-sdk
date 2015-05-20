namespace HelloSign
{
    /// <summary>
    /// Information provided for use in the HelloSign JavaScript library.
    /// </summary>
    public class Embedded
    {
        /// <summary>
        /// Signing URL to be used in the JavaScript SDK for Embedded Signing.
        /// </summary>
        public string SignUrl { get; set; }

        /// <summary>
        /// Editing URL to be used in the JavaScript SDK for Embedded Templates.
        /// </summary>
        public string EditUrl { get; set; }

        /// <summary>
        /// Unix timestamp when this URL will expire.
        /// </summary>
        public int ExpiresAt { get; set; }
    }
}
