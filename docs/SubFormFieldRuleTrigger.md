# HelloSign.Model.SubFormFieldRuleTrigger

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Must reference the &#x60;api_id&#x60; of an existing field defined within &#x60;form_fields_per_document&#x60;. Trigger and action fields and groups must belong to the same signer. REPLACE_ME_WITH_DESCRIPTION_END | 
**Operator** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Different field types allow different &#x60;operator&#x60; values:
- Field type of **text**:
  - **is**: exact match
  - **not**: not exact match
  - **match**: regular expression, without /. Example:
    - OK &#x60;[a-zA-Z0-9]&#x60;
    - Not OK &#x60;/[a-zA-Z0-9]/&#x60;
- Field type of **dropdown**:
  - **is**: exact match, single value
  - **not**: not exact match, single value
  - **any**: exact match, array of values.
  - **none**: not exact match, array of values.
- Field type of **checkbox**:
  - **is**: exact match, single value
  - **not**: not exact match, single value
- Field type of **radio**:
  - **is**: exact match, single value
  - **not**: not exact match, single value REPLACE_ME_WITH_DESCRIPTION_END | 
**Value** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN **value** or **values** is required, but not both.

The value to match against **operator**.

- When **operator** is one of the following, **value** must be &#x60;String&#x60;:
  - &#x60;is&#x60;
  - &#x60;not&#x60;
  - &#x60;match&#x60;

Otherwise,
- **checkbox**: When **type** of trigger is **checkbox**, **value** must be &#x60;0&#x60; or &#x60;1&#x60;
- **radio**: When **type** of trigger is **radio**, **value** must be &#x60;1&#x60; REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Values** | **List&lt;string&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN **values** or **value** is required, but not both.

The values to match against **operator** when it is one of the following:

- &#x60;any&#x60;
- &#x60;none&#x60; REPLACE_ME_WITH_DESCRIPTION_END | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

