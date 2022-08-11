using System;
using System.Collections.Generic;
using System.Linq;
using Org.HelloSign.Model;

namespace Sample_App.model
{
    public abstract class BaseContract
    {
        protected List<User> requestedSigners { set; get; }
        protected List<User> completedSigners { set; get; }
        public string contractId { set; get; }
        public BaseContract()
        {
        }

        public BaseContract(List<User> requestedSigners)
        {
            this.requestedSigners = requestedSigners;
        }

        public bool ContractCompleted()
        {
            return requestedSigners.All(completedSigners.Contains);
        }

        public List<SubSignatureRequestSigner> UsersToSubSignatureRequestSigners()
        {
            return requestedSigners.Select(signer => new SubSignatureRequestSigner(signer.name, signer.emailAddress)).ToList();
        }

        public abstract string GetTitle();
        public abstract string GetSubject();
        public abstract string GetMessage();
        public abstract Email GetSentEmail();
        public abstract Object GetSignatureRequest();
        public abstract bool HasTemplate();
    }
}
