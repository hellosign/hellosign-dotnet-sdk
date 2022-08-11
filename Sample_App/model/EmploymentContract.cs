using System;
using System.Collections.Generic;
using Org.HelloSign.Model;
using System.Linq;

namespace Sample_App.model
{
    public class EmploymentContract: BaseContract
    {
        private const string REQUEST_TITLE = "Agreement of Employment";
        private const string LEGAL_EMAIL = "lawyer@legal.com";
        public string projectName { get; set; }
        public string requestMessage { get; set; }
        public List<string> templateIds { get; set; }
        public EmploymentContract(List<User> signers): base(signers)
        {
        }

        public override string GetMessage()
        {
            return this.requestMessage;
        }

        public override Email GetSentEmail()
        {
            var email = new Email();
            email.fromAddress = "donotreply@test.com";
            email.toAddress = "engineers@test.com";
            email.subject = "Employment Contract sent to " + String.Join(", ", requestedSigners.Select(a => a.name));
            email.message = "Employment Contract " + contractId + " sent to " + String.Join(", ", requestedSigners.Select(a => a.name + " (" + a.emailAddress + ")"));
            return email;
        }

        public override SignatureRequestSendWithTemplateRequest GetSignatureRequest()
        {
            var signers = requestedSigners.Select(signer => new SubSignatureRequestTemplateSigner(signer.role,signer.name, signer.emailAddress)).ToList();
            var request = new SignatureRequestSendWithTemplateRequest(templateIds: templateIds, signers: signers);
            request.AllowDecline = true;
            request.Message = GetMessage();
            request.Subject = GetSubject();
            request.Title = GetTitle();
            return request;
        }

        public override string GetSubject()
        {
            return "Your Employment Offer from Example Inc.";
        }

        public override string GetTitle()
        {
            return "Employment Offer from Example Inc.";
        }

        public override bool HasTemplate()
        {
            return true;
        }
    }
}
