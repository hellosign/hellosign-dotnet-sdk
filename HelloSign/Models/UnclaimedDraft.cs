namespace HelloSign
{
    /// <summary>
    /// </summary>
    public class UnclaimedDraft
    {
        public enum Type
        {
            SendDocument,
            RequestSignature
        }
        
        public string ClaimUrl { get; set; }
        public string SigningRedirectUrl { get; set; }
        public string RequestingRedirectUrl { get; set; }
        public int? ExpiresAt { get; set; }
        public bool? TestMode { get; set; }
        public string SignatureRequestId { get; set; }
    }
}
