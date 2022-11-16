# HelloSign.Model.SignatureRequestUpdateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SignatureId** | **string** |  The signature ID for the recipient.  | 
**EmailAddress** | **string** |  The new email address for the recipient.<br><br>**NOTE**: Optional if `name` is provided.  | [optional] 
**Name** | **string** |  The new name for the recipient.<br><br>**NOTE**: Optional if `email_address` is provided.  | [optional] 
**ExpiresAt** | **int?** |  The new time when the signature request will expire. Unsigned signatures will be moved to the expired status, and no longer signable.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

