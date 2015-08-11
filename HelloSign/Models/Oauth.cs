using System.Collections.Generic;

namespace HelloSign
{
    /// <summary>
    /// An Oauth section of an ApiApp object.
    /// </summary>
    public class Oauth
    {
        public string CallbackUrl { get; set; }
        public string Secret { get; set; }
        public List<string> Scopes { get; set; }
    }
}
