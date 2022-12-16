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

        var apiInstance = new UnclaimedDraftApi(config);

        var signer1 = new SubUnclaimedDraftSigner(
            emailAddress: "jack@example.com",
            name: "Jack",
            order: 0
        );

        var signer2 = new SubUnclaimedDraftSigner(
            emailAddress: "jill@example.com",
            name: "Jill",
            order: 1
        );

        var subSigningOptions = new SubSigningOptions(
            draw: true,
            type: true,
            upload: true,
            phone: false,
            defaultType: SubSigningOptions.DefaultTypeEnum.Draw
        );

        var subFieldOptions = new SubFieldOptions(
            dateFormat: SubFieldOptions.DateFormatEnum.DD_MM_YYYY
        );

        var metadata = new Dictionary<string, object>()
        {
            ["custom_id"] = 1234,
            ["custom_text"] = "NDA #9"
        };

        var files = new List<Stream> {
            new FileStream(
                TestHelper.RootPath + "/example_signature_request.pdf",
                FileMode.Open,
                FileAccess.Read,
                FileShare.Read
            )
        };

        var data = new UnclaimedDraftCreateRequest(
            subject: "The NDA we talked about",
            type: UnclaimedDraftCreateRequest.TypeEnum.RequestSignature,
            message: "Please sign this NDA and then we can discuss more. Let me know if you have any questions.",
            signers: new List<SubUnclaimedDraftSigner>(){signer1, signer2},
            ccEmailAddresses: new List<string>(){"lawyer@hellosign.com", "lawyer@example.com"},
            file: files,
            metadata: metadata,
            signingOptions: subSigningOptions,
            fieldOptions: subFieldOptions,
            testMode: true
        );

        try
        {
            var result = apiInstance.UnclaimedDraftCreate(data);
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
