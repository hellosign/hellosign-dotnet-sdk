using System;
using System.Collections.Generic;
using HelloSign.Api;
using HelloSign.Client;
using HelloSign.Model;

public class Example
{
    public static void Main()
    {
        var config = new Configuration();
        // Configure HTTP basic authorization: api_key
        config.Username = "YOUR_API_KEY";

        // or, configure Bearer (JWT) authorization: oauth2
        // config.AccessToken = "YOUR_BEARER_TOKEN";

        var apiInstance = new UnclaimedDraftApi(config);

        var signer = new SubUnclaimedDraftTemplateSigner(
            role: "Client",
            name: "George",
            emailAddress: "george@example.com"
        );

        var cc1 = new SubCC(
            role: "Accounting",
            emailAddress: "accouting@email.com"
        );

        var data = new UnclaimedDraftCreateEmbeddedWithTemplateRequest(
            clientId: "1a659d9ad95bccd307ecad78d72192f8",
            templateIds: new List<string>(){"c26b8a16784a872da37ea946b9ddec7c1e11dff6"},
            requesterEmailAddress: "jack@hellosign.com",
            signers: new List<SubUnclaimedDraftTemplateSigner>(){signer},
            ccs: new List<SubCC>(){cc1},
            testMode: true
        );

        try
        {
            var result = apiInstance.UnclaimedDraftCreateEmbeddedWithTemplate(data);
            Console.WriteLine(result);
        }
        catch (ApiException e)
        {
            Console.WriteLine("Exception when calling HelloSign API: " + e.Message);
            Console.WriteLine("Status Code: " + e.ErrorCode);
            Console.WriteLine(e.StackTrace);
        }
    }
}
