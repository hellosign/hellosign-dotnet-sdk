# HelloSign.Model.SubFormFieldsPerDocumentText
This class extends `SubFormFieldsPerDocumentBase`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentIndex** | **int** |  Represents the integer index of the `file` or `file_url` document the field should be attached to.  | 
**ApiId** | **string** |  An identifier for the field that is unique across all documents in the request.  | 
**Height** | **int** |  Size of the field in pixels.  | 
**Required** | **bool** |  Whether this field is required.  | 
**Signer** | **string** |  Signer index identified by the offset in the signers parameter (0-based indexing), indicating which signer should fill out the field.<br><br>**NOTE**: If type is `text-merge` or `checkbox-merge`, you must set this to sender in order to use pre-filled data.  | 
**Width** | **int** |  Size of the field in pixels.  | 
**X** | **int** |  Location coordinates of the field in pixels.  | 
**Y** | **int** |  Location coordinates of the field in pixels.  | 
**Name** | **string** |  Display name for the field.  | [optional] 
**Page** | **int?** |  Page in the document where the field should be placed (requires documents be PDF files).<br><br>- When the page number parameter is supplied, the API will use the new coordinate system. - Check out the differences between both [coordinate systems](https://faq.hellosign.com/hc/en-us/articles/217115577) and how to use them.  | [optional] 
**Type** | **string** |  A text input field. Use the `SubFormFieldsPerDocumentText` class.  | [default to "text"]
**Placeholder** | **string** |  Placeholder value for text field.  | [optional] 
**AutoFillType** | **string** |  Auto fill type for populating fields automatically. Check out the list of [auto fill types](/api/reference/constants/#auto-fill-types) to learn more about the possible values.  | [optional] 
**LinkId** | **string** |  Link two or more text fields. Enter data into one linked text field, which automatically fill all other linked text fields.  | [optional] 
**Masked** | **bool** |  Masks entered data. For more information see [Masking sensitive information](https://faq.hellosign.com/hc/en-us/articles/360040742811-Masking-sensitive-information). `true` for masking the data in a text field, otherwise `false`.  | [optional] 
**ValidationType** | **string** |  Each text field may contain a `validation_type` parameter. Check out the list of [validation types](https://faq.hellosign.com/hc/en-us/articles/217115577) to learn more about the possible values.<br><br>**NOTE**: When using `custom_regex` you are required to pass a second parameter `validation_custom_regex` and you can optionally provide `validation_custom_regex_format_label` for the error message the user will see in case of an invalid value.  | [optional] 
**ValidationCustomRegex** | **string** |    | [optional] 
**ValidationCustomRegexFormatLabel** | **string** |    | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

