# HelloSign.Model.SignatureRequestSendWithTemplateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateIds** | **List&lt;string&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Use &#x60;template_ids&#x60; to create a SignatureRequest from one or more templates, in the order in which the template will be used. REPLACE_ME_WITH_DESCRIPTION_END | 
**Signers** | [**List&lt;SubSignatureRequestTemplateSigner&gt;**](SubSignatureRequestTemplateSigner.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN Add Signers to your Templated-based Signature Request. REPLACE_ME_WITH_DESCRIPTION_END | 
**AllowDecline** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Allows signers to decline to sign a document if &#x60;true&#x60;. Defaults to &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**Ccs** | [**List&lt;SubCC&gt;**](SubCC.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN Add CC email recipients. Required when a CC role exists for the Template. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**ClientId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Client id of the app to associate with the signature request. Used to apply the branding and callback url defined for the app. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**CustomFields** | [**List&lt;SubCustomField&gt;**](SubCustomField.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN An array defining values and options for custom fields. Required when a custom field exists in the Template. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**File** | **List&lt;System.IO.Stream&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Use &#x60;file[]&#x60; to indicate the uploaded file(s) to send for signature.

This endpoint requires either **file** or **file_url[]**, but not both. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**FileUrl** | **List&lt;string&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Use &#x60;file_url[]&#x60; to have HelloSign download the file(s) to send for signature.

This endpoint requires either **file** or **file_url[]**, but not both. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**IsQualifiedSignature** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Send with a value of &#x60;true&#x60; if you wish to enable
[Qualified Electronic Signatures](https://www.hellosign.com/features/qualified-electronic-signatures) (QES),
which requires a face-to-face call to verify the signer&#39;s identity.&lt;br&gt;
**Note**: QES is only available on the Premium API plan as an add-on purchase.
Cannot be used in &#x60;test_mode&#x60;. Only works on requests with one signer. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**Message** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The custom message in the email that will be sent to the signers. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.

Each request can include up to 10 metadata keys (or 50 nested metadata keys), with key names up to 40 characters long and values up to 1000 characters long. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SigningOptions** | [**SubSigningOptions**](SubSigningOptions.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN  REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SigningRedirectUrl** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The URL you want signers redirected to after they successfully sign. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Subject** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The subject in the email that will be sent to the signers. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**TestMode** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Whether this is a test, the signature request will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**Title** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The title you want to assign to the SignatureRequest. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

