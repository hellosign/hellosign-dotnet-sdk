# Org.HelloSign.Api.TemplateApi

All URIs are relative to *https://api.hellosign.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TemplateAddUser**](TemplateApi.md#templateadduser) | **POST** /template/add_user/{template_id} | Add User to Template |
| [**TemplateCreateEmbeddedDraft**](TemplateApi.md#templatecreateembeddeddraft) | **POST** /template/create_embedded_draft | Create Embedded Template Draft |
| [**TemplateDelete**](TemplateApi.md#templatedelete) | **POST** /template/delete/{template_id} | Delete Template |
| [**TemplateFiles**](TemplateApi.md#templatefiles) | **GET** /template/files/{template_id} | Get Template Files |
| [**TemplateGet**](TemplateApi.md#templateget) | **GET** /template/{template_id} | Get Template |
| [**TemplateList**](TemplateApi.md#templatelist) | **GET** /template/list | List Templates |
| [**TemplateRemoveUser**](TemplateApi.md#templateremoveuser) | **POST** /template/remove_user/{template_id} | Remove User from Template |
| [**TemplateUpdateFiles**](TemplateApi.md#templateupdatefiles) | **POST** /template/update_files/{template_id} | Update Template Files |

<a name="templateadduser"></a>
# **TemplateAddUser**
> TemplateGetResponse TemplateAddUser (string templateId, TemplateAddUserRequest templateAddUserRequest)

Add User to Template

Gives the specified Account access to the specified Template. The specified Account must be a part of your Team.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TemplateAddUser_C#_CODE
```

#### Using the TemplateAddUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add User to Template
    ApiResponse<TemplateGetResponse> response = apiInstance.TemplateAddUserWithHttpInfo(templateId, templateAddUserRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateApi.TemplateAddUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The id of the Template to give the Account access to. |  |
| **templateAddUserRequest** | [**TemplateAddUserRequest**](TemplateAddUserRequest.md) |  |  |

### Return type

[**TemplateGetResponse**](TemplateGetResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatecreateembeddeddraft"></a>
# **TemplateCreateEmbeddedDraft**
> TemplateCreateEmbeddedDraftResponse TemplateCreateEmbeddedDraft (TemplateCreateEmbeddedDraftRequest templateCreateEmbeddedDraftRequest)

Create Embedded Template Draft

The first step in an embedded template workflow. Creates a draft template that can then be further set up in the template 'edit' stage.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TemplateCreateEmbeddedDraft_C#_CODE
```

#### Using the TemplateCreateEmbeddedDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Embedded Template Draft
    ApiResponse<TemplateCreateEmbeddedDraftResponse> response = apiInstance.TemplateCreateEmbeddedDraftWithHttpInfo(templateCreateEmbeddedDraftRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateApi.TemplateCreateEmbeddedDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateCreateEmbeddedDraftRequest** | [**TemplateCreateEmbeddedDraftRequest**](TemplateCreateEmbeddedDraftRequest.md) |  |  |

### Return type

[**TemplateCreateEmbeddedDraftResponse**](TemplateCreateEmbeddedDraftResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatedelete"></a>
# **TemplateDelete**
> void TemplateDelete (string templateId)

Delete Template

Completely deletes the template specified from the account.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TemplateDelete_C#_CODE
```

#### Using the TemplateDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Template
    apiInstance.TemplateDeleteWithHttpInfo(templateId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateApi.TemplateDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The id of the Template to delete. |  |

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatefiles"></a>
# **TemplateFiles**
> FileResponse TemplateFiles (string templateId, string? fileType = null, bool? getUrl = null, bool? getDataUri = null)

Get Template Files

Obtain a copy of the current documents specified by the `template_id` parameter.  Returns a PDF or ZIP file, or if `get_url` is set, a JSON object with a url to the file (PDFs only). If `get_data_uri` is set, a JSON object with a `data_uri` representing the base64 encoded file (PDFs only) is returned.  If the files are currently being prepared, a status code of `409` will be returned instead. In this case please wait for the `template_created` callback event.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TemplateFiles_C#_CODE
```

#### Using the TemplateFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Template Files
    ApiResponse<FileResponse> response = apiInstance.TemplateFilesWithHttpInfo(templateId, fileType, getUrl, getDataUri);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateApi.TemplateFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The id of the template files to retrieve. |  |
| **fileType** | **string?** | Set to `pdf` for a single merged document or `zip` for a collection of individual documents. | [optional]  |
| **getUrl** | **bool?** | If `true`, the response will contain a url link to the file instead. Links are only available for PDFs and have a TTL of 3 days. | [optional] [default to false] |
| **getDataUri** | **bool?** | If `true`, the response will contain the file as base64 encoded string. Base64 encoding is only available for PDFs. | [optional] [default to false] |

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templateget"></a>
# **TemplateGet**
> TemplateGetResponse TemplateGet (string templateId)

Get Template

Returns the Template specified by the `id` parameter.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TemplateGet_C#_CODE
```

#### Using the TemplateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Template
    ApiResponse<TemplateGetResponse> response = apiInstance.TemplateGetWithHttpInfo(templateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateApi.TemplateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The id of the Template to retrieve. |  |

### Return type

[**TemplateGetResponse**](TemplateGetResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatelist"></a>
# **TemplateList**
> TemplateListResponse TemplateList (string? accountId = null, int? page = null, int? pageSize = null, string? query = null)

List Templates

Returns a list of the Templates that are accessible by you.  Take a look at our [search guide](/api/reference/search/) to learn more about querying templates.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TemplateList_C#_CODE
```

#### Using the TemplateListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Templates
    ApiResponse<TemplateListResponse> response = apiInstance.TemplateListWithHttpInfo(accountId, page, pageSize, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateApi.TemplateListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string?** | Which account to return Templates for. Must be a team member. Use `all` to indicate all team members. Defaults to your account. | [optional]  |
| **page** | **int?** | Which page number of the Template List to return. Defaults to `1`. | [optional] [default to 1] |
| **pageSize** | **int?** | Number of objects to be returned per page. Must be between `1` and `100`. Default is `20`. | [optional] [default to 20] |
| **query** | **string?** | String that includes search terms and/or fields to be used to filter the Template objects. | [optional]  |

### Return type

[**TemplateListResponse**](TemplateListResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templateremoveuser"></a>
# **TemplateRemoveUser**
> TemplateGetResponse TemplateRemoveUser (string templateId, TemplateRemoveUserRequest templateRemoveUserRequest)

Remove User from Template

Removes the specified Account's access to the specified Template.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TemplateRemoveUser_C#_CODE
```

#### Using the TemplateRemoveUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove User from Template
    ApiResponse<TemplateGetResponse> response = apiInstance.TemplateRemoveUserWithHttpInfo(templateId, templateRemoveUserRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateApi.TemplateRemoveUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The id of the Template to remove the Account&#39;s access to. |  |
| **templateRemoveUserRequest** | [**TemplateRemoveUserRequest**](TemplateRemoveUserRequest.md) |  |  |

### Return type

[**TemplateGetResponse**](TemplateGetResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templateupdatefiles"></a>
# **TemplateUpdateFiles**
> TemplateUpdateFilesResponse TemplateUpdateFiles (string templateId, TemplateUpdateFilesRequest templateUpdateFilesRequest)

Update Template Files

Overlays a new file with the overlay of an existing template. The new file(s) must:  1. have the same or higher page count 2. the same orientation as the file(s) being replaced.  This will not overwrite or in any way affect the existing template. Both the existing template and new template will be available for use after executing this endpoint. Also note that this will decrement your template quota.  Overlaying new files is asynchronous and a successful call to this endpoint will return 200 OK response if the request passes initial validation checks.  It is recommended that a callback be implemented to listen for the callback event. A `template_created` event will be sent when the files are updated or a `template_error` event will be sent if there was a problem while updating the files. If a callback handler has been configured and the event has not been received within 60 minutes of making the call, check the status of the request in the API dashboard and retry the request if necessary.  If the page orientation or page count is different from the original template document, we will notify you with a `template_error` [callback event](https://app.hellosign.com/api/eventsAndCallbacksWalkthrough).

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TemplateUpdateFiles_C#_CODE
```

#### Using the TemplateUpdateFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Template Files
    ApiResponse<TemplateUpdateFilesResponse> response = apiInstance.TemplateUpdateFilesWithHttpInfo(templateId, templateUpdateFilesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateApi.TemplateUpdateFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The ID of the template whose files to update. |  |
| **templateUpdateFilesRequest** | [**TemplateUpdateFilesRequest**](TemplateUpdateFilesRequest.md) |  |  |

### Return type

[**TemplateUpdateFilesResponse**](TemplateUpdateFilesResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

