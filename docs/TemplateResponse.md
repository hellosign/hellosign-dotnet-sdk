# HelloSign.Model.TemplateResponse
Contains information about the templates you and your team have created.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The id of the Template. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Title** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The title of the Template. This will also be the default subject of the message sent to signers when using this Template to send a SignatureRequest. This can be overridden when sending the SignatureRequest. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Message** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The default message that will be sent to signers when using this Template to send a SignatureRequest. This can be overridden when sending the SignatureRequest. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**UpdatedAt** | **int** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Time the template was last updated. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**IsEmbedded** | **bool?** | REPLACE_ME_WITH_DESCRIPTION_BEGIN &#x60;true&#x60; if this template was created using an embedded flow, &#x60;false&#x60; if it was created on our website. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**IsCreator** | **bool?** | REPLACE_ME_WITH_DESCRIPTION_BEGIN &#x60;true&#x60; if you are the owner of this template, &#x60;false&#x60; if it&#39;s been shared with you by a team member. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**CanEdit** | **bool?** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Indicates whether edit rights have been granted to you by the owner (always &#x60;true&#x60; if that&#39;s you). REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**IsLocked** | **bool?** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Indicates whether the template is locked. 
If &#x60;true&#x60;, then the template was created outside your quota and can only be used in &#x60;test_mode&#x60;. 
If &#x60;false&#x60;, then the template is within your quota and can be used to create signature requests. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Metadata** | **Object** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The metadata attached to the template. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SignerRoles** | [**List&lt;TemplateResponseSignerRole&gt;**](TemplateResponseSignerRole.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN An array of the designated signer roles that must be specified when sending a SignatureRequest using this Template. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**CcRoles** | [**List&lt;TemplateResponseCCRole&gt;**](TemplateResponseCCRole.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN An array of the designated CC roles that must be specified when sending a SignatureRequest using this Template. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Documents** | [**List&lt;TemplateResponseDocument&gt;**](TemplateResponseDocument.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN An array describing each document associated with this Template. Includes form field data for each document. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**CustomFields** | [**List&lt;TemplateResponseCustomField&gt;**](TemplateResponseCustomField.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN An array of Custom Field objects. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**NamedFormFields** | [**List&lt;TemplateResponseNamedFormField&gt;**](TemplateResponseNamedFormField.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN Deprecated. Use &#x60;form_fields&#x60; inside the [documents](https://developers.hellosign.com/api/reference/operation/templateGet/#!c&#x3D;200&amp;path&#x3D;template/documents&amp;t&#x3D;response) array instead. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Accounts** | [**List&lt;TemplateResponseAccount&gt;**](TemplateResponseAccount.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN An array of the Accounts that can use this Template. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

