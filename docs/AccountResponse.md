# HelloSign.Model.AccountResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** |  The ID of the Account  | [optional] 
**EmailAddress** | **string** |  The email address associated with the Account.  | [optional] 
**IsLocked** | **bool** |  Returns `true` if the user has been locked out of their account by a team admin.  | [optional] 
**IsPaidHs** | **bool** |  Returns `true` if the user has a paid HelloSign account.  | [optional] 
**IsPaidHf** | **bool** |  Returns `true` if the user has a paid HelloFax account.  | [optional] 
**Quotas** | [**AccountResponseQuotas**](AccountResponseQuotas.md) |    | [optional] 
**CallbackUrl** | **string** |  The URL that HelloSign events will `POST` to.  | [optional] 
**RoleCode** | **string** |  The membership role for the team.  | [optional] 
**TeamId** | **string** |  _t__Account::TEAM_ID  | [optional] 
**Locale** | **string** |  The locale used in this Account. Check out the list of [supported locales](/api/reference/constants/#supported-locales) to learn more about the possible values.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

