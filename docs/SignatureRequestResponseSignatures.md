# HelloSign.Model.SignatureRequestResponseSignatures
An array of signature objects, 1 for each signer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SignatureId** | **string** |  Signature identifier.  | [optional] 
**SignerEmailAddress** | **string** |  The email address of the signer.  | [optional] 
**SignerName** | **string** |  The name of the signer.  | [optional] 
**SignerRole** | **string** |  The role of the signer.  | [optional] 
**Order** | **int?** |  If signer order is assigned this is the 0-based index for this signer.  | [optional] 
**StatusCode** | **string** |  The current status of the signature. eg: awaiting_signature, signed, declined.  | [optional] 
**DeclineReason** | **string** |  The reason provided by the signer for declining the request.  | [optional] 
**SignedAt** | **int?** |  Time that the document was signed or null.  | [optional] 
**LastViewedAt** | **int?** |  The time that the document was last viewed by this signer or null.  | [optional] 
**LastRemindedAt** | **int?** |  The time the last reminder email was sent to the signer or null.  | [optional] 
**HasPin** | **bool** |  Boolean to indicate whether this signature requires a PIN to access.  | [optional] 
**HasSmsAuth** | **bool?** |  Boolean to indicate whether this signature has SMS authentication enabled.  | [optional] 
**HasSmsDelivery** | **bool?** |  Boolean to indicate whether this signature has SMS delivery enabled.  | [optional] 
**SmsPhoneNumber** | **string** |  The SMS phone number used for authentication or signature request delivery.  | [optional] 
**ReassignedBy** | **string** |  Email address of original signer who reassigned to this signer.  | [optional] 
**ReassignmentReason** | **string** |  Reason provided by original signer who reassigned to this signer.  | [optional] 
**ReassignedFrom** | **string** |  Previous signature identifier.  | [optional] 
**Error** | **string** |  Error message pertaining to this signer, or null.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

