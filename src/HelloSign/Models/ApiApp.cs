using System.Collections.Generic;
using System.Linq;

namespace HelloSign
{
    /// <summary>
    /// Representation of a HelloSign API App object.
    /// </summary>
    public class ApiApp
    {
        public string ClientId { get; set; }
        public string Name { get; set; }
        //private string Domain;
        public List<string> Domains { get; set; }
        public string CallbackUrl { get; set; }
        public bool? IsApproved { get; set; }
        public Account OwnerAccount { get; set; }
        public Oauth Oauth { get; set; }

        /*public void setDomain(string domain)
        {
            this.Domain = domain;
        }

        public void setDomain(List<string> domains)
        {
            this.Domains = domains;
        }

        public string getDomain()
        {
            return this.Domain ?? this.Domains.First();
        }

        public List<string> getAllDomains()
        {
            return this.Domains;
        }*/
    }
}
