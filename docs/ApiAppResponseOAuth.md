# HelloSign.Model.ApiAppResponseOAuth
An object describing the app's OAuth properties, or null if OAuth is not configured for the app.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallbackUrl** | **string** |  The app&#39;s OAuth callback URL.  | [optional] 
**Secret** | **string** |  The app&#39;s OAuth secret, or null if the app does not belong to user.  | [optional] 
**Scopes** | **List&lt;string&gt;** |  Array of OAuth scopes used by the app.  | [optional] 
**ChargesUsers** | **bool** |  Boolean indicating whether the app owner or the account granting permission is billed for OAuth requests.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

