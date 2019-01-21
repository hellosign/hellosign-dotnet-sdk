using Newtonsoft.Json;

namespace HelloSign
{
    /// <summary>
    /// Signing Options for a Signature Request
    /// </summary>
    public class SigningOptions
    {
        [JsonProperty("draw")]
        public bool Draw { get; set; } = false;
        [JsonProperty("type")]
        public bool Type { get; set; } = false;
        [JsonProperty("upload")]
        public bool Upload { get; set; } = false;
        [JsonProperty("phone")]
        public bool Phone { get; set; } = false;
        [JsonProperty("default")]
        public string Default { get; set; } = "draw";
    }
}
