# HelloSign.Model.OAuthTokenGenerateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** |  The client id of the app requesting authorization.  | 
**ClientSecret** | **string** |  The secret token of your app.  | 
**Code** | **string** |  The code passed to your callback when the user granted access.  | 
**GrantType** | **string** |  When generating a new token use `authorization_code`.  | [default to "authorization_code"]
**State** | **string** |  Same as the state you specified earlier.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

