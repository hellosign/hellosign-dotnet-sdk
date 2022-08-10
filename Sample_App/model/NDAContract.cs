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
        private string projectName { get; }
        public string requestMessage { get; set; }
        public string contractId { get; set; }
        public List<System.IO.Stream> files {get; set;}
        private FileInterface fileInterface;
        public NDAContract(string projectName, List<User> requestedSigners) : base(requestedSigners)
        {
            this.projectName = projectName;
            fileInterface = new FileInterface();
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

        public SignatureRequestSendRequest GetSignatureRequestSendRequest()
        {
            List<SubSignatureRequestSigner> signers = requestedSigners.Select(signer => new SubSignatureRequestSigner(signer.name, signer.emailAddress)).ToList();
            var request = new SignatureRequestSendRequest(signers: signers);
            request.AllowDecline = true;
            request.CcEmailAddresses = new List<string>() { LEGAL_EMAIL };
            List<string> filenames = new List<string>() { "nda_contract.pdf"};
            List<System.IO.Stream> files = filenames.Select(filename => fileInterface.OpenLocalFile(filename)).ToList();
            request.File = files;
            request.Message = GetMessage();
            request.Subject = GetSubject();
            request.Title = GetTitle();

            return request;
        }

        public Email GetSentEmail()
        {
            var email = new Email();
            email.fromAddress = "donotreply@test.com";
            email.toAddress = "engineers@test.com";
            email.subject = "NDA Contract sent to " + String.Join(", ", requestedSigners.Select(a => a.name));
            email.message = "NDA Contract " + contractId + " sent " + String.Join(", ", requestedSigners.Select(a => a.name + " (" + a.emailAddress + ")"));
            return email;
        }
    }
}
