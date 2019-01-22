namespace HelloSign
{
    /// <summary>
    /// Information provided for use in the HelloSign JavaScript library.
    /// </summary>
    public class EmbeddedTemplate : Embedded
    {
        /// <summary>
        /// ID of the Template.
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// Editing URL to be used in the JavaScript SDK for Embedded Templates.
        /// </summary>
        public string EditUrl { get; set; }
    }
}
