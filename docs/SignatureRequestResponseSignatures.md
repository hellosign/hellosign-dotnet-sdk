# HelloSign.Model.SignatureRequestResponseSignatures
An array of signature objects, 1 for each signer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SignatureId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Signature identifier. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SignerEmailAddress** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The email address of the signer. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SignerName** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The name of the signer. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SignerRole** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The role of the signer. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Order** | **int?** | REPLACE_ME_WITH_DESCRIPTION_BEGIN If signer order is assigned this is the 0-based index for this signer. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**StatusCode** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The current status of the signature. eg: awaiting_signature, signed, declined. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**DeclineReason** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The reason provided by the signer for declining the request. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SignedAt** | **int?** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Time that the document was signed or null. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**LastViewedAt** | **int?** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The time that the document was last viewed by this signer or null. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**LastRemindedAt** | **int?** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The time the last reminder email was sent to the signer or null. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**HasPin** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Boolean to indicate whether this signature requires a PIN to access. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**HasSmsAuth** | **bool?** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Boolean to indicate whether this signature has SMS authentication enabled. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**HasSmsDelivery** | **bool?** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Boolean to indicate whether this signature has SMS delivery enabled. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SmsPhoneNumber** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The SMS phone number used for authentication or signature request delivery. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**ReassignedBy** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Email address of original signer who reassigned to this signer. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**ReassignmentReason** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Reason provided by original signer who reassigned to this signer. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Error** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Error message pertaining to this signer, or null. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

