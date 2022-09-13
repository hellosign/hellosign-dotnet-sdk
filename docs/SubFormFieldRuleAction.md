# HelloSign.Model.SubFormFieldRuleAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hidden** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN &#x60;true&#x60; to hide the target field when rule is satisfied, otherwise &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | 
**Type** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN  REPLACE_ME_WITH_DESCRIPTION_END | 
**FieldId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN **field_id** or **group_id** is required, but not both.

Must reference the &#x60;api_id&#x60; of an existing field defined within &#x60;form_fields_per_document&#x60;.

Cannot use with &#x60;group_id&#x60;. Trigger and action fields must belong to the same signer. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**GroupId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN **group_id** or **field_id** is required, but not both.

Must reference the ID of an existing group defined within &#x60;form_field_groups&#x60;.

Cannot use with &#x60;field_id&#x60;. Trigger and action fields and groups must belong to the same signer. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

