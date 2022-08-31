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

        var apiInstance = new SignatureRequestApi(config);

        var signerList1Signer = new SubSignatureRequestTemplateSigner(
            role: "Client",
            name: "George",
            emailAddress: "george@example.com",
            pin: "d79a3td"
        );

        var signerList1CustomFields = new SubBulkSignerListCustomField(
            name: "company",
            value: "ABC Corp"
        );

        var signerList1 = new SubBulkSignerList(
            signers: new List<SubSignatureRequestTemplateSigner>(){signerList1Signer},
            customFields: new List<SubBulkSignerListCustomField>(){signerList1CustomFields}
        );

        var signerList2Signer = new SubSignatureRequestTemplateSigner(
            role: "Client",
            name: "Mary",
            emailAddress: "mary@example.com",
            pin: "gd9as5b"
        );

        var signerList2CustomFields = new SubBulkSignerListCustomField(
            name: "company",
            value: "123 Corp"
        );

        var signerList2 = new SubBulkSignerList(
            signers: new List<SubSignatureRequestTemplateSigner>(){signerList2Signer},
            customFields: new List<SubBulkSignerListCustomField>(){signerList2CustomFields}
        );

        var cc1 = new SubCC(
            role: "Accounting",
            emailAddress: "accouting@email.com"
        );

        var data = new SignatureRequestBulkSendWithTemplateRequest(
            templateIds: new List<string>(){"c26b8a16784a872da37ea946b9ddec7c1e11dff6"},
            subject: "Purchase Order",
            message: "Glad we could come to an agreement.",
            signerList: new List<SubBulkSignerList>(){signerList1, signerList2},
            ccs: new List<SubCC>(){cc1},
            testMode: true
        );

        try
        {
            var result = apiInstance.SignatureRequestBulkSendWithTemplate(data);
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
