# HelloSign.Model.SubCustomField
When used together with merge fields, `custom_fields` allows users to add pre-filled data to their signature requests.  Pre-filled data can be used with \"send-once\" signature requests by adding merge fields with `form_fields_per_document` or [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) while passing values back with `custom_fields` together in one API call.  For using pre-filled on repeatable signature requests, merge fields are added to templates in the HelloSign UI or by calling [/template/create_embedded_draft](/api/reference/operation/templateCreateEmbeddedDraft) and then passing `custom_fields` on subsequent signature requests referencing that template.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The name of a custom field. When working with pre-filled data, the custom field&#39;s name must have a matching merge field name or the field will remain empty on the document during signing. REPLACE_ME_WITH_DESCRIPTION_END | 
**Editor** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Used to create editable merge fields. When the value matches a role passed in with &#x60;signers&#x60;, that role can edit the data that was pre-filled to that field. This field is optional, but required when this custom field object is set to &#x60;required &#x3D; true&#x60;.

**Note**: Editable merge fields are only supported for single signer requests (or the first signer in ordered signature requests). If used when there are multiple signers in an unordered signature request, the editor value is ignored and the field won&#39;t be editable. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Required** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Used to set an editable merge field when working with pre-filled data. When &#x60;true&#x60;, the custom field must specify a signer role in &#x60;editor&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**Value** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The string that resolves (aka &quot;pre-fills&quot;) to the merge field on the final document(s) used for signing. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

