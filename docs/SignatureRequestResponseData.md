# Org.HelloSign.Model.SignatureRequestResponseData
An array of form field objects containing the name, value, and type of each textbox or checkmark field filled in by the signers.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiId** | **string** |  The unique ID for this field.  | [optional] 
**SignatureId** | **string** |  The ID of the signature to which this response is linked.  | [optional] 
**Name** | **string** |  The name of the form field.  | [optional] 
**Value** | **string** |  The value of the form field.  | [optional] 
**Required** | **bool** |  A boolean value denoting if this field is required.  | [optional] 
**Type** | **string** |  - `text`: A text input field - `checkbox`: A yes/no checkbox - `date_signed`: A date - `dropdown`: An input field for dropdowns - `initials`: An input field for initials - `radio`: An input field for radios - `signature`: A signature input field - `text-merge`: A text field that has default text set by the api - `checkbox-merge`: A checkbox field that has default value set by the api  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

