using System.Collections.Generic;
using Sample_App.model;
namespace Sample_App.common
{
    public class ContractFactory
    {
        public enum ContractType { NDA, Employment};
        private ContractFactory()
        {
        }

        public static BaseContract GetContract(ContractType contractType, List<User> signers)
        {
            switch (contractType)
            {
                case ContractType.NDA:
                    return new NDAContract(signers);
                default:
                    return new EmploymentContract(signers);
            }
            
        }
    }
}
