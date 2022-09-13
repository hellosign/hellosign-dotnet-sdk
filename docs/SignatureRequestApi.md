# HelloSign.Api.SignatureRequestApi

All URIs are relative to *https://api.hellosign.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SignatureRequestBulkCreateEmbeddedWithTemplate**](SignatureRequestApi.md#signaturerequestbulkcreateembeddedwithtemplate) | **POST** /signature_request/bulk_create_embedded_with_template | Embedded Bulk Send with Template |
| [**SignatureRequestBulkSendWithTemplate**](SignatureRequestApi.md#signaturerequestbulksendwithtemplate) | **POST** /signature_request/bulk_send_with_template | Bulk Send with Template |
| [**SignatureRequestCancel**](SignatureRequestApi.md#signaturerequestcancel) | **POST** /signature_request/cancel/{signature_request_id} | Cancel Incomplete Signature Request |
| [**SignatureRequestCreateEmbedded**](SignatureRequestApi.md#signaturerequestcreateembedded) | **POST** /signature_request/create_embedded | Create Embedded Signature Request |
| [**SignatureRequestCreateEmbeddedWithTemplate**](SignatureRequestApi.md#signaturerequestcreateembeddedwithtemplate) | **POST** /signature_request/create_embedded_with_template | Create Embedded Signature Request with Template |
| [**SignatureRequestFiles**](SignatureRequestApi.md#signaturerequestfiles) | **GET** /signature_request/files/{signature_request_id} | Download Files |
| [**SignatureRequestGet**](SignatureRequestApi.md#signaturerequestget) | **GET** /signature_request/{signature_request_id} | Get Signature Request |
| [**SignatureRequestList**](SignatureRequestApi.md#signaturerequestlist) | **GET** /signature_request/list | List Signature Requests |
| [**SignatureRequestReleaseHold**](SignatureRequestApi.md#signaturerequestreleasehold) | **POST** /signature_request/release_hold/{signature_request_id} | Release On-Hold Signature Request |
| [**SignatureRequestRemind**](SignatureRequestApi.md#signaturerequestremind) | **POST** /signature_request/remind/{signature_request_id} | Send Request Reminder |
| [**SignatureRequestRemove**](SignatureRequestApi.md#signaturerequestremove) | **POST** /signature_request/remove/{signature_request_id} | Remove Signature Request Access |
| [**SignatureRequestSend**](SignatureRequestApi.md#signaturerequestsend) | **POST** /signature_request/send | Send Signature Request |
| [**SignatureRequestSendWithTemplate**](SignatureRequestApi.md#signaturerequestsendwithtemplate) | **POST** /signature_request/send_with_template | Send with Template |
| [**SignatureRequestUpdate**](SignatureRequestApi.md#signaturerequestupdate) | **POST** /signature_request/update/{signature_request_id} | Update Signature Request |

<a name="signaturerequestbulkcreateembeddedwithtemplate"></a>
# **SignatureRequestBulkCreateEmbeddedWithTemplate**
> BulkSendJobSendResponse SignatureRequestBulkCreateEmbeddedWithTemplate (SignatureRequestBulkCreateEmbeddedWithTemplateRequest signatureRequestBulkCreateEmbeddedWithTemplateRequest)

Embedded Bulk Send with Template

Creates BulkSendJob which sends up to 250 SignatureRequests in bulk based off of the provided Template(s) specified with the `template_ids` parameter to be signed in an embedded iFrame. These embedded signature requests can only be signed in embedded iFrames whereas normal signature requests can only be signed on HelloSign.  **NOTE**: Only available for Standard plan and higher.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__SignatureRequestBulkCreateEmbeddedWithTemplate_C#_CODE
```

#### Using the SignatureRequestBulkCreateEmbeddedWithTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Embedded Bulk Send with Template
    ApiResponse<BulkSendJobSendResponse> response = apiInstance.SignatureRequestBulkCreateEmbeddedWithTemplateWithHttpInfo(signatureRequestBulkCreateEmbeddedWithTemplateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignatureRequestApi.SignatureRequestBulkCreateEmbeddedWithTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestBulkCreateEmbeddedWithTemplateRequest** | [**SignatureRequestBulkCreateEmbeddedWithTemplateRequest**](SignatureRequestBulkCreateEmbeddedWithTemplateRequest.md) |  |  |

### Return type

[**BulkSendJobSendResponse**](BulkSendJobSendResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-Ratelimit-Reset -  <br>  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signaturerequestbulksendwithtemplate"></a>
# **SignatureRequestBulkSendWithTemplate**
> BulkSendJobSendResponse SignatureRequestBulkSendWithTemplate (SignatureRequestBulkSendWithTemplateRequest signatureRequestBulkSendWithTemplateRequest)

Bulk Send with Template

Creates BulkSendJob which sends up to 250 SignatureRequests in bulk based off of the provided Template(s) specified with the `template_ids` parameter.  **NOTE**: Only available for Standard plan and higher.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__SignatureRequestBulkSendWithTemplate_C#_CODE
```

#### Using the SignatureRequestBulkSendWithTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Send with Template
    ApiResponse<BulkSendJobSendResponse> response = apiInstance.SignatureRequestBulkSendWithTemplateWithHttpInfo(signatureRequestBulkSendWithTemplateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignatureRequestApi.SignatureRequestBulkSendWithTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestBulkSendWithTemplateRequest** | [**SignatureRequestBulkSendWithTemplateRequest**](SignatureRequestBulkSendWithTemplateRequest.md) |  |  |

### Return type

[**BulkSendJobSendResponse**](BulkSendJobSendResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-Ratelimit-Reset -  <br>  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signaturerequestcancel"></a>
# **SignatureRequestCancel**
> void SignatureRequestCancel (string signatureRequestId)

Cancel Incomplete Signature Request

Cancels an incomplete signature request. This action is **not reversible**.  The request will be canceled and signers will no longer be able to sign. If they try to access the signature request they will receive a HTTP 410 status code indicating that the resource has been deleted. Cancelation is asynchronous and a successful call to this endpoint will return an empty 200 OK response if the signature request is eligible to be canceled and has been successfully queued.  This 200 OK response does not indicate a successful cancelation of the signature request itself. The cancelation is confirmed via the `signature_request_canceled` event. It is recommended that a  [callback handler](/api/reference/tag/Callbacks-and-Events) be implemented to listen for the `signature_request_canceled` event. This callback will be sent only when the cancelation has completed successfully. If a callback handler has been configured and the event has not been received within 60 minutes of making the call, check the status of the request in the [API Dashboard](https://app.hellosign.com/apidashboard) and retry the cancelation if necessary.  To be eligible for cancelation, a signature request must have been sent successfully, must not yet have been signed by all signers, and you must either be the sender or own the API app under which it was sent. A partially signed signature request can be canceled.  **NOTE**: To remove your access to a completed signature request, use the endpoint: `POST /signature_request/remove/[:signature_request_id]`.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__SignatureRequestCancel_C#_CODE
```

#### Using the SignatureRequestCancelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel Incomplete Signature Request
    apiInstance.SignatureRequestCancelWithHttpInfo(signatureRequestId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignatureRequestApi.SignatureRequestCancelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestId** | **string** | The id of the incomplete SignatureRequest to cancel. |  |

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
| **200** | successful operation |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-Ratelimit-Reset -  <br>  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signaturerequestcreateembedded"></a>
# **SignatureRequestCreateEmbedded**
> SignatureRequestGetResponse SignatureRequestCreateEmbedded (SignatureRequestCreateEmbeddedRequest signatureRequestCreateEmbeddedRequest)

Create Embedded Signature Request

Creates a new SignatureRequest with the submitted documents to be signed in an embedded iFrame. If form_fields_per_document is not specified, a signature page will be affixed where all signers will be required to add their signature, signifying their agreement to all contained documents. <u>Note</u> that embedded signature requests can only be signed in embedded iFrames whereas normal signature requests can only be signed on HelloSign.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__SignatureRequestCreateEmbedded_C#_CODE
```

#### Using the SignatureRequestCreateEmbeddedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Embedded Signature Request
    ApiResponse<SignatureRequestGetResponse> response = apiInstance.SignatureRequestCreateEmbeddedWithHttpInfo(signatureRequestCreateEmbeddedRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignatureRequestApi.SignatureRequestCreateEmbeddedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestCreateEmbeddedRequest** | [**SignatureRequestCreateEmbeddedRequest**](SignatureRequestCreateEmbeddedRequest.md) |  |  |

### Return type

[**SignatureRequestGetResponse**](SignatureRequestGetResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-Ratelimit-Reset -  <br>  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signaturerequestcreateembeddedwithtemplate"></a>
# **SignatureRequestCreateEmbeddedWithTemplate**
> SignatureRequestGetResponse SignatureRequestCreateEmbeddedWithTemplate (SignatureRequestCreateEmbeddedWithTemplateRequest signatureRequestCreateEmbeddedWithTemplateRequest)

Create Embedded Signature Request with Template

Creates a new SignatureRequest based on the given Template(s) to be signed in an embedded iFrame. <u>Note</u> that embedded signature requests can only be signed in embedded iFrames whereas normal signature requests can only be signed on HelloSign.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__SignatureRequestCreateEmbeddedWithTemplate_C#_CODE
```

#### Using the SignatureRequestCreateEmbeddedWithTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Embedded Signature Request with Template
    ApiResponse<SignatureRequestGetResponse> response = apiInstance.SignatureRequestCreateEmbeddedWithTemplateWithHttpInfo(signatureRequestCreateEmbeddedWithTemplateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignatureRequestApi.SignatureRequestCreateEmbeddedWithTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestCreateEmbeddedWithTemplateRequest** | [**SignatureRequestCreateEmbeddedWithTemplateRequest**](SignatureRequestCreateEmbeddedWithTemplateRequest.md) |  |  |

### Return type

[**SignatureRequestGetResponse**](SignatureRequestGetResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-Ratelimit-Reset -  <br>  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signaturerequestfiles"></a>
# **SignatureRequestFiles**
> FileResponse SignatureRequestFiles (string signatureRequestId, string? fileType = null, bool? getUrl = null, bool? getDataUri = null)

Download Files

Obtain a copy of the current documents specified by the `signature_request_id` parameter.  Returns a PDF or ZIP file, or if `get_url` is set, a JSON object with a url to the file (PDFs only). If `get_data_uri` is set, a JSON object with a `data_uri` representing the base64 encoded file (PDFs only) is returned.  If the files are currently being prepared, a status code of `409` will be returned instead.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__SignatureRequestFiles_C#_CODE
```

#### Using the SignatureRequestFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download Files
    ApiResponse<FileResponse> response = apiInstance.SignatureRequestFilesWithHttpInfo(signatureRequestId, fileType, getUrl, getDataUri);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignatureRequestApi.SignatureRequestFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestId** | **string** | The id of the SignatureRequest to retrieve. |  |
| **fileType** | **string?** | Set to &#x60;pdf&#x60; for a single merged document or &#x60;zip&#x60; for a collection of individual documents. | [optional] [default to pdf] |
| **getUrl** | **bool?** | If &#x60;true&#x60;, the response will contain a url link to the file instead. Links are only available for PDFs and have a TTL of 3 days. | [optional] [default to false] |
| **getDataUri** | **bool?** | If &#x60;true&#x60;, the response will contain the file as base64 encoded string. Base64 encoding is only available for PDFs. | [optional] [default to false] |

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
| **200** | successful operation |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-Ratelimit-Reset -  <br>  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signaturerequestget"></a>
# **SignatureRequestGet**
> SignatureRequestGetResponse SignatureRequestGet (string signatureRequestId)

Get Signature Request

Returns the status of the SignatureRequest specified by the `signature_request_id` parameter.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__SignatureRequestGet_C#_CODE
```

#### Using the SignatureRequestGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Signature Request
    ApiResponse<SignatureRequestGetResponse> response = apiInstance.SignatureRequestGetWithHttpInfo(signatureRequestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignatureRequestApi.SignatureRequestGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestId** | **string** | The id of the SignatureRequest to retrieve. |  |

### Return type

[**SignatureRequestGetResponse**](SignatureRequestGetResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-Ratelimit-Reset -  <br>  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signaturerequestlist"></a>
# **SignatureRequestList**
> SignatureRequestListResponse SignatureRequestList (string? accountId = null, int? page = null, int? pageSize = null, string? query = null)

List Signature Requests

Returns a list of SignatureRequests that you can access. This includes SignatureRequests you have sent as well as received, but not ones that you have been CCed on.  Take a look at our [search guide](/api/reference/search/) to learn more about querying signature requests.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__SignatureRequestList_C#_CODE
```

#### Using the SignatureRequestListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Signature Requests
    ApiResponse<SignatureRequestListResponse> response = apiInstance.SignatureRequestListWithHttpInfo(accountId, page, pageSize, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignatureRequestApi.SignatureRequestListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string?** | Which account to return SignatureRequests for. Must be a team member. Use &#x60;all&#x60; to indicate all team members. Defaults to your account. | [optional]  |
| **page** | **int?** | Which page number of the SignatureRequest List to return. Defaults to &#x60;1&#x60;. | [optional] [default to 1] |
| **pageSize** | **int?** | Number of objects to be returned per page. Must be between &#x60;1&#x60; and &#x60;100&#x60;. Default is &#x60;20&#x60;. | [optional] [default to 20] |
| **query** | **string?** | String that includes search terms and/or fields to be used to filter the SignatureRequest objects. | [optional]  |

### Return type

[**SignatureRequestListResponse**](SignatureRequestListResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-Ratelimit-Reset -  <br>  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signaturerequestreleasehold"></a>
# **SignatureRequestReleaseHold**
> SignatureRequestGetResponse SignatureRequestReleaseHold (string signatureRequestId)

Release On-Hold Signature Request

Releases a held SignatureRequest that was claimed and prepared from an [UnclaimedDraft](/api/reference/tag/Unclaimed-Draft). The owner of the Draft must indicate at Draft creation that the SignatureRequest created from the Draft should be held. Releasing the SignatureRequest will send requests to all signers.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__SignatureRequestReleaseHold_C#_CODE
```

#### Using the SignatureRequestReleaseHoldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Release On-Hold Signature Request
    ApiResponse<SignatureRequestGetResponse> response = apiInstance.SignatureRequestReleaseHoldWithHttpInfo(signatureRequestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignatureRequestApi.SignatureRequestReleaseHoldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestId** | **string** | The id of the SignatureRequest to release. |  |

### Return type

[**SignatureRequestGetResponse**](SignatureRequestGetResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-Ratelimit-Reset -  <br>  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signaturerequestremind"></a>
# **SignatureRequestRemind**
> SignatureRequestGetResponse SignatureRequestRemind (string signatureRequestId, SignatureRequestRemindRequest signatureRequestRemindRequest)

Send Request Reminder

Sends an email to the signer reminding them to sign the signature request. You cannot send a reminder within 1 hour of the last reminder that was sent. This includes manual AND automatic reminders.  **NOTE**: This action can **not** be used with embedded signature requests.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__SignatureRequestRemind_C#_CODE
```

#### Using the SignatureRequestRemindWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Request Reminder
    ApiResponse<SignatureRequestGetResponse> response = apiInstance.SignatureRequestRemindWithHttpInfo(signatureRequestId, signatureRequestRemindRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignatureRequestApi.SignatureRequestRemindWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestId** | **string** | The id of the SignatureRequest to send a reminder for. |  |
| **signatureRequestRemindRequest** | [**SignatureRequestRemindRequest**](SignatureRequestRemindRequest.md) |  |  |

### Return type

[**SignatureRequestGetResponse**](SignatureRequestGetResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-Ratelimit-Reset -  <br>  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signaturerequestremove"></a>
# **SignatureRequestRemove**
> void SignatureRequestRemove (string signatureRequestId)

Remove Signature Request Access

Removes your access to a completed signature request. This action is **not reversible**.  The signature request must be fully executed by all parties (signed or declined to sign). Other parties will continue to maintain access to the completed signature request document(s).  Unlike /signature_request/cancel, this endpoint is synchronous and your access will be immediately removed. Upon successful removal, this endpoint will return a 200 OK response.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__SignatureRequestRemove_C#_CODE
```

#### Using the SignatureRequestRemoveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Signature Request Access
    apiInstance.SignatureRequestRemoveWithHttpInfo(signatureRequestId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignatureRequestApi.SignatureRequestRemoveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestId** | **string** | The id of the SignatureRequest to remove. |  |

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-Ratelimit-Reset -  <br>  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signaturerequestsend"></a>
# **SignatureRequestSend**
> SignatureRequestGetResponse SignatureRequestSend (SignatureRequestSendRequest signatureRequestSendRequest)

Send Signature Request

Creates and sends a new SignatureRequest with the submitted documents. If `form_fields_per_document` is not specified, a signature page will be affixed where all signers will be required to add their signature, signifying their agreement to all contained documents.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__SignatureRequestSend_C#_CODE
```

#### Using the SignatureRequestSendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Signature Request
    ApiResponse<SignatureRequestGetResponse> response = apiInstance.SignatureRequestSendWithHttpInfo(signatureRequestSendRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignatureRequestApi.SignatureRequestSendWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestSendRequest** | [**SignatureRequestSendRequest**](SignatureRequestSendRequest.md) |  |  |

### Return type

[**SignatureRequestGetResponse**](SignatureRequestGetResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-Ratelimit-Reset -  <br>  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signaturerequestsendwithtemplate"></a>
# **SignatureRequestSendWithTemplate**
> SignatureRequestGetResponse SignatureRequestSendWithTemplate (SignatureRequestSendWithTemplateRequest signatureRequestSendWithTemplateRequest)

Send with Template

Creates and sends a new SignatureRequest based off of the Template(s) specified with the `template_ids` parameter.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__SignatureRequestSendWithTemplate_C#_CODE
```

#### Using the SignatureRequestSendWithTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send with Template
    ApiResponse<SignatureRequestGetResponse> response = apiInstance.SignatureRequestSendWithTemplateWithHttpInfo(signatureRequestSendWithTemplateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignatureRequestApi.SignatureRequestSendWithTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestSendWithTemplateRequest** | [**SignatureRequestSendWithTemplateRequest**](SignatureRequestSendWithTemplateRequest.md) |  |  |

### Return type

[**SignatureRequestGetResponse**](SignatureRequestGetResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-Ratelimit-Reset -  <br>  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signaturerequestupdate"></a>
# **SignatureRequestUpdate**
> SignatureRequestGetResponse SignatureRequestUpdate (string signatureRequestId, SignatureRequestUpdateRequest signatureRequestUpdateRequest)

Update Signature Request

Updates the email address and/or the name for a given signer on a signature request. You can listen for the `signature_request_email_bounce` event on your app or account to detect bounced emails, and respond with this method.  **NOTE**: This action cannot be performed on a signature request with an appended signature page.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__SignatureRequestUpdate_C#_CODE
```

#### Using the SignatureRequestUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Signature Request
    ApiResponse<SignatureRequestGetResponse> response = apiInstance.SignatureRequestUpdateWithHttpInfo(signatureRequestId, signatureRequestUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SignatureRequestApi.SignatureRequestUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signatureRequestId** | **string** | The id of the SignatureRequest to update. |  |
| **signatureRequestUpdateRequest** | [**SignatureRequestUpdateRequest**](SignatureRequestUpdateRequest.md) |  |  |

### Return type

[**SignatureRequestGetResponse**](SignatureRequestGetResponse.md)

### Authorization

[api_key](../README.md#api_key), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-Ratelimit-Reset -  <br>  |
| **4XX** | failed_operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

