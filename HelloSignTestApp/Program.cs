using System;
using HelloSign;
using HelloSignTestApp.Properties;

namespace HelloSignTestApp
{
    class Program
    {
        // Configuration
        const string TEMPLATE_ID = ""; // Your test Template ID goes here

        static void Main(string[] args)
        {
            // Get API key from environment
            var apiKey = Environment.GetEnvironmentVariable("APIKEY");
            if (String.IsNullOrEmpty(apiKey))
            {
                throw new Exception("You must provide your HelloSign API key in the APIKEY environment variable.");
            }

            // Get environment (HS) from first positional argument (optional)
            var environment = Client.Environment.Staging; // Default environment
            if (args.Length >= 1) {
                var environmentString = args[0];
                Console.WriteLine("Using environment: " + environmentString);
                switch (environmentString)
                {
                    case "prod":
                        environment = Client.Environment.Prod;
                        break;
                    case "qa":
                        environment = Client.Environment.QA;
                        break;
                    case "staging":
                        environment = Client.Environment.Staging;
                        break;
                    case "dev":
                        environment = Client.Environment.Dev;
                        break;
                    default:
                        throw new Exception("Unrecognized environment " + environmentString + " (should be one of: prod qa staging dev)");
                }
            } else {
                Console.WriteLine("No environment specified. Defaulting to Staging.");
            }

            // Client setup
            var client = new Client(apiKey);
            client.SetEnvironment(environment);

            // Prepare some fake text files for upload
            byte[] file1 = System.Text.Encoding.ASCII.GetBytes("Test document, please sign at the end.");
            byte[] file2 = System.Text.Encoding.ASCII.GetBytes("Did I mention this is only a test?");
            byte[] textTagsFile1 = System.Text.Encoding.ASCII.GetBytes("This file has text tags:\n\n[sig|req|signer1]\n\n[initial|req|signer2]");
            byte[] pdfFile1 = Resources.Test_Document;

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

            // Get team (or try to create one)
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
                Console.WriteLine("Signature request: " + result.SignatureRequestId);
            }

            // List templates
            var templates = client.ListTemplates();
            Console.WriteLine("Found this many templates: " + templates.NumResults);
            foreach (var result in templates)
            {
                Console.WriteLine("Template: " + result.TemplateId);
            }

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
                catch (ConflictException e)
                {
                    retries--;
                    Console.Write("└ Caught conflict exception: " + e.Message);
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
            Console.WriteLine("└ Cancelled " + response.SignatureRequestId);

            // Send signature request with text tags
            var ttRequest = new SignatureRequest();
            ttRequest.Title = "NDA with Acme Co.";
            ttRequest.Subject = "The NDA we talked about";
            ttRequest.Message = "Please sign this NDA and then we can discuss more. Let me know if you have any questions.";
            ttRequest.AddSigner("jack@example.com", "Jack");
            ttRequest.AddSigner("jill@example.com", "Jill");
            ttRequest.AddFile(textTagsFile1, "TextTagsDocument.txt");
            ttRequest.UseTextTags = true;
            ttRequest.HideTextTags = true;
            ttRequest.TestMode = true;
            var ttResponse = client.SendSignatureRequest(ttRequest);
            Console.WriteLine("New Text Tags Signature Request ID: " + ttResponse.SignatureRequestId);

            // Cancel text tags request
            System.Threading.Thread.Sleep(4000);
            client.CancelSignatureRequest(ttResponse.SignatureRequestId);
            Console.WriteLine("└ Cancelled " + ttResponse.SignatureRequestId);

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
                Console.WriteLine("└ Cancelled " + tResponse.SignatureRequestId);
            }
            else {
                Console.WriteLine("Skipping TemplateSignatureRequest test.");
            }

            // Send signature request with form fields
            var ffRequest = new SignatureRequest();
            ffRequest.AddSigner("jack@example.com", "Jack");
            ffRequest.AddSigner("jill@example.com", "Jill");
            ffRequest.AddFile(pdfFile1, "TestDocument.pdf").WithFields(
                new FormField("sig1", FormField.FormFieldType.Signature, 1, 71, 165, 225, 52, true, 1),
                new FormField("sig2", FormField.FormFieldType.Signature, 1, 298, 165, 225, 52, true, 2)
            );
            ffRequest.TestMode = true;
            var ffResponse = client.SendSignatureRequest(ffRequest);
            Console.WriteLine("New Signature Request ID: " + ffResponse.SignatureRequestId);

