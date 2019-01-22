using System.Collections.Generic;

namespace HelloSign
{
    /// <summary>
    /// Representation of a HelloSign API App object.
    /// </summary>
    public class ApiApp
    {
        public string ClientId { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public string CallbackUrl { get; set; }
        public bool? IsApproved { get; set; }
        public Account OwnerAccount { get; set; }
        public Oauth Oauth { get; set; }
    }
}
