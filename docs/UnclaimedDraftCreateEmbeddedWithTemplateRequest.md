# HelloSign.Model.UnclaimedDraftCreateEmbeddedWithTemplateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Client id of the app used to create the draft. Used to apply the branding and callback url defined for the app. REPLACE_ME_WITH_DESCRIPTION_END | 
**RequesterEmailAddress** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The email address of the user that should be designated as the requester of this draft. REPLACE_ME_WITH_DESCRIPTION_END | 
**TemplateIds** | **List&lt;string&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Use &#x60;template_ids&#x60; to create a SignatureRequest from one or more templates, in the order in which the templates will be used. REPLACE_ME_WITH_DESCRIPTION_END | 
**AllowDecline** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Allows signers to decline to sign a document if &#x60;true&#x60;. Defaults to &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**AllowReassign** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Allows signers to reassign their signature requests to other signers if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;.

**Note**: Only available for Premium plan and higher. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**Ccs** | [**List&lt;SubCC&gt;**](SubCC.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN Add CC email recipients. Required when a CC role exists for the Template. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**CustomFields** | [**List&lt;SubCustomField&gt;**](SubCustomField.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN An array defining values and options for custom fields. Required when a custom field exists in the Template. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**EditorOptions** | [**SubEditorOptions**](SubEditorOptions.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN  REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**FieldOptions** | [**SubFieldOptions**](SubFieldOptions.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN  REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**File** | **List&lt;System.IO.Stream&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Use &#x60;file[]&#x60; to append additional files to the signature request being created from the template. HelloSign will parse the files for [text tags](https://app.hellosign.com/api/textTagsWalkthrough) and append it to the signature request. Text tags for signers not on the template(s) will be ignored.

**file** or **file_url[]** is required, but not both. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**FileUrl** | **List&lt;string&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Use file_url[] to append additional files to the signature request being created from the template. HelloSign will download the file, then parse it for [text tags](https://app.hellosign.com/api/textTagsWalkthrough), and append to the signature request. Text tags for signers not on the template(s) will be ignored.

**file** or **file_url[]** is required, but not both. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**ForceSignerRoles** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Provide users the ability to review/edit the template signer roles. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**ForceSubjectMessage** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Provide users the ability to review/edit the template subject and message. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**HoldRequest** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The request from this draft will not automatically send to signers post-claim if set to 1. Requester must [release](/api/reference/operation/signatureRequestReleaseHold/) the request from hold when ready to send. Defaults to &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**IsForEmbeddedSigning** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The request created from this draft will also be signable in embedded mode if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**Message** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The custom message in the email that will be sent to the signers. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.

Each request can include up to 10 metadata keys (or 50 nested metadata keys), with key names up to 40 characters long and values up to 1000 characters long. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**PreviewOnly** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN This allows the requester to enable the preview experience (i.e. does not allow the requester&#39;s end user to add any additional fields via the editor).

- &#x60;preview_only&#x3D;true&#x60;: Allows requesters to enable the preview only experience.
- &#x60;preview_only&#x3D;false&#x60;: Allows requesters to disable the preview only experience.

**Note**: This parameter overwrites &#x60;show_preview&#x3D;1&#x60; (if set). REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**RequestingRedirectUrl** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The URL you want signers redirected to after they successfully request a signature. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**ShowPreview** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN This allows the requester to enable the editor/preview experience.

- &#x60;show_preview&#x3D;true&#x60;: Allows requesters to enable the editor/preview experience.
- &#x60;show_preview&#x3D;false&#x60;: Allows requesters to disable the editor/preview experience. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**ShowProgressStepper** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN When only one step remains in the signature request process and this parameter is set to &#x60;false&#x60; then the progress stepper will be hidden. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to true]
**Signers** | [**List&lt;SubUnclaimedDraftTemplateSigner&gt;**](SubUnclaimedDraftTemplateSigner.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN Add Signers to your Templated-based Signature Request. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SigningOptions** | [**SubSigningOptions**](SubSigningOptions.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN  REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SigningRedirectUrl** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The URL you want signers redirected to after they successfully sign. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SkipMeNow** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Disables the &quot;Me (Now)&quot; option for the person preparing the document. Does not work with type &#x60;send_document&#x60;. Defaults to &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**Subject** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The subject in the email that will be sent to the signers. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**TestMode** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Whether this is a test, the signature request created from this draft will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**Title** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The title you want to assign to the SignatureRequest. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**PopulateAutoFillFields** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Controls whether [auto fill fields](https://faq.hellosign.com/hc/en-us/articles/360051467511-Auto-Fill-Fields) can automatically populate a signer&#39;s information during signing.  

⚠️ **Note** ⚠️: Keep your signer&#39;s information safe by ensuring that the _signer on your signature request is the intended party_ before using this feature. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

