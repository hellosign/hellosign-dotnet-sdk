# HelloSign.Model.SubFormFieldRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Must be unique across all defined rules. REPLACE_ME_WITH_DESCRIPTION_END | 
**TriggerOperator** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Currently only &#x60;AND&#x60; is supported. Support for &#x60;OR&#x60; is being worked on. REPLACE_ME_WITH_DESCRIPTION_END | [default to "AND"]
**Triggers** | [**List&lt;SubFormFieldRuleTrigger&gt;**](SubFormFieldRuleTrigger.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN An array of trigger definitions, the &quot;if this&quot; part of &quot;**if this**, then that&quot;. Currently only a single trigger per rule is allowed. REPLACE_ME_WITH_DESCRIPTION_END | 
**Actions** | [**List&lt;SubFormFieldRuleAction&gt;**](SubFormFieldRuleAction.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN An array of action definitions, the &quot;then that&quot; part of &quot;if this, **then that**&quot;. Any number of actions may be attached to a single rule. REPLACE_ME_WITH_DESCRIPTION_END | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

