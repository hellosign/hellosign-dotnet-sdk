# HelloSign.Model.UnclaimedDraftResponse
A group of documents that a user can take ownership of via the claim URL.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SignatureRequestId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The ID of the signature request that is represented by this UnclaimedDraft. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**ClaimUrl** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The URL to be used to claim this UnclaimedDraft. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SigningRedirectUrl** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The URL you want signers redirected to after they successfully sign. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**RequestingRedirectUrl** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The URL you want signers redirected to after they successfully request a signature (Will only be returned in the response if it is applicable to the request.). REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**ExpiresAt** | **int?** | REPLACE_ME_WITH_DESCRIPTION_BEGIN When the link expires. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**TestMode** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Whether this is a test draft. Signature requests made from test drafts have no legal value. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

