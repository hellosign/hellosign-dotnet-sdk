using System;
using System.Collections.Generic;
using RestSharp;

namespace HelloSign
{
    /// <summary>
    /// A Signature Request based on a Template.
    /// </summary>
    public class TemplateSignatureRequest : BaseSignatureRequest
    {
        public List<string> TemplateIds { get; private set; }
        public Dictionary<String, String> Ccs { get; set; }
        public bool ForceSignerRoles { get; set; } = false;
        //public Dictionary<String, String> CustomFields { get; set; }

        public TemplateSignatureRequest() : base()
        {
            TemplateIds = new List<string>();
            Ccs = new Dictionary<string,string>();
            //CustomFields = new Dictionary<string,string>();
        }

        /// <summary>
        /// Add a template to this request.
        /// You can call this multiple times to add multiple templates to a request,
        /// but templates must have compatible roles to be used together.
        /// </summary>
        /// <param name="templateId"></param>
        public void AddTemplate(string templateId)
        {
            TemplateIds.Add(templateId);
        }

        /// <summary>
        /// Convenience method for creating and adding a Signer.
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <param name="name"></param>
        /// <param name="order"></param>
        /// <param name="pin"></param>
        public void AddSigner(string role, string emailAddress, string name, int? order = null, string pin = null, string smsPhoneNumber = null)
        {
            Signers.Add(new Signer(emailAddress, name, order, pin, role, smsPhoneNumber));
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
        /// <param name="editor"></param>
        /// <param name="required"></param>
        public void AddCustomField(string key, string value, string editor = null, bool? required = null)
        {
            var customField = new CustomField();
            customField.Name = key;
            customField.Value = value;
            customField.Editor = editor;
            customField.Required = required;
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
