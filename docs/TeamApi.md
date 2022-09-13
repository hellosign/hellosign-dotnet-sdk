# HelloSign.Api.TeamApi

All URIs are relative to *https://api.hellosign.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TeamAddMember**](TeamApi.md#teamaddmember) | **PUT** /team/add_member | Add User to Team |
| [**TeamCreate**](TeamApi.md#teamcreate) | **POST** /team/create | Create Team |
| [**TeamDelete**](TeamApi.md#teamdelete) | **DELETE** /team/destroy | Delete Team |
| [**TeamGet**](TeamApi.md#teamget) | **GET** /team | Get Team |
| [**TeamInfo**](TeamApi.md#teaminfo) | **GET** /team/info | Get Team Info |
| [**TeamMembers**](TeamApi.md#teammembers) | **GET** /team/members/{team_id} | List Team Members |
| [**TeamRemoveMember**](TeamApi.md#teamremovemember) | **POST** /team/remove_member | Remove User from Team |
| [**TeamSubTeams**](TeamApi.md#teamsubteams) | **GET** /team/sub_teams/{team_id} | List Sub Teams |
| [**TeamUpdate**](TeamApi.md#teamupdate) | **PUT** /team | Update Team |

<a name="teamaddmember"></a>
# **TeamAddMember**
> TeamGetResponse TeamAddMember (TeamAddMemberRequest teamAddMemberRequest, string? teamId = null)

Add User to Team

Invites a user (specified using the `email_address` parameter) to your Team. If the user does not currently have a HelloSign Account, a new one will be created for them. If a user is already a part of another Team, a `team_invite_failed` error will be returned.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TeamAddMember_C#_CODE
```

#### Using the TeamAddMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add User to Team
    ApiResponse<TeamGetResponse> response = apiInstance.TeamAddMemberWithHttpInfo(teamAddMemberRequest, teamId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TeamApi.TeamAddMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **teamAddMemberRequest** | [**TeamAddMemberRequest**](TeamAddMemberRequest.md) |  |  |
| **teamId** | **string?** | The id of the team. | [optional]  |

### Return type

[**TeamGetResponse**](TeamGetResponse.md)

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

<a name="teamcreate"></a>
# **TeamCreate**
> TeamGetResponse TeamCreate (TeamCreateRequest teamCreateRequest)

Create Team

Creates a new Team and makes you a member. You must not currently belong to a Team to invoke.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TeamCreate_C#_CODE
```

#### Using the TeamCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Team
    ApiResponse<TeamGetResponse> response = apiInstance.TeamCreateWithHttpInfo(teamCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TeamApi.TeamCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **teamCreateRequest** | [**TeamCreateRequest**](TeamCreateRequest.md) |  |  |

### Return type

[**TeamGetResponse**](TeamGetResponse.md)

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

<a name="teamdelete"></a>
# **TeamDelete**
> void TeamDelete ()

Delete Team

Deletes your Team. Can only be invoked when you have a Team with only one member (yourself).

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TeamDelete_C#_CODE
```

#### Using the TeamDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Team
    apiInstance.TeamDeleteWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TeamApi.TeamDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a name="teamget"></a>
# **TeamGet**
> TeamGetResponse TeamGet ()

Get Team

Returns information about your Team as well as a list of its members. If you do not belong to a Team, a 404 error with an error_name of \"not_found\" will be returned.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TeamGet_C#_CODE
```

#### Using the TeamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Team
    ApiResponse<TeamGetResponse> response = apiInstance.TeamGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TeamApi.TeamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TeamGetResponse**](TeamGetResponse.md)

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

<a name="teaminfo"></a>
# **TeamInfo**
> TeamGetInfoResponse TeamInfo (string? teamId = null)

Get Team Info

Provides information about a team.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TeamInfo_C#_CODE
```

#### Using the TeamInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Team Info
    ApiResponse<TeamGetInfoResponse> response = apiInstance.TeamInfoWithHttpInfo(teamId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TeamApi.TeamInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **teamId** | **string?** | The id of the team. | [optional]  |

### Return type

[**TeamGetInfoResponse**](TeamGetInfoResponse.md)

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

<a name="teammembers"></a>
# **TeamMembers**
> TeamMembersResponse TeamMembers (string teamId, int? page = null, int? pageSize = null)

List Team Members

Provides a paginated list of members (and their roles) that belong to a given team.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TeamMembers_C#_CODE
```

#### Using the TeamMembersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Team Members
    ApiResponse<TeamMembersResponse> response = apiInstance.TeamMembersWithHttpInfo(teamId, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TeamApi.TeamMembersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **teamId** | **string** | The id of the team that a member list is being requested from. |  |
| **page** | **int?** | Which page number of the team member list to return. Defaults to &#x60;1&#x60;. | [optional] [default to 1] |
| **pageSize** | **int?** | Number of objects to be returned per page. Must be between &#x60;1&#x60; and &#x60;100&#x60;. Default is &#x60;20&#x60;. | [optional] [default to 20] |

### Return type

[**TeamMembersResponse**](TeamMembersResponse.md)

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

<a name="teamremovemember"></a>
# **TeamRemoveMember**
> TeamGetResponse TeamRemoveMember (TeamRemoveMemberRequest teamRemoveMemberRequest)

Remove User from Team

Removes the provided user Account from your Team. If the Account had an outstanding invitation to your Team, the invitation will be expired. If you choose to transfer documents from the removed Account to an Account provided in the `new_owner_email_address` parameter (available only for Enterprise plans), the response status code will be 201, which indicates that your request has been queued but not fully executed.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TeamRemoveMember_C#_CODE
```

#### Using the TeamRemoveMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove User from Team
    ApiResponse<TeamGetResponse> response = apiInstance.TeamRemoveMemberWithHttpInfo(teamRemoveMemberRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TeamApi.TeamRemoveMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **teamRemoveMemberRequest** | [**TeamRemoveMemberRequest**](TeamRemoveMemberRequest.md) |  |  |

### Return type

[**TeamGetResponse**](TeamGetResponse.md)

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

<a name="teamsubteams"></a>
# **TeamSubTeams**
> TeamSubTeamsResponse TeamSubTeams (string teamId, int? page = null, int? pageSize = null)

List Sub Teams

Provides a paginated list of sub teams that belong to a given team.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TeamSubTeams_C#_CODE
```

#### Using the TeamSubTeamsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Sub Teams
    ApiResponse<TeamSubTeamsResponse> response = apiInstance.TeamSubTeamsWithHttpInfo(teamId, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TeamApi.TeamSubTeamsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **teamId** | **string** | The id of the parent Team. |  |
| **page** | **int?** | Which page number of the SubTeam List to return. Defaults to &#x60;1&#x60;. | [optional] [default to 1] |
| **pageSize** | **int?** | Number of objects to be returned per page. Must be between &#x60;1&#x60; and &#x60;100&#x60;. Default is &#x60;20&#x60;. | [optional] [default to 20] |

### Return type

[**TeamSubTeamsResponse**](TeamSubTeamsResponse.md)

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

<a name="teamupdate"></a>
# **TeamUpdate**
> TeamGetResponse TeamUpdate (TeamUpdateRequest teamUpdateRequest)

Update Team

Updates the name of your Team.

### Example
```csharp
REPLACE_ME_WITH_EXAMPLE_FOR__TeamUpdate_C#_CODE
```

#### Using the TeamUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Team
    ApiResponse<TeamGetResponse> response = apiInstance.TeamUpdateWithHttpInfo(teamUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TeamApi.TeamUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **teamUpdateRequest** | [**TeamUpdateRequest**](TeamUpdateRequest.md) |  |  |

### Return type

[**TeamGetResponse**](TeamGetResponse.md)

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

