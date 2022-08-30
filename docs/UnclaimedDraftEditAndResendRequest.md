# HelloSign.Model.UnclaimedDraftEditAndResendRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** |  Client id of the app used to create the draft. Used to apply the branding and callback url defined for the app.  | 
**EditorOptions** | [**SubEditorOptions**](SubEditorOptions.md) |    | [optional] 
**IsForEmbeddedSigning** | **bool** |  The request created from this draft will also be signable in embedded mode if set to `true`.  | [optional] 
**RequesterEmailAddress** | **string** |  The email address of the user that should be designated as the requester of this draft. If not set, original requester&#39;s email address will be used.  | [optional] 
**RequestingRedirectUrl** | **string** |  The URL you want signers redirected to after they successfully request a signature.  | [optional] 
**ShowProgressStepper** | **bool** |  When only one step remains in the signature request process and this parameter is set to `false` then the progress stepper will be hidden.  | [optional] [default to true]
**SigningRedirectUrl** | **string** |  The URL you want signers redirected to after they successfully sign.  | [optional] 
**TestMode** | **bool** |  Whether this is a test, the signature request created from this draft will not be legally binding if set to `true`. Defaults to `false`.  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

