# HelloSign.Model.SubFormFieldRuleTrigger

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  Must reference the `api_id` of an existing field defined within `form_fields_per_document`. Trigger and action fields and groups must belong to the same signer.  | 
**Operator** | **string** |  Different field types allow different `operator` values: - Field type of **text**:   - **is**: exact match   - **not**: not exact match   - **match**: regular expression, without /. Example:     - OK `[a-zA-Z0-9]`     - Not OK `/[a-zA-Z0-9]/` - Field type of **dropdown**:   - **is**: exact match, single value   - **not**: not exact match, single value   - **any**: exact match, array of values.   - **none**: not exact match, array of values. - Field type of **checkbox**:   - **is**: exact match, single value   - **not**: not exact match, single value - Field type of **radio**:   - **is**: exact match, single value   - **not**: not exact match, single value  | 
**Value** | **string** |  **value** or **values** is required, but not both.<br><br>The value to match against **operator**.<br><br>- When **operator** is one of the following, **value** must be `String`:   - `is`   - `not`   - `match`<br><br>Otherwise, - **checkbox**: When **type** of trigger is **checkbox**, **value** must be `0` or `1` - **radio**: When **type** of trigger is **radio**, **value** must be `1`  | [optional] 
**Values** | **List&lt;string&gt;** |  **values** or **value** is required, but not both.<br><br>The values to match against **operator** when it is one of the following:<br><br>- `any` - `none`  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

