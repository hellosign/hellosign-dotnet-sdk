# HelloSign.Model.SubSigningOptions
This allows the requester to specify the types allowed for creating a signature.  **Note**: If `signing_options` are not defined in the request, the allowed types will default to those specified in the account settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultType** | **string** |  The default type shown (limited to the listed types)  | 
**Draw** | **bool** |  Allows drawing the signature  | [optional] [default to false]
**Phone** | **bool** |  Allows using a smartphone to email the signature  | [optional] [default to false]
**Type** | **bool** |  Allows typing the signature  | [optional] [default to false]
**Upload** | **bool** |  Allows uploading the signature  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

