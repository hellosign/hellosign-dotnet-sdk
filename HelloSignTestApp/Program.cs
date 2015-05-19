using System;
using HelloSign;

namespace HelloSignTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client setup
            var client = new Client("API KEY GOES HERE");
            client.SetEnvironment(Client.Environment.Staging);
            
            // Get account
            var account = client.GetAccount();
            //var account = client.CreateAccount("jack@example.com");
            //var account = client.UpdateAccount(new Uri("http://example.com"));
            Console.WriteLine("My Account ID: " + account.AccountId);

            // Create and delete team
            client.DeleteTeam();
            client.CreateTeam("Test Program");
            var team = client.GetTeam();
            Console.WriteLine("My Team Name: " + team.Name);

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
            request.AddFile("c:\\users\\PATH\\My Documents\\nda.txt");
            request.AddFile("c:\\users\\PATH\\My Documents\\AppendixA.txt");
            request.Metadata.Add("custom_id", "1234");
            request.Metadata.Add("custom_text", "NDA #9");
            request.TestMode = true;
            var response = client.SendSignatureRequest(request);
            Console.WriteLine("New Signature Request ID: " + response.SignatureRequestId);

            // Cancel signature request
            client.CancelSignatureRequest(response.SignatureRequestId);

            // Send signature request with template
            var tRequest = new TemplateSignatureRequest();
            tRequest.TemplateId = "TEMPLATE ID GOES HERE";
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

            Console.WriteLine("Press ENTER to exit.");
            Console.Read(); // Keeps the output window open
        }
    }
}
