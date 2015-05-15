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
        //public Dictionary<String, String> CustomFields { get; set; }

        public TemplateSignatureRequest() : base()
        {
            Ccs = new Dictionary<string,string>();
            //CustomFields = new Dictionary<string,string>();
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

        /// <summary>
        /// Convenience method for adding a custom field.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void AddCustomField(string key, string value)
        {
            var customField = new CustomField();
            customField.Name = key;
            customField.Value = value;
            CustomFields.Add(customField);
        }

        /// <summary>
        /// Convenience method for adding a boolean custom field.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void AddCustomField(string key, bool value)
        {
            var customField = new CustomField();
            customField.Name = key;
            customField.Value = value ? "true" : "false";
            CustomFields.Add(customField);
        }
    }
}
