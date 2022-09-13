# HelloSign.Model.SubSignatureRequestTemplateSigner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Role** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Must match an existing role in chosen Template(s). It&#39;s case-sensitive. REPLACE_ME_WITH_DESCRIPTION_END | 
**Name** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The name of the signer. REPLACE_ME_WITH_DESCRIPTION_END | 
**EmailAddress** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The email address of the signer. REPLACE_ME_WITH_DESCRIPTION_END | 
**Pin** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The 4- to 12-character access code that will secure this signer&#39;s signature page. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SmsPhoneNumber** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN An E.164 formatted phone number.

**Note**: Not available in test mode and requires a Standard plan or higher. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SmsPhoneNumberType** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN **Note**: This only works in non embedded endpoints.

If set, the value must be either &#x60;authentication&#x60; or &#x60;delivery&#x60;. Default &#x60;authentication&#x60;. 

If &#x60;authentication&#x60; is set, &#x60;sms_phone_number&#x60; will receive a code via SMS to access this signer&#39;s signature page.

If &#x60;delivery&#x60; is set, signature request will be delivered to both email and &#x60;sms_phone_number&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

