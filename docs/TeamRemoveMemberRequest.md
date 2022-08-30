# HelloSign.Model.TeamRemoveMemberRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** |  **account_id** or **email_address** is required. If both are provided, the account id prevails. <br><br>Account id to remove from your Team.  | [optional] 
**EmailAddress** | **string** |  **account_id** or **email_address** is required. If both are provided, the account id prevails. <br><br>Email address of the Account to remove from your Team.  | [optional] 
**NewOwnerEmailAddress** | **string** |  The email address of an Account on this Team to receive all documents, templates, and API apps (if applicable) from the removed Account. If not provided, and on an Enterprise plan, this data will remain with the removed Account.<br><br>**Note**: Only available for Enterprise plans.  | [optional] 
**NewTeamId** | **string** |  Id of the new Team.  | [optional] 
**NewRole** | **string** |  A new role member will take in a new Team.<br><br>**Note**: This parameter is used only if `new_team_id` is provided.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

