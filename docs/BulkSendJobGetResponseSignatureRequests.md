# HelloSign.Model.BulkSendJobGetResponseSignatureRequests

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TestMode** | **bool?** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Whether this is a test signature request. Test requests have no legal value. Defaults to &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**SignatureRequestId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The id of the SignatureRequest. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**RequesterEmailAddress** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The email address of the initiator of the SignatureRequest. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Title** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The title the specified Account uses for the SignatureRequest. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**OriginalTitle** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Default Label for account. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Subject** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The subject in the email that was initially sent to the signers. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Message** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The custom message in the email that was initially sent to the signers. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Metadata** | **Object** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The metadata attached to the signature request. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**CreatedAt** | **int** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Time the signature request was created. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**IsComplete** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Whether or not the SignatureRequest has been fully executed by all signers. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**IsDeclined** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Whether or not the SignatureRequest has been declined by a signer. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**HasError** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Whether or not an error occurred (either during the creation of the SignatureRequest or during one of the signings). REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**FilesUrl** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The URL where a copy of the request&#39;s documents can be downloaded. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SigningUrl** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The URL where a signer, after authenticating, can sign the documents. This should only be used by users with existing HelloSign accounts as they will be required to log in before signing. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**DetailsUrl** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The URL where the requester and the signers can view the current status of the SignatureRequest. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**CcEmailAddresses** | **List&lt;string&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN A list of email addresses that were CCed on the SignatureRequest. They will receive a copy of the final PDF once all the signers have signed. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SigningRedirectUrl** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The URL you want the signer redirected to after they successfully sign. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**TemplateIds** | **List&lt;string&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Templates IDs used in this SignatureRequest (if any). REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**CustomFields** | [**List&lt;SignatureRequestResponseCustomFieldBase&gt;**](SignatureRequestResponseCustomFieldBase.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN An array of Custom Field objects containing the name and type of each custom field.

* Text Field uses &#x60;SignatureRequestResponseCustomFieldText&#x60;
* Checkbox Field uses &#x60;SignatureRequestResponseCustomFieldCheckbox&#x60; REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Attachments** | [**List&lt;SignatureRequestResponseAttachment&gt;**](SignatureRequestResponseAttachment.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN Signer attachments. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**ResponseData** | [**List&lt;SignatureRequestResponseDataBase&gt;**](SignatureRequestResponseDataBase.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN An array of form field objects containing the name, value, and type of each textbox or checkmark field filled in by the signers. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Signatures** | [**List&lt;SignatureRequestResponseSignatures&gt;**](SignatureRequestResponseSignatures.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN An array of signature objects, 1 for each signer. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**BulkSendJobId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The id of the BulkSendJob. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

