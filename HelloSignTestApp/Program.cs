using System;
using HelloSign;

namespace HelloSignTestApp
{
    class Program
    {
        // Configuration
        const string API_KEY = "e1bb4fdad736b4d7f350cff23d8ffa3c1538fd853e1c7d0c8c9007d57eb4f66b";
        const string CLIENT_ID = "Your API App Client ID goes here";
        const string TEMPLATE_ID = "ID of the test template goes here";
        const string TEST_FILE_1_PATH = "Absolute path to first test document goes here";
        const string TEST_FILE_2_PATH = "Absolute path to second test document goes here";

        static void Main(string[] args)
        {
            // Client setup
            var client = new Client(API_KEY);
            client.SetEnvironment(Client.Environment.Dev);

            // Get account
            var account = client.GetAccount();
            //var account = client.CreateAccount("stephen@hellosign.com");
            //var account = client.UpdateAccount(new Uri("http://example.com"));
            //Console.WriteLine("My Account ID: " + account.AccountId);

            // List sig requests
            var requests = client.ListTemplates();
            Console.WriteLine("Found this many templates: " + requests.NumResults);
            foreach (var result in requests)
            {
                Console.WriteLine("List item: " + result.TemplateId);
            }
            return;

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

            // Get signature request
            //var signatureRequest = client.GetSignatureRequest("DOCUMENT ID GOES HERE");
            //Console.WriteLine("Fetched Request Title: " + signatureRequest.Title);

            // Send signature request
            var request = new SignatureRequest();
            request.Title = "NDA with Acme Co.";
            request.Subject = "The NDA we talked about";
            request.Message = "Please sign this NDA and then we can discuss more. Let me know if you have any questions.";
            request.AddSigner("jack@example.com", "Jack");
            request.AddSigner("jill@example.com", "Jill");
            request.AddCc("lawyer@example.com");
            request.AddFile(TEST_FILE_1_PATH);
            request.AddFile(TEST_FILE_2_PATH);
            request.Metadata.Add("custom_id", "1234");
            request.Metadata.Add("custom_text", "NDA #9");
            request.TestMode = true;
            var response = client.SendSignatureRequest(request);
            Console.WriteLine("New Signature Request ID: " + response.SignatureRequestId);

            // Cancel signature request
            client.CancelSignatureRequest(response.SignatureRequestId);

            // Send signature request with template
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
            client.CancelSignatureRequest(tResponse.SignatureRequestId);

            // Create embedded signature request
            var eRequest = new SignatureRequest();
            eRequest.Title = "NDA with Acme Co.";
            eRequest.Subject = "The NDA we talked about";
            eRequest.Message = "Please sign this NDA and then we can discuss more. Let me know if you have any questions.";
            eRequest.AddSigner("jack@example.com", "Jack");
            eRequest.AddFile(TEST_FILE_1_PATH);
            eRequest.Metadata.Add("custom_id", "1234");
            eRequest.Metadata.Add("custom_text", "NDA #9");
            eRequest.TestMode = true;
            var eResponse = client.CreateEmbeddedSignatureRequest(eRequest, CLIENT_ID);
            Console.WriteLine("New Embedded Signature Request ID: " + eResponse.SignatureRequestId);

            // Get embedded signing URL
            var embedded = client.GetSignUrl(eResponse.Signatures[0].SignatureId);
            Console.WriteLine("First Signature Sign URL: " + embedded.SignUrl);

            Console.WriteLine("Press ENTER to exit.");
            Console.Read(); // Keeps the output window open
        }
    }
}
