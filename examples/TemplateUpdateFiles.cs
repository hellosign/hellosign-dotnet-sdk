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

        var apiInstance = new TemplateApi(config);

        var data = new TemplateUpdateFilesRequest(
            fileUrl: new List<string>(){"https://app.hellosign.com/docs/example_signature_request.pdf"}
        );

        var templateId = "21f920ec2b7f4b6bb64d3ed79f26303843046536";

        try
        {
            var result = apiInstance.TemplateUpdateFiles(templateId, data);
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