            // List API apps
            var apiApps = client.ListApiApps();
            Console.WriteLine("Found this many API apps: " + apiApps.NumResults);
            foreach (var result in apiApps)
            {
                Console.WriteLine("API app: " + result.Name + " (" + result.ClientId + ")");
            }

            // Create API app
            var newApiApp = new ApiApp();
            DateTime.Now.ToShortTimeString();
            newApiApp.Name = "C# SDK Test App - " + DateTime.Now.ToString();
            newApiApp.Domain = "example.com";
            newApiApp.CallbackUrl = "https://example.com/callback";
            var aResponse = client.CreateApiApp(newApiApp);
            Console.WriteLine("New API App: " + aResponse.Name);

            // Get the new API app again (just for demonstration purposes)
            var apiApp = client.GetApiApp(aResponse.ClientId);
            var clientId = apiApp.ClientId;

            // Create embedded signature request
            var eRequest = new SignatureRequest();
            eRequest.Title = "NDA with Acme Co.";
            eRequest.Subject = "The NDA we talked about";
            eRequest.Message = "Please sign this NDA and then we can discuss more. Let me know if you have any questions.";
            eRequest.AddSigner("jack@example.com", "Jack");
            eRequest.AddFile(file1, "NDA.txt");
            eRequest.Metadata.Add("custom_id", "1234");
            eRequest.Metadata.Add("custom_text", "NDA #9");
            eRequest.TestMode = true;
            var eResponse = client.CreateEmbeddedSignatureRequest(eRequest, clientId);
            Console.WriteLine("New Embedded Signature Request ID: " + eResponse.SignatureRequestId);

            // Get embedded signing URL
            var embedded = client.GetSignUrl(eResponse.Signatures[0].SignatureId);
            Console.WriteLine("└ First Signature Sign URL: " + embedded.SignUrl);

            // Cancel that embedded signature request
            System.Threading.Thread.Sleep(4000);
            client.CancelSignatureRequest(eResponse.SignatureRequestId);
            Console.WriteLine("└ Cancelled " + eResponse.SignatureRequestId);

            // Create unclaimed draft
            var draft = new SignatureRequest();
            draft.AddFile(file1, "Agreement.txt");
            draft.AddFile(file2, "Appendix.txt");
            draft.TestMode = true;
            var uResponse = client.CreateUnclaimedDraft(draft, UnclaimedDraft.Type.RequestSignature);
            Console.WriteLine("New Unclaimed Draft Claim URL: " + uResponse.ClaimUrl);

            // Create embedded unclaimed draft
            var eDraft = new SignatureRequest();
            eDraft.AddFile(file1, "Agreement.txt");
            eDraft.RequesterEmailAddress = "jack@hellosign.com";
            eDraft.TestMode = true;
            var euResponse = client.CreateUnclaimedDraft(eDraft, clientId);
            Console.WriteLine("New Embedded Unclaimed Draft Claim URL: " + euResponse.ClaimUrl);

            // Create embedded unclaimed draft with a template
            if (TEMPLATE_ID.Length > 0) {
                var etDraft = new TemplateSignatureRequest();
                etDraft.TemplateId = TEMPLATE_ID;
                etDraft.RequesterEmailAddress = "jack@hellosign.com";
                etDraft.AddSigner("Client", "george@example.com", "George");
                etDraft.AddCc("Accounting", "accounting@example.com");
                etDraft.TestMode = true;
                var etuResponse = client.CreateUnclaimedDraft(etDraft, clientId);
                Console.WriteLine("New Embedded Unclaimed Draft with Template Claim URL: " + etuResponse.ClaimUrl);
            }

            // Delete the API app we created
            client.DeleteApiApp(clientId);
            Console.WriteLine("Deleted test API App");

            Console.WriteLine("Press ENTER to exit.");
            Console.Read(); // Keeps the output window open
        }
    }
}
