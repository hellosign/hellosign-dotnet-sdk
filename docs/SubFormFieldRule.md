# HelloSign.Model.SubFormFieldRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  Must be unique across all defined rules.  | 
**TriggerOperator** | **string** |  Currently only `AND` is supported. Support for `OR` is being worked on.  | [default to "AND"]
**Triggers** | [**List&lt;SubFormFieldRuleTrigger&gt;**](SubFormFieldRuleTrigger.md) |  An array of trigger definitions, the &quot;if this&quot; part of &quot;**if this**, then that&quot;. Currently only a single trigger per rule is allowed.  | 
**Actions** | [**List&lt;SubFormFieldRuleAction&gt;**](SubFormFieldRuleAction.md) |  An array of action definitions, the &quot;then that&quot; part of &quot;if this, **then that**&quot;. Any number of actions may be attached to a single rule.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

