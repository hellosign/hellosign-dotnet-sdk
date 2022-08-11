using System;
using System.Collections.Generic;
using Org.HelloSign.Client;
using Sample_App.common;
using Sample_App.client;
using Sample_App.model;

namespace Sample_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Bill","Bill@example.com", UserRole.CLIENT);
            var signers = new List<User>() { user };
            var domain = Environment.GetEnvironmentVariable("DOMAIN"); 
            var apikey = Environment.GetEnvironmentVariable("APIKEY");

            Configuration config = ConfigurationFactory.GetConfiguration(domain, apikey);
            var client = new HelloSignClient(config);

            NDAContract NDAContract = (NDAContract)ContractFactory.GetContract(ContractFactory.ContractType.NDA, signers);
            NDAContract.projectName = "Project: Blue Harvest";

            var SentNDAContract = client.sendContract(NDAContract);

            Console.WriteLine("Successfully sent NDA contract with Id " + SentNDAContract.contractId);

            EmploymentContract employmentContract = (EmploymentContract)ContractFactory.GetContract(ContractFactory.ContractType.Employment, signers);
            employmentContract.templateIds = new List<string>() { "7ecb2813364582e7e7e263fcb8cab20b53f6d04b" };

            var SentEmploymentContract = client.sendContract(employmentContract);
            Console.WriteLine("Successfully sent Employment contract with Id " + SentNDAContract.contractId);
        }
    }
}
