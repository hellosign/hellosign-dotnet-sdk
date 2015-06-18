namespace HelloSign
{
    /// <summary>
    /// A signer's response to a single field in a Signature Request.
    /// </summary>
    public class FieldResponse
    {
        public string ApiId { get; set; }
        public string SignatureId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; } // TODO: Change to an enum, custom setter
    }
}
