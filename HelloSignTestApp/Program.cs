using System;
using HelloSign;

namespace HelloSignTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client setup
            //var client = new HelloSign.Client();
            var client = new Client("API KEY");
            client.SetEnvironment(Client.Environment.Staging);
            
            // Call API
            var account = client.GetAccount();
            //var account = client.CreateAccount("jack@example.com");
            //var account = client.UpdateAccount(new Uri("http://example.com"));
            Console.WriteLine("My Account ID: " + account.AccountId);

            // Get signature request
            var signatureRequest = client.GetSignatureRequest("DOCUMENT ID");
            Console.WriteLine("Fetched Request Title: " + signatureRequest.Title);

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
            tRequest.TemplateId = "abcdef";
            tRequest.Subject = "Purchase Order";
            tRequest.Message = "Glad we could come to an agreement.";
            tRequest.AddSigner("Client", "george@example.com", "George");
            tRequest.AddCc("Accounting", "accounting@hellosign.com");
            tRequest.CustomFields.Add("Cost", "$20,000");
            tRequest.TestMode = true;

            Console.WriteLine("Press ENTER to exit.");
            Console.Read(); // Keeps the output window open
        }
    }
}
