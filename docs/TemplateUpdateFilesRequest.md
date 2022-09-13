# HelloSign.Model.TemplateUpdateFilesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Client id of the app you&#39;re using to update this template. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**File** | **List&lt;System.IO.Stream&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Use &#x60;file[]&#x60; to indicate the uploaded file(s) to use for the template.

This endpoint requires either **file** or **file_url[]**, but not both. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**FileUrl** | **List&lt;string&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Use &#x60;file_url[]&#x60; to have HelloSign download the file(s) to use for the template.

This endpoint requires either **file** or **file_url[]**, but not both. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Message** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The new default template email message. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Subject** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The new default template email subject. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**TestMode** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Whether this is a test, the signature request created from this draft will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

