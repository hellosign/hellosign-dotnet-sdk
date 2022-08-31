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

        var apiInstance = new ReportApi(config);

        var data = new ReportCreateRequest(
            startDate: "09/01/2020",
            endDate: "09/01/2020",
            reportType: new List<ReportCreateRequest.ReportTypeEnum>() {
                ReportCreateRequest.ReportTypeEnum.UserActivity,
                ReportCreateRequest.ReportTypeEnum.DocumentStatus,
            }
        );

        try
        {
            var result = apiInstance.ReportCreate(data);
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
