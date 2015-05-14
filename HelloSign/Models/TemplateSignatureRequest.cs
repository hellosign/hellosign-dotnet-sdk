using System;
using System.Collections.Generic;
using RestSharp;

namespace HelloSign
{
    /// <summary>
    /// Signature Request based on a Template.
    /// </summary>
    public class TemplateSignatureRequest : BaseSignatureRequest
    {
        public string TemplateId { get; set; }
        public Dictionary<String, String> Ccs { get; set; }
        public Dictionary<String, String> CustomFields { get; set; }

        public TemplateSignatureRequest() : base()
        {
            Ccs = new Dictionary<string,string>();
            CustomFields = new Dictionary<string,string>();
        }

        /// <summary>
        /// Convenience method for creating and adding a Signer.
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <param name="name"></param>
        /// <param name="order"></param>
        /// <param name="pin"></param>
        public void AddSigner(string role, string emailAddress, string name, int? order = null, string pin = null)
        {
            Signers.Add(new Signer(emailAddress, name, order, pin, role));
        }

        /// <summary>
        /// Convenience method for adding a CC email address.
        /// </summary>
        /// <param name="emailAddress"></param>
        public void AddCc(string role, string emailAddress)
        {
            Ccs.Add(role, emailAddress);
        }
    }
}
