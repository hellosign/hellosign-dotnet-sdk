using System;
using System.Collections.Generic;
using System.IO;
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

        var apiInstance = new OAuthApi(config);

        var data = new OAuthTokenGenerateRequest(
            state: "900e06e2",
            code: "1b0d28d90c86c141",
            clientId: "cc91c61d00f8bb2ece1428035716b",
            clientSecret: "1d14434088507ffa390e6f5528465"
        );

        try
        {
            var result = apiInstance.OauthTokenGenerate(data);
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
