# HelloSign.Model.TeamRemoveMemberRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN **account_id** or **email_address** is required. If both are provided, the account id prevails. 

Account id to remove from your Team. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**EmailAddress** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN **account_id** or **email_address** is required. If both are provided, the account id prevails. 

Email address of the Account to remove from your Team. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**NewOwnerEmailAddress** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The email address of an Account on this Team to receive all documents, templates, and API apps (if applicable) from the removed Account. If not provided, and on an Enterprise plan, this data will remain with the removed Account.

**Note**: Only available for Enterprise plans. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**NewTeamId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Id of the new Team. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**NewRole** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN A new role member will take in a new Team.

**Note**: This parameter is used only if &#x60;new_team_id&#x60; is provided. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

