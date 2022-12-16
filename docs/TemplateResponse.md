# HelloSign.Model.TemplateResponse
Contains information about the templates you and your team have created.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateId** | **string** |  The id of the Template.  | [optional] 
**Title** | **string** |  The title of the Template. This will also be the default subject of the message sent to signers when using this Template to send a SignatureRequest. This can be overridden when sending the SignatureRequest.  | [optional] 
**Message** | **string** |  The default message that will be sent to signers when using this Template to send a SignatureRequest. This can be overridden when sending the SignatureRequest.  | [optional] 
**UpdatedAt** | **int** |  Time the template was last updated.  | [optional] 
**IsEmbedded** | **bool?** |  `true` if this template was created using an embedded flow, `false` if it was created on our website.  | [optional] 
**IsCreator** | **bool?** |  `true` if you are the owner of this template, `false` if it&#39;s been shared with you by a team member.  | [optional] 
**CanEdit** | **bool?** |  Indicates whether edit rights have been granted to you by the owner (always `true` if that&#39;s you).  | [optional] 
**IsLocked** | **bool?** |  Indicates whether the template is locked. If `true`, then the template was created outside your quota and can only be used in `test_mode`. If `false`, then the template is within your quota and can be used to create signature requests.  | [optional] 
**Metadata** | **Object** |  The metadata attached to the template.  | [optional] 
**SignerRoles** | [**List&lt;TemplateResponseSignerRole&gt;**](TemplateResponseSignerRole.md) |  An array of the designated signer roles that must be specified when sending a SignatureRequest using this Template.  | [optional] 
**CcRoles** | [**List&lt;TemplateResponseCCRole&gt;**](TemplateResponseCCRole.md) |  An array of the designated CC roles that must be specified when sending a SignatureRequest using this Template.  | [optional] 
**Documents** | [**List&lt;TemplateResponseDocument&gt;**](TemplateResponseDocument.md) |  An array describing each document associated with this Template. Includes form field data for each document.  | [optional] 
**CustomFields** | [**List&lt;TemplateResponseCustomField&gt;**](TemplateResponseCustomField.md) |  An array of Custom Field objects.  | [optional] 
**NamedFormFields** | [**List&lt;TemplateResponseNamedFormField&gt;**](TemplateResponseNamedFormField.md) |  Deprecated. Use `form_fields` inside the [documents](https://developers.hellosign.com/api/reference/operation/templateGet/#!c&#x3D;200&amp;path&#x3D;template/documents&amp;t&#x3D;response) array instead.  | [optional] 
**Accounts** | [**List&lt;TemplateResponseAccount&gt;**](TemplateResponseAccount.md) |  An array of the Accounts that can use this Template.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

