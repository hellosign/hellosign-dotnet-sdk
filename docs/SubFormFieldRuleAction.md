# HelloSign.Model.SubFormFieldRuleAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hidden** | **bool** |  `true` to hide the target field when rule is satisfied, otherwise `false`.  | 
**Type** | **string** |    | 
**FieldId** | **string** |  **field_id** or **group_id** is required, but not both.<br><br>Must reference the `api_id` of an existing field defined within `form_fields_per_document`.<br><br>Cannot use with `group_id`. Trigger and action fields must belong to the same signer.  | [optional] 
**GroupId** | **string** |  **group_id** or **field_id** is required, but not both.<br><br>Must reference the ID of an existing group defined within `form_field_groups`.<br><br>Cannot use with `field_id`. Trigger and action fields and groups must belong to the same signer.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

