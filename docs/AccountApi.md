# HelloSign.Api.AccountApi

All URIs are relative to *https://api.hellosign.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AccountCreate**](AccountApi.md#accountcreate) | **POST** /account/create | Create Account |
| [**AccountGet**](AccountApi.md#accountget) | **GET** /account | Get Account |
| [**AccountUpdate**](AccountApi.md#accountupdate) | **PUT** /account | Update Account |
| [**AccountVerify**](AccountApi.md#accountverify) | **POST** /account/verify | Verify Account |

<a name="accountcreate"></a>
# **AccountCreate**
> AccountCreateResponse AccountCreate (AccountCreateRequest accountCreateRequest)

Create Account

Creates a new Dropbox Sign Account that is associated with the specified `email_address`.

### Example
```csharp
using System;

using HelloSign.Api;
using HelloSign.Client;
using HelloSign.Model;

public class Example
{
    public static void Main()
    {
        var config = new Configuration();
        // Configure HTTP basic authorization: api_key
        config.Username = "YOUR_API_KEY";

        // or, configure Bearer (JWT) authorization: oauth2
        // config.AccessToken = "YOUR_BEARER_TOKEN";

        var apiInstance = new AccountApi(config);

        var data = new AccountCreateRequest(
            emailAddress: "newuser@hellosign.com"
        );

        try
        {
            var result = apiInstance.AccountCreate(data);
            Console.WriteLine(result);
        }
        catch (ApiException e)
        {
            Console.WriteLine("Exception when calling HelloSign API: " + e.Message);
            Console.WriteLine("Status Code: " + e.ErrorCode);
            Console.WriteLine(e.StackTrace);
        }
    }
}

```

#### Using the AccountCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Account
    ApiResponse<AccountCreateResponse> response = apiInstance.AccountCreateWithHttpInfo(accountCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.AccountCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountCreateRequest** | [**AccountCreateRequest**](AccountCreateRequest.md) |  |  |

### Return type

[**AccountCreateResponse**](AccountCreateResponse.md)

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

<a name="accountget"></a>
# **AccountGet**
> AccountGetResponse AccountGet (string? accountId = null, string? emailAddress = null)

Get Account

Returns the properties and settings of your Account.

### Example
```csharp
using System;

using HelloSign.Api;
using HelloSign.Client;
using HelloSign.Model;

public class Example
{
    public static void Main()
    {
        var config = new Configuration();
        // Configure HTTP basic authorization: api_key
        config.Username = "YOUR_API_KEY";

        // or, configure Bearer (JWT) authorization: oauth2
        // config.AccessToken = "YOUR_BEARER_TOKEN";

        var apiInstance = new AccountApi(config);

        try
        {
            var result = apiInstance.AccountGet(null, "jack@example.com");
            Console.WriteLine(result);
        }
        catch (ApiException e)
        {
            Console.WriteLine("Exception when calling HelloSign API: " + e.Message);
            Console.WriteLine("Status Code: " + e.ErrorCode);
            Console.WriteLine(e.StackTrace);
        }
    }
}

```

#### Using the AccountGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Account
    ApiResponse<AccountGetResponse> response = apiInstance.AccountGetWithHttpInfo(accountId, emailAddress);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.AccountGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string?** | `account_id` or `email_address` is required. If both are provided, the account id prevails.  The ID of the Account. | [optional]  |
| **emailAddress** | **string?** | `account_id` or `email_address` is required, If both are provided, the account id prevails.  The email address of the Account. | [optional]  |

### Return type

[**AccountGetResponse**](AccountGetResponse.md)

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

<a name="accountupdate"></a>
# **AccountUpdate**
> AccountGetResponse AccountUpdate (AccountUpdateRequest accountUpdateRequest)

Update Account

Updates the properties and settings of your Account. Currently only allows for updates to the [Callback URL](/api/reference/tag/Callbacks-and-Events) and locale.

### Example
```csharp
using System;

using HelloSign.Api;
using HelloSign.Client;
using HelloSign.Model;

public class Example
{
    public static void Main()
    {
        var config = new Configuration();
        // Configure HTTP basic authorization: api_key
        config.Username = "YOUR_API_KEY";

        // or, configure Bearer (JWT) authorization: oauth2
        // config.AccessToken = "YOUR_BEARER_TOKEN";

        var apiInstance = new AccountApi(config);

        var data = new AccountUpdateRequest(
            callbackUrl: "https://www.example.com/callback"
        );

        try
        {
            var result = apiInstance.AccountUpdate(data);
            Console.WriteLine(result);
        }
        catch (ApiException e)
        {
            Console.WriteLine("Exception when calling HelloSign API: " + e.Message);
            Console.WriteLine("Status Code: " + e.ErrorCode);
            Console.WriteLine(e.StackTrace);
        }
    }
}

```

#### Using the AccountUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Account
    ApiResponse<AccountGetResponse> response = apiInstance.AccountUpdateWithHttpInfo(accountUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.AccountUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountUpdateRequest** | [**AccountUpdateRequest**](AccountUpdateRequest.md) |  |  |

### Return type

[**AccountGetResponse**](AccountGetResponse.md)

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

<a name="accountverify"></a>
# **AccountVerify**
> AccountVerifyResponse AccountVerify (AccountVerifyRequest accountVerifyRequest)

Verify Account

Verifies whether an Dropbox Sign Account exists for the given email address.

### Example
```csharp
using System;

using HelloSign.Api;
using HelloSign.Client;
using HelloSign.Model;

public class Example
{
    public static void Main()
    {
        var config = new Configuration();
        // Configure HTTP basic authorization: api_key
        config.Username = "YOUR_API_KEY";

        // or, configure Bearer (JWT) authorization: oauth2
        // config.AccessToken = "YOUR_BEARER_TOKEN";

        var apiInstance = new AccountApi(config);

        var data = new AccountVerifyRequest(
            emailAddress: "some_user@hellosign.com"
        );

        try
        {
            var result = apiInstance.AccountVerify(data);
            Console.WriteLine(result);
        }
        catch (ApiException e)
        {
            Console.WriteLine("Exception when calling HelloSign API: " + e.Message);
            Console.WriteLine("Status Code: " + e.ErrorCode);
            Console.WriteLine(e.StackTrace);
        }
    }
}

```

#### Using the AccountVerifyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verify Account
    ApiResponse<AccountVerifyResponse> response = apiInstance.AccountVerifyWithHttpInfo(accountVerifyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.AccountVerifyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountVerifyRequest** | [**AccountVerifyRequest**](AccountVerifyRequest.md) |  |  |

### Return type

[**AccountVerifyResponse**](AccountVerifyResponse.md)

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

