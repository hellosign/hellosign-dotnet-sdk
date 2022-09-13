# HelloSign.Model.EmbeddedEditUrlRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowEditCcs** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN This allows the requester to enable/disable to add or change CC roles when editing the template. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**CcRoles** | **List&lt;string&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The CC roles that must be assigned when using the template to send a signature request. To remove all CC roles, pass in a single role with no name. For use in a POST request. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**EditorOptions** | [**SubEditorOptions**](SubEditorOptions.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN  REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**ForceSignerRoles** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Provide users the ability to review/edit the template signer roles. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**ForceSubjectMessage** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Provide users the ability to review/edit the template subject and message. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**MergeFields** | [**List&lt;SubMergeField&gt;**](SubMergeField.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN Add additional merge fields to the template, which can be used used to pre-fill data by passing values into signature requests made with that template.  
  
Remove all merge fields on the template by passing an empty array &#x60;[]&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**PreviewOnly** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN This allows the requester to enable the preview experience (i.e. does not allow the requester&#39;s end user to add any additional fields via the editor).

**Note**: This parameter overwrites &#x60;show_preview&#x3D;true&#x60; (if set). REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**ShowPreview** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN This allows the requester to enable the editor/preview experience. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**ShowProgressStepper** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN When only one step remains in the signature request process and this parameter is set to &#x60;false&#x60; then the progress stepper will be hidden. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to true]
**TestMode** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Whether this is a test, locked templates will only be available for editing if this is set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

