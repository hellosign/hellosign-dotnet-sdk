# HelloSign.Model.SubSignatureRequestTemplateSigner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Role** | **string** |  Must match an existing role in chosen Template(s). It&#39;s case-sensitive.  | 
**Name** | **string** |  The name of the signer.  | 
**EmailAddress** | **string** |  The email address of the signer.  | 
**Pin** | **string** |  The 4- to 12-character access code that will secure this signer&#39;s signature page.  | [optional] 
**SmsPhoneNumber** | **string** |  An E.164 formatted phone number.<br><br>**Note**: Not available in test mode and requires a Standard plan or higher.  | [optional] 
**SmsPhoneNumberType** | **string** |  Specifies the feature used with the `sms_phone_number`. Default `authentication`.<br><br>If `authentication`, signer is sent a verification code via SMS that is required to access the document.<br><br>If `delivery`, a link to complete the signature request is delivered via SMS (_and_ email).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

