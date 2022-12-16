# HelloSign.Model.EmbeddedEditUrlRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowEditCcs** | **bool** |  This allows the requester to enable/disable to add or change CC roles when editing the template.  | [optional] [default to false]
**CcRoles** | **List&lt;string&gt;** |  The CC roles that must be assigned when using the template to send a signature request. To remove all CC roles, pass in a single role with no name. For use in a POST request.  | [optional] 
**EditorOptions** | [**SubEditorOptions**](SubEditorOptions.md) |    | [optional] 
**ForceSignerRoles** | **bool** |  Provide users the ability to review/edit the template signer roles.  | [optional] [default to false]
**ForceSubjectMessage** | **bool** |  Provide users the ability to review/edit the template subject and message.  | [optional] [default to false]
**MergeFields** | [**List&lt;SubMergeField&gt;**](SubMergeField.md) |  Add additional merge fields to the template, which can be used used to pre-fill data by passing values into signature requests made with that template.<br><br>Remove all merge fields on the template by passing an empty array `[]`.  | [optional] 
**PreviewOnly** | **bool** |  This allows the requester to enable the preview experience (i.e. does not allow the requester&#39;s end user to add any additional fields via the editor).<br><br>**Note**: This parameter overwrites `show_preview&#x3D;true` (if set).  | [optional] [default to false]
**ShowPreview** | **bool** |  This allows the requester to enable the editor/preview experience.  | [optional] [default to false]
**ShowProgressStepper** | **bool** |  When only one step remains in the signature request process and this parameter is set to `false` then the progress stepper will be hidden.  | [optional] [default to true]
**TestMode** | **bool** |  Whether this is a test, locked templates will only be available for editing if this is set to `true`. Defaults to `false`.  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

