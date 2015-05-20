using System;
using System.Collections.Generic;

namespace HelloSign
{
    /// <summary>
    /// Representation of a HelloSign Template object.
    /// </summary>
    public class Template
    {
        public string TemplateId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public List<SignerRole> SignerRoles { get; set; }
        public List<SignerRole> CcRoles { get; set; }
        //public List<Document> Documents { get; set; }
        public List<Account> Accounts { get; set; }

        public Template()
        {
            SignerRoles = new List<SignerRole>();
            CcRoles = new List<SignerRole>();
            //Documents = new List<Document>();
            Accounts = new List<Account>();
        }
    }
}
