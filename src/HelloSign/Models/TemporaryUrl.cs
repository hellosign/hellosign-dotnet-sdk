namespace HelloSign
{
    /// <summary>
    /// Information about a temporary URL (a public URL with an expiration date).
    /// </summary>
    public class TemporaryUrl
    {
        /// <summary>
        /// Unix timestamp when this URL will expire (may become a DateTime in future releases).
        /// </summary>
        public int ExpiresAt { get; set; }
        /// <summary>
        /// The URL as a string.
        /// </summary>
        public string FileUrl { get; set; }
    }
}
