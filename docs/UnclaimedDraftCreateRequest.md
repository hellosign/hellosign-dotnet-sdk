# HelloSign.Model.UnclaimedDraftCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The type of unclaimed draft to create. Use &#x60;send_document&#x60; to create a claimable file, and &#x60;request_signature&#x60; for a claimable signature request. If the type is &#x60;request_signature&#x60; then signers name and email_address are not optional. REPLACE_ME_WITH_DESCRIPTION_END | 
**File** | **List&lt;System.IO.Stream&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Use &#x60;file[]&#x60; to indicate the uploaded file(s) to send for signature.

This endpoint requires either **file** or **file_url[]**, but not both. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**FileUrl** | **List&lt;string&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Use &#x60;file_url[]&#x60; to have HelloSign download the file(s) to send for signature.

This endpoint requires either **file** or **file_url[]**, but not both. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**AllowDecline** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Allows signers to decline to sign a document if &#x60;true&#x60;. Defaults to &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**Attachments** | [**List&lt;SubAttachment&gt;**](SubAttachment.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN A list describing the attachments REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**CcEmailAddresses** | **List&lt;string&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The email addresses that should be CCed. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**ClientId** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Client id of the app used to create the draft. Used to apply the branding and callback url defined for the app. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**CustomFields** | [**List&lt;SubCustomField&gt;**](SubCustomField.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN When used together with merge fields, &#x60;custom_fields&#x60; allows users to add pre-filled data to their signature requests.

Pre-filled data can be used with &quot;send-once&quot; signature requests by adding merge fields with &#x60;form_fields_per_document&#x60; or [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) while passing values back with &#x60;custom_fields&#x60; together in one API call.

For using pre-filled on repeatable signature requests, merge fields are added to templates in the HelloSign UI or by calling [/template/create_embedded_draft](/api/reference/operation/templateCreateEmbeddedDraft) and then passing &#x60;custom_fields&#x60; on subsequent signature requests referencing that template. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**FieldOptions** | [**SubFieldOptions**](SubFieldOptions.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN  REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**FormFieldGroups** | [**List&lt;SubFormFieldGroup&gt;**](SubFormFieldGroup.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN Group information for fields defined in &#x60;form_fields_per_document&#x60;. String-indexed JSON array with &#x60;group_label&#x60; and &#x60;requirement&#x60; keys. &#x60;form_fields_per_document&#x60; must contain fields referencing a group defined in &#x60;form_field_groups&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**FormFieldRules** | [**List&lt;SubFormFieldRule&gt;**](SubFormFieldRule.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN Conditional Logic rules for fields defined in &#x60;form_fields_per_document&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**FormFieldsPerDocument** | [**List&lt;SubFormFieldsPerDocumentBase&gt;**](SubFormFieldsPerDocumentBase.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN The fields that should appear on the document, expressed as an array of objects. (We&#39;re currently fixing a bug where this property only accepts a two-dimensional array. You can read about it here: &lt;a href&#x3D;&quot;/docs/placing-fields/form-fields-per-document&quot; target&#x3D;&quot;_blank&quot;&gt;Using Form Fields per Document&lt;/a&gt;.)

**NOTE**: Fields like **text**, **dropdown**, **checkbox**, **radio**, and **hyperlink** have additional required and optional parameters. Check out the list of [additional parameters](/api/reference/constants/#form-fields-per-document) for these field types.

* Text Field use &#x60;SubFormFieldsPerDocumentText&#x60;
* Dropdown Field use &#x60;SubFormFieldsPerDocumentDropdown&#x60;
* Hyperlink Field use &#x60;SubFormFieldsPerDocumentHyperlink&#x60;
* Checkbox Field use &#x60;SubFormFieldsPerDocumentCheckbox&#x60;
* Radio Field use &#x60;SubFormFieldsPerDocumentRadio&#x60;
* Signature Field use &#x60;SubFormFieldsPerDocumentSignature&#x60;
* Date Signed Field use &#x60;SubFormFieldsPerDocumentDateSigned&#x60;
* Initials Field use &#x60;SubFormFieldsPerDocumentInitials&#x60;
* Text Merge Field use &#x60;SubFormFieldsPerDocumentTextMerge&#x60;
* Checkbox Merge Field use &#x60;SubFormFieldsPerDocumentCheckboxMerge&#x60; REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**HideTextTags** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Send with a value of &#x60;true&#x60; if you wish to enable automatic Text Tag removal. Defaults to &#x60;false&#x60;. When using Text Tags it is preferred that you set this to &#x60;false&#x60; and hide your tags with white text or something similar because the automatic removal system can cause unwanted clipping. See the [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) walkthrough for more details. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**Message** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The custom message in the email that will be sent to the signers. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.

Each request can include up to 10 metadata keys (or 50 nested metadata keys), with key names up to 40 characters long and values up to 1000 characters long. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**ShowProgressStepper** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN When only one step remains in the signature request process and this parameter is set to &#x60;false&#x60; then the progress stepper will be hidden. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to true]
**Signers** | [**List&lt;SubUnclaimedDraftSigner&gt;**](SubUnclaimedDraftSigner.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN Add Signers to your Unclaimed Draft Signature Request. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SigningOptions** | [**SubSigningOptions**](SubSigningOptions.md) | REPLACE_ME_WITH_DESCRIPTION_BEGIN  REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**SigningRedirectUrl** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The URL you want signers redirected to after they successfully sign. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**Subject** | **string** | REPLACE_ME_WITH_DESCRIPTION_BEGIN The subject in the email that will be sent to the signers. REPLACE_ME_WITH_DESCRIPTION_END | [optional] 
**TestMode** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Whether this is a test, the signature request created from this draft will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**UsePreexistingFields** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Set &#x60;use_text_tags&#x60; to &#x60;true&#x60; to enable [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) parsing in your document (defaults to disabled, or &#x60;false&#x60;). Alternatively, if your PDF contains pre-defined fields, enable the detection of these fields by setting the &#x60;use_preexisting_fields&#x60; to &#x60;true&#x60; (defaults to disabled, or &#x60;false&#x60;). Currently we only support use of either &#x60;use_text_tags&#x60; or &#x60;use_preexisting_fields&#x60; parameter, not both. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]
**UseTextTags** | **bool** | REPLACE_ME_WITH_DESCRIPTION_BEGIN Set &#x60;use_text_tags&#x60; to &#x60;true&#x60; to enable [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) parsing in your document (defaults to disabled, or &#x60;false&#x60;). Alternatively, if your PDF contains pre-defined fields, enable the detection of these fields by setting the &#x60;use_preexisting_fields&#x60; to &#x60;true&#x60; (defaults to disabled, or &#x60;false&#x60;). Currently we only support use of either &#x60;use_text_tags&#x60; or &#x60;use_preexisting_fields&#x60; parameter, not both. REPLACE_ME_WITH_DESCRIPTION_END | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

