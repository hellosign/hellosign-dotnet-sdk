using System;
using Org.HelloSign.Model;
using System.Linq;
using System.Collections.Generic;
using Sample_App.client;

namespace Sample_App.model
{
    public class NDAContract : BaseContract
    {
        private const string REQUEST_TITLE = "Non-Disclosure Agreement";
        private const string LEGAL_EMAIL = "lawyer@legal.com";
        private List<string> FILES =  new() { "nda_contract.pdf" };
        public string projectName { get; set; }
        public string requestMessage { get; set; }
        public NDAContract(string projectName, List<User> requestedSigners) : base(requestedSigners)
        {
            this.projectName = projectName;
        }

        public NDAContract(List<User> requestedSigners) : base(requestedSigners)
        {
        }

        public override string GetMessage()
        {
            return requestMessage;
        }

        public override string GetSubject()
        {
            return "NDA for " + projectName;
        }

        public override string GetTitle()
        {
            return REQUEST_TITLE;
        }

        public override SignatureRequestSendRequest GetSignatureRequest()
        {
            List<SubSignatureRequestSigner> signers = requestedSigners.Select(signer => new SubSignatureRequestSigner(signer.name, signer.emailAddress)).ToList();
            var request = new SignatureRequestSendRequest(signers: signers);
            request.AllowDecline = true;
            request.CcEmailAddresses = new List<string>() { LEGAL_EMAIL };
            List<System.IO.Stream> files = FILES.Select(filename => FileInterface.OpenLocalFile(filename)).ToList();
            request.File = files;
            request.Message = GetMessage();
            request.Subject = GetSubject();
            request.Title = GetTitle();

            return request;
        }

        public override Email GetSentEmail()
        {
            var email = new Email();
            email.fromAddress = "donotreply@test.com";
            email.toAddress = "engineers@test.com";
            email.subject = "NDA Contract sent to " + String.Join(", ", requestedSigners.Select(a => a.name));
            email.message = "NDA Contract " + contractId + " sent to " + String.Join(", ", requestedSigners.Select(a => a.name + " (" + a.emailAddress + ")"));
            return email;
        }

        public override bool HasTemplate()
        {
            return false;
        }
    }
}
