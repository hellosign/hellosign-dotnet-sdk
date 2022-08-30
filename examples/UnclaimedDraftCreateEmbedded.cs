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

        var data = new UnclaimedDraftCreateEmbeddedRequest(
            clientId: "ec64a202072370a737edf4a0eb7f4437",
            fileUrl: new List<string>(){"https://app.hellosign.com/docs/example_signature_request.pdf"},
            requesterEmailAddress: "jack@hellosign.com",
            testMode: true
        );

        try
        {
            var result = apiInstance.UnclaimedDraftCreateEmbedded(data);
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
