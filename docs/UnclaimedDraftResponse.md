# HelloSign.Model.UnclaimedDraftResponse
A group of documents that a user can take ownership of via the claim URL.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SignatureRequestId** | **string** |  The ID of the signature request that is represented by this UnclaimedDraft.  | [optional] 
**ClaimUrl** | **string** |  The URL to be used to claim this UnclaimedDraft.  | [optional] 
**SigningRedirectUrl** | **string** |  The URL you want signers redirected to after they successfully sign.  | [optional] 
**RequestingRedirectUrl** | **string** |  The URL you want signers redirected to after they successfully request a signature (Will only be returned in the response if it is applicable to the request.).  | [optional] 
**ExpiresAt** | **int?** |  When the link expires.  | [optional] 
**TestMode** | **bool** |  Whether this is a test draft. Signature requests made from test drafts have no legal value.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

