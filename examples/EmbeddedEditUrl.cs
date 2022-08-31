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

        var apiInstance = new EmbeddedApi(config);

        var data = new EmbeddedEditUrlRequest(
            ccRoles: new List<string>(){""},
            mergeFields: new List<SubMergeField>()
        );

        var templateId = "5de8179668f2033afac48da1868d0093bf133266";

        try
        {
            var result = apiInstance.EmbeddedEditUrl(templateId, data);
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
