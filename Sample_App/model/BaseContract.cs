using System;
using System.Collections.Generic;
using System.Linq;

namespace Sample_App.model
{
    public abstract class BaseContract
    {
        protected List<User> requestedSigners { set; get; }
        protected List<User> completedSigners { set; get; }
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

        public abstract string GetTitle();
        public abstract string GetSubject();
        public abstract string GetMessage();
    }
}
