using System.Collections.Generic;
using Sample_App.model;
using Org.HelloSign.Api;
using Org.HelloSign.Client;

namespace Sample_App.client
{
    public class HelloSignClient
    {
        private SignatureRequestApi SignatureRequestApi;
        public HelloSignClient(Configuration config)
        {
            this.SignatureRequestApi = new SignatureRequestApi(config);
        }

        public NDAContract sendNDAContract(string projectName, List<User> signers)
        {
            var contract = new NDAContract(projectName,signers);
            var response = SignatureRequestApi.SignatureRequestSend(contract.GetSignatureRequestSendRequest());
            contract.contractId = response.SignatureRequest.SignatureRequestId;
            EmailClient.sendEmail(contract.GetSentEmail());
            return contract;
        }
    }
}
