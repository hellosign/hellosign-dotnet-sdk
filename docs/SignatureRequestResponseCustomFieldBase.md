# HelloSign.Model.SignatureRequestResponseCustomFieldBase
An array of Custom Field objects containing the name and type of each custom field.  * Text Field uses `SignatureRequestResponseCustomFieldText` * Checkbox Field uses `SignatureRequestResponseCustomFieldCheckbox`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  The type of this Custom Field. Only &#39;text&#39; and &#39;checkbox&#39; are currently supported.  | 
**Name** | **string** |  The name of the Custom Field.  | 
**Required** | **bool** |  A boolean value denoting if this field is required.  | [optional] 
**ApiId** | **string** |  The unique ID for this field.  | [optional] 
**Editor** | **string** |  The name of the Role that is able to edit this field.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

