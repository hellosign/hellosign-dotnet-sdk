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

        var apiInstance = new TemplateApi(config);

        var role1 = new SubTemplateRole(
            name: "Client",
            order: 0
        );

        var role2 = new SubTemplateRole(
            name: "Witness",
            order: 1
        );

        var mergeField1 = new SubMergeField(
            name: "Full Name",
            type: SubMergeField.TypeEnum.Text
        );

        var mergeField2 = new SubMergeField(
            name: "Is Registered?",
            type: SubMergeField.TypeEnum.Checkbox
        );

        var subFieldOptions = new SubFieldOptions(
            dateFormat: SubFieldOptions.DateFormatEnum.DDMMYYYY
        );

        var files = new List<Stream> {
            new FileStream(
                TestHelper.RootPath + "/example_signature_request.pdf",
                FileMode.Open,
                FileAccess.Read,
                FileShare.Read
            )
        };

        var data = new TemplateCreateEmbeddedDraftRequest(
            clientId: "37dee8d8440c66d54cfa05d92c160882",
            file: files,
            title: "Test Template",
            subject: "Please sign this document",
            message: "For your approval",
            signerRoles: new List<SubTemplateRole>(){role1, role2},
            ccRoles: new List<string>(){"Manager"},
            mergeFields: new List<SubMergeField>(){mergeField1, mergeField2},
            fieldOptions: subFieldOptions,
            testMode: true
        );

        try
        {
            var result = apiInstance.TemplateCreateEmbeddedDraft(data);
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
