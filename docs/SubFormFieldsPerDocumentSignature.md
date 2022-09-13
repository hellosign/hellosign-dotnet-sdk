# HelloSign.Model.SubFormFieldsPerDocumentSignature
This class extends `SubFormFieldsPerDocumentBase`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentIndex** | **int** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Represents the integer index of the &#x60;file&#x60; or &#x60;file_url&#x60; document the field should be attached to. REPLACE_ME_WITH_DESCRIPTION_END | 
**ApiId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN An identifier for the field that is unique across all documents in the request. REPLACE_ME_WITH_DESCRIPTION_END | 
**Height** | **int** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Size of the field in pixels. REPLACE_ME_WITH_DESCRIPTION_END | 
**Required** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Whether this field is required. REPLACE_ME_WITH_DESCRIPTION_END | 
**Signer** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Signer index identified by the offset in the signers parameter (0-based indexing), indicating which signer should fill out the field.

**NOTE**: If type is &#x60;text-merge&#x60; or &#x60;checkbox-merge&#x60;, you must set this to sender in order to use pre-filled data. REPLACE_ME_WITH_DESCRIPTION_END | 
**Width** | **int** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Size of the field in pixels. REPLACE_ME_WITH_DESCRIPTION_END | 
**X** | **int** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Location coordinates of the field in pixels. REPLACE_ME_WITH_DESCRIPTION_END | 
**Y** | **int** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Location coordinates of the field in pixels. REPLACE_ME_WITH_DESCRIPTION_END | 
**Name** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Display name for the field. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Page** | **int?** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Page in the document where the field should be placed (requires documents be PDF files).

- When the page number parameter is supplied, the API will use the new coordinate system.
- Check out the differences between both [coordinate systems](https://faq.hellosign.com/hc/en-us/articles/217115577) and how to use them. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Type** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN A signature input field. Use the &#x60;SubFormFieldsPerDocumentSignature&#x60; class. REPLACE_ME_WITH_DESCRIPTION_END | [default to "signature"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

