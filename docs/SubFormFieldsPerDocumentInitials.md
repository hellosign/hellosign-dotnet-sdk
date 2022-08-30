# HelloSign.Model.SubFormFieldsPerDocumentInitials
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
**Type** | **string** |  An input field for initials. Use the `SubFormFieldsPerDocumentInitials` class.  | [default to "initials"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

