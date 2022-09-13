# HelloSign.Model.SignatureRequestBulkSendWithTemplateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateIds** | **List&lt;string&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Use &#x60;template_ids&#x60; to create a SignatureRequest from one or more templates, in the order in which the template will be used. REPLACE_ME_WITH_DESCRIPTION_END | 
**SignerFile** | **System.IO.Stream** | REPLACE_ME_WITH_DESCRIPTION_BEGIN &#x60;signer_file&#x60; is a CSV file defining values and options for signer fields. Required unless a &#x60;signer_list&#x60; is used, you may not use both. The CSV can have the following columns:

- &#x60;name&#x60;: the name of the signer filling the role of RoleName
- &#x60;email_address&#x60;: email address of the signer filling the role of RoleName
- &#x60;pin&#x60;: the 4- to 12-character access code that will secure this signer&#39;s signature page (optional)
- &#x60;sms_phone_number&#x60;: An E.164 formatted phone number that will receive a code via SMS to access this signer&#39;s signature page. (optional)

    **Note**: Not available in test mode and requires a Standard plan or higher.
- &#x60;*_field&#x60;: any column with a _field&quot; suffix will be treated as a custom field (optional)

    You may only specify field values here, any other options should be set in the custom_fields request parameter.

Example CSV:

&#x60;&#x60;&#x60;
name, email_address, pin, company_field
George, george@example.com, d79a3td, ABC Corp
Mary, mary@example.com, gd9as5b, 123 LLC
&#x60;&#x60;&#x60; REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SignerList** | [**List&lt;SubBulkSignerList&gt;**](SubBulkSignerList.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN &#x60;signer_list&#x60; is an array defining values and options for signer fields. Required unless a &#x60;signer_file&#x60; is used, you may not use both. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**AllowDecline** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Allows signers to decline to sign a document if &#x60;true&#x60;. Defaults to &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**Ccs** | [**List&lt;SubCC&gt;**](SubCC.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN Add CC email recipients. Required when a CC role exists for the Template. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**ClientId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The client id of the API App you want to associate with this request. Used to apply the branding and callback url defined for the app. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**CustomFields** | [**List&lt;SubCustomField&gt;**](SubCustomField.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN When used together with merge fields, &#x60;custom_fields&#x60; allows users to add pre-filled data to their signature requests.

Pre-filled data can be used with &quot;send-once&quot; signature requests by adding merge fields with &#x60;form_fields_per_document&#x60; or [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) while passing values back with &#x60;custom_fields&#x60; together in one API call.

For using pre-filled on repeatable signature requests, merge fields are added to templates in the HelloSign UI or by calling [/template/create_embedded_draft](/api/reference/operation/templateCreateEmbeddedDraft) and then passing &#x60;custom_fields&#x60; on subsequent signature requests referencing that template. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Message** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The custom message in the email that will be sent to the signers. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.

Each request can include up to 10 metadata keys (or 50 nested metadata keys), with key names up to 40 characters long and values up to 1000 characters long. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SigningRedirectUrl** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The URL you want signers redirected to after they successfully sign. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Subject** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The subject in the email that will be sent to the signers. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**TestMode** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Whether this is a test, the signature request will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**Title** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The title you want to assign to the SignatureRequest. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

