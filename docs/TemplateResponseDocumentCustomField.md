# HelloSign.Model.TemplateResponseDocumentCustomField

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  The name of the Custom Field.  | [optional] 
**Type** | **string** |  The type of this Custom Field. Only `text` and `checkbox` are currently supported.  | [optional] 
**Signer** | **string** |  The signer of the Custom Field.  | [optional] 
**X** | **int** |  The horizontal offset in pixels for this form field.  | [optional] 
**Y** | **int** |  The vertical offset in pixels for this form field.  | [optional] 
**Width** | **int** |  The width in pixels of this form field.  | [optional] 
**Height** | **int** |  The height in pixels of this form field.  | [optional] 
**Required** | **bool** |  Boolean showing whether or not this field is required.  | [optional] 
**ApiId** | **string** |  The unique ID for this field.  | [optional] 
**Group** | **string** |  The name of the group this field is in. If this field is not a group, this defaults to `null`.  | [optional] 
**AvgTextLength** | [**TemplateResponseFieldAvgTextLength**](TemplateResponseFieldAvgTextLength.md) |    | [optional] 
**IsMultiline** | **bool?** |  Whether this form field is multiline text.  | [optional] 
**OriginalFontSize** | **int?** |  Original font size used in this form field&#39;s text.  | [optional] 
**FontFamily** | **string** |  Font family used in this form field&#39;s text.  | [optional] 
**NamedFormFields** | **Object** |  Deprecated. Use `form_fields` inside the [documents](https://developers.hellosign.com/api/reference/operation/templateGet/#!c&#x3D;200&amp;path&#x3D;template/documents&amp;t&#x3D;response) array instead.  | [optional] 
**ReusableFormId** | **string** |    | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

