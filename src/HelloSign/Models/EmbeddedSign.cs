namespace HelloSign
{
    /// <summary>
    /// Information provided for use in the HelloSign JavaScript library.
    /// </summary>
    public class EmbeddedSign : Embedded
    {
        /// <summary>
        /// Signing URL to be used in the JavaScript SDK for Embedded Signing.
        /// </summary>
        public string SignUrl { get; set; }
    }
}
