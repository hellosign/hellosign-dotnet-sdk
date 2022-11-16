# HelloSign.Model.SignatureRequestResponse
Contains information about a signature request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TestMode** | **bool?** |  Whether this is a test signature request. Test requests have no legal value. Defaults to `false`.  | [optional] [default to false]
**SignatureRequestId** | **string** |  The id of the SignatureRequest.  | [optional] 
**RequesterEmailAddress** | **string** |  The email address of the initiator of the SignatureRequest.  | [optional] 
**Title** | **string** |  The title the specified Account uses for the SignatureRequest.  | [optional] 
**OriginalTitle** | **string** |  Default Label for account.  | [optional] 
**Subject** | **string** |  The subject in the email that was initially sent to the signers.  | [optional] 
**Message** | **string** |  The custom message in the email that was initially sent to the signers.  | [optional] 
**Metadata** | **Object** |  The metadata attached to the signature request.  | [optional] 
**CreatedAt** | **int** |  Time the signature request was created.  | [optional] 
**ExpiresAt** | **int** |  The time when the signature request will expire pending signatures.  | [optional] 
**IsComplete** | **bool** |  Whether or not the SignatureRequest has been fully executed by all signers.  | [optional] 
**IsDeclined** | **bool** |  Whether or not the SignatureRequest has been declined by a signer.  | [optional] 
**HasError** | **bool** |  Whether or not an error occurred (either during the creation of the SignatureRequest or during one of the signings).  | [optional] 
**FilesUrl** | **string** |  The URL where a copy of the request&#39;s documents can be downloaded.  | [optional] 
**SigningUrl** | **string** |  The URL where a signer, after authenticating, can sign the documents. This should only be used by users with existing Dropbox Sign accounts as they will be required to log in before signing.  | [optional] 
**DetailsUrl** | **string** |  The URL where the requester and the signers can view the current status of the SignatureRequest.  | [optional] 
**CcEmailAddresses** | **List&lt;string&gt;** |  A list of email addresses that were CCed on the SignatureRequest. They will receive a copy of the final PDF once all the signers have signed.  | [optional] 
**SigningRedirectUrl** | **string** |  The URL you want the signer redirected to after they successfully sign.  | [optional] 
**TemplateIds** | **List&lt;string&gt;** |  Templates IDs used in this SignatureRequest (if any).  | [optional] 
**CustomFields** | [**List&lt;SignatureRequestResponseCustomFieldBase&gt;**](SignatureRequestResponseCustomFieldBase.md) |  An array of Custom Field objects containing the name and type of each custom field.<br><br>* Text Field uses `SignatureRequestResponseCustomFieldText`<br>* Checkbox Field uses `SignatureRequestResponseCustomFieldCheckbox`  | [optional] 
**Attachments** | [**List&lt;SignatureRequestResponseAttachment&gt;**](SignatureRequestResponseAttachment.md) |  Signer attachments.  | [optional] 
**ResponseData** | [**List&lt;SignatureRequestResponseDataBase&gt;**](SignatureRequestResponseDataBase.md) |  An array of form field objects containing the name, value, and type of each textbox or checkmark field filled in by the signers.  | [optional] 
**Signatures** | [**List&lt;SignatureRequestResponseSignatures&gt;**](SignatureRequestResponseSignatures.md) |  An array of signature objects, 1 for each signer.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

