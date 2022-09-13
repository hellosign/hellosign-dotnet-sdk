# HelloSign.Model.UnclaimedDraftEditAndResendRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Client id of the app used to create the draft. Used to apply the branding and callback url defined for the app. REPLACE_ME_WITH_DESCRIPTION_END | 
**EditorOptions** | [**SubEditorOptions**](SubEditorOptions.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN  REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**IsForEmbeddedSigning** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The request created from this draft will also be signable in embedded mode if set to &#x60;true&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**RequesterEmailAddress** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The email address of the user that should be designated as the requester of this draft. If not set, original requester&#39;s email address will be used. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**RequestingRedirectUrl** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The URL you want signers redirected to after they successfully request a signature. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**ShowProgressStepper** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN When only one step remains in the signature request process and this parameter is set to &#x60;false&#x60; then the progress stepper will be hidden. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to true]
**SigningRedirectUrl** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The URL you want signers redirected to after they successfully sign. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**TestMode** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Whether this is a test, the signature request created from this draft will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

