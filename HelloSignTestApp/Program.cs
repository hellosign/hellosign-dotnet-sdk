using System;
using HelloSign;

namespace HelloSignTestApp
{
    class Program
    {
        // Configuration
        const Client.Environment ENVIRONMENT = Client.Environment.Staging;
        const string API_KEY = ""; // Your API Key goes here
        const string CLIENT_ID = ""; // Your API App Client ID goes here
        const string TEMPLATE_ID = ""; // Your test Template ID goes here

        static void Main(string[] args)
        {
            // Client setup
            var client = new Client(API_KEY);
            client.SetEnvironment(ENVIRONMENT);

            // Get account
            var account = client.GetAccount();
            Console.WriteLine("My Account ID: " + account.AccountId);
            //var account = client.UpdateAccount(new Uri("http://example.com"));

            // Try (and fail) to create account that already exists
            try
            {
                var newAccount = client.CreateAccount("apidemos@hellosign.com");
                throw new Exception("Created account that should already exist: " + newAccount.EmailAddress);
            }
            catch (BadRequestException)
            {
                Console.WriteLine("Was successfully blocked from creating a pre-existing account.");
            }

            // Create and delete team
            Team team;
            try
            {
                team = client.GetTeam();
                Console.WriteLine("My Team Name: " + team.Name);
            }
            catch (NotFoundException)
            {
                try
                {
                    team = client.CreateTeam("Test Program");
                    Console.WriteLine("Created Team Named: " + team.Name);
                }
                catch (BadRequestException)
                {
                    Console.WriteLine("Couldn't get or create team.");
                }
            }

            // List signature requests
            var requests = client.ListSignatureRequests();
            Console.WriteLine("Found this many signature requests: " + requests.NumResults);
            foreach (var result in requests)
            {
                Console.WriteLine("List item: " + result.SignatureRequestId);
            }

            // List templates
            var templates = client.ListTemplates();
            Console.WriteLine("Found this many templates: " + templates.NumResults);
            foreach (var result in templates)
            {
                Console.WriteLine("List item: " + result.TemplateId);
            }

            // Prepare some fake text files for upload
            byte[] file1 = System.Text.Encoding.ASCII.GetBytes("Test document, please sign at the end.");
            byte[] file2 = System.Text.Encoding.ASCII.GetBytes("Did I mention this is only a test?");

            // Send signature request
            var request = new SignatureRequest();
            request.Title = "NDA with Acme Co.";
            request.Subject = "The NDA we talked about";
            request.Message = "Please sign this NDA and then we can discuss more. Let me know if you have any questions.";
            request.AddSigner("jack@example.com", "Jack");
            request.AddSigner("jill@example.com", "Jill");
            request.AddCc("lawyer@example.com");
            request.AddFile(file1, "NDA.txt");
            request.AddFile(file2, "AppendixA.txt");
            request.Metadata.Add("custom_id", "1234");
            request.Metadata.Add("custom_text", "NDA #9");
            request.TestMode = true;
            var response = client.SendSignatureRequest(request);
            Console.WriteLine("New Signature Request ID: " + response.SignatureRequestId);

            // Get signature request (yes, it's redundant right here)
            var signatureRequest = client.GetSignatureRequest(response.SignatureRequestId);
            Console.WriteLine("Fetched request with Title: " + signatureRequest.Title);

            // Download signature request
            Console.WriteLine("Attempting to download PDF...");
            var retries = 5;
            while (retries > 0)
            {
                try
                {
                    client.DownloadSignatureRequestFiles(response.SignatureRequestId, "out.pdf");
                    Console.WriteLine("Downloaded PDF as out.pdf");
                    break;
                }
                catch (NotFoundException e)
                {
                    retries--;
                    Console.Write("Caught not_found: " + e.Message);
                    if (retries > 0)
                    {
                        Console.WriteLine(". Trying again in 2s...");
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine(". Giving up!");
                    }
                }
            }

            // Cancel signature request
            System.Threading.Thread.Sleep(4000);
            client.CancelSignatureRequest(response.SignatureRequestId);
            Console.WriteLine("Cancelled " + response.SignatureRequestId);

            // Send signature request with template
            if (TEMPLATE_ID.Length > 0) {
                var tRequest = new TemplateSignatureRequest();
                tRequest.TemplateId = TEMPLATE_ID;
                tRequest.Subject = "Purchase Order";
                tRequest.Message = "Glad we could come to an agreement.";
                tRequest.AddSigner("Client", "george@example.com", "George");
                tRequest.AddCc("Accounting", "accounting@example.com");
                tRequest.AddCustomField("Cost", "$20,000");
                tRequest.TestMode = true;
                var tResponse = client.SendSignatureRequest(tRequest);
                Console.WriteLine("New Template Signature Request ID: " + tResponse.SignatureRequestId);
                Console.WriteLine("Custom field 'Cost' is: " + tResponse.GetCustomField("Cost").Value);

                // Cancel that signature request
                System.Threading.Thread.Sleep(4000);
                client.CancelSignatureRequest(tResponse.SignatureRequestId);
                Console.WriteLine("Cancelled " + tResponse.SignatureRequestId);
            }
            else {
                Console.WriteLine("Skipping TemplateSignatureRequest test.");
            }

            // Create embedded signature request
            if (CLIENT_ID.Length > 0) {
                var eRequest = new SignatureRequest();
                eRequest.Title = "NDA with Acme Co.";
                eRequest.Subject = "The NDA we talked about";
                eRequest.Message = "Please sign this NDA and then we can discuss more. Let me know if you have any questions.";
                eRequest.AddSigner("jack@example.com", "Jack");
                eRequest.AddFile(file1, "NDA.txt");
                eRequest.Metadata.Add("custom_id", "1234");
                eRequest.Metadata.Add("custom_text", "NDA #9");
                eRequest.TestMode = true;
                var eResponse = client.CreateEmbeddedSignatureRequest(eRequest, CLIENT_ID);
                Console.WriteLine("New Embedded Signature Request ID: " + eResponse.SignatureRequestId);

                // Get embedded signing URL
                var embedded = client.GetSignUrl(eResponse.Signatures[0].SignatureId);
                Console.WriteLine("First Signature Sign URL: " + embedded.SignUrl);

                // Cancel that embedded signature request
                System.Threading.Thread.Sleep(4000);
                client.CancelSignatureRequest(eResponse.SignatureRequestId);
                Console.WriteLine("Cancelled " + eResponse.SignatureRequestId);
            }
            else {
                Console.WriteLine("Skipping CreateEmbeddedSignatureRequest test.");
            }

            Console.WriteLine("Press ENTER to exit.");
            Console.Read(); // Keeps the output window open
        }
    }
}
