# HelloSign.Model.SignatureRequestCreateEmbeddedWithTemplateRequest
Calls SignatureRequestSend in controller

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateIds** | **List&lt;string&gt;** |  Use `template_ids` to create a SignatureRequest from one or more templates, in the order in which the template will be used.  | 
**ClientId** | **string** |  Client id of the app you&#39;re using to create this embedded signature request. Used for security purposes.  | 
**Signers** | [**List&lt;SubSignatureRequestTemplateSigner&gt;**](SubSignatureRequestTemplateSigner.md) |  Add Signers to your Templated-based Signature Request.  | 
**AllowDecline** | **bool** |  Allows signers to decline to sign a document if `true`. Defaults to `false`.  | [optional] [default to false]
**Ccs** | [**List&lt;SubCC&gt;**](SubCC.md) |  Add CC email recipients. Required when a CC role exists for the Template.  | [optional] 
**CustomFields** | [**List&lt;SubCustomField&gt;**](SubCustomField.md) |  An array defining values and options for custom fields. Required when a custom field exists in the Template.  | [optional] 
**File** | **List&lt;System.IO.Stream&gt;** |  Use `file[]` to indicate the uploaded file(s) to send for signature.<br><br>This endpoint requires either **file** or **file_url[]**, but not both.  | [optional] 
**FileUrl** | **List&lt;string&gt;** |  Use `file_url[]` to have Dropbox Sign download the file(s) to send for signature.<br><br>This endpoint requires either **file** or **file_url[]**, but not both.  | [optional] 
**Message** | **string** |  The custom message in the email that will be sent to the signers.  | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** |  Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.<br><br>Each request can include up to 10 metadata keys (or 50 nested metadata keys), with key names up to 40 characters long and values up to 1000 characters long.  | [optional] 
**SigningOptions** | [**SubSigningOptions**](SubSigningOptions.md) |    | [optional] 
**Subject** | **string** |  The subject in the email that will be sent to the signers.  | [optional] 
**TestMode** | **bool** |  Whether this is a test, the signature request will not be legally binding if set to `true`. Defaults to `false`.  | [optional] [default to false]
**Title** | **string** |  The title you want to assign to the SignatureRequest.  | [optional] 
**PopulateAutoFillFields** | **bool** |  Controls whether [auto fill fields](https://faq.hellosign.com/hc/en-us/articles/360051467511-Auto-Fill-Fields) can automatically populate a signer&#39;s information during signing.<br><br>⚠️ **Note** ⚠️: Keep your signer&#39;s information safe by ensuring that the _signer on your signature request is the intended party_ before using this feature.  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

