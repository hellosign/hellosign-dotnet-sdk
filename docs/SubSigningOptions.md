# HelloSign.Model.SubSigningOptions
This allows the requester to specify the types allowed for creating a signature.  **Note**: If `signing_options` are not defined in the request, the allowed types will default to those specified in the account settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultType** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The default type shown (limited to the listed types) REPLACE_ME_WITH_DESCRIPTION_END | 
**Draw** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Allows drawing the signature REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**Phone** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Allows using a smartphone to email the signature REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**Type** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Allows typing the signature REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**Upload** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Allows uploading the signature REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

