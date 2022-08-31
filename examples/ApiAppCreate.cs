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

        var apiInstance = new ApiAppApi(config);

        var oauth = new SubOAuth(
            callbackUrl: "https://example.com/oauth",
            scopes: new List<SubOAuth.ScopesEnum>() {
                SubOAuth.ScopesEnum.BasicAccountInfo,
                SubOAuth.ScopesEnum.RequestSignature
            }
        );

        var whiteLabelingOptions = new SubWhiteLabelingOptions(
            primaryButtonColor: "#00b3e6",
            primaryButtonTextColor: "#ffffff"
        );

        var customLogoFile = new FileStream(
            "CustomLogoFile.png",
            FileMode.Open
        );

        var data = new ApiAppCreateRequest(
            name: "My Production App",
            domains: new List<string>(){"example.com"},
            oauth: oauth,
            whiteLabelingOptions: whiteLabelingOptions,
            customLogoFile: customLogoFile
        );

        try
        {
            var result = apiInstance.ApiAppCreate(data);
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
