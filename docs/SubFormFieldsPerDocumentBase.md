# HelloSign.Model.SubFormFieldsPerDocumentBase
The fields that should appear on the document, expressed as an array of objects. (We're currently fixing a bug where this property only accepts a two-dimensional array. You can read about it here: <a href=\"/docs/placing-fields/form-fields-per-document\" target=\"_blank\">Using Form Fields per Document</a>.)  **NOTE**: Fields like **text**, **dropdown**, **checkbox**, **radio**, and **hyperlink** have additional required and optional parameters. Check out the list of [additional parameters](/api/reference/constants/#form-fields-per-document) for these field types.  * Text Field use `SubFormFieldsPerDocumentText` * Dropdown Field use `SubFormFieldsPerDocumentDropdown` * Hyperlink Field use `SubFormFieldsPerDocumentHyperlink` * Checkbox Field use `SubFormFieldsPerDocumentCheckbox` * Radio Field use `SubFormFieldsPerDocumentRadio` * Signature Field use `SubFormFieldsPerDocumentSignature` * Date Signed Field use `SubFormFieldsPerDocumentDateSigned` * Initials Field use `SubFormFieldsPerDocumentInitials` * Text Merge Field use `SubFormFieldsPerDocumentTextMerge` * Checkbox Merge Field use `SubFormFieldsPerDocumentCheckboxMerge`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentIndex** | **int** |  Represents the integer index of the `file` or `file_url` document the field should be attached to.  | 
**ApiId** | **string** |  An identifier for the field that is unique across all documents in the request.  | 
**Height** | **int** |  Size of the field in pixels.  | 
**Required** | **bool** |  Whether this field is required.  | 
**Signer** | **string** |  Signer index identified by the offset in the signers parameter (0-based indexing), indicating which signer should fill out the field.<br><br>**NOTE**: If type is `text-merge` or `checkbox-merge`, you must set this to sender in order to use pre-filled data.  | 
**Type** | **string** |    | 
**Width** | **int** |  Size of the field in pixels.  | 
**X** | **int** |  Location coordinates of the field in pixels.  | 
**Y** | **int** |  Location coordinates of the field in pixels.  | 
**Name** | **string** |  Display name for the field.  | [optional] 
**Page** | **int?** |  Page in the document where the field should be placed (requires documents be PDF files).<br><br>- When the page number parameter is supplied, the API will use the new coordinate system. - Check out the differences between both [coordinate systems](https://faq.hellosign.com/hc/en-us/articles/217115577) and how to use them.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

