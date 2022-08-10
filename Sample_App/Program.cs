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
            var user = new User("Bill","Bill@example.com");
            Configuration config = ConfigurationFactory.GetConfiguration("api.dev-hellosign.com", "3cff3c94bb8c35dba564cbd25cdfe4f848f96512629f9766b6743f927b30a199");
            var client = new HelloSignClient(config);
            var contract = client.sendNDAContract("Project: Blue Harvest", new List<User>(){ user });
            Console.WriteLine("Successfully created contract with Id " + contract.contractId);
        }
    }
}
