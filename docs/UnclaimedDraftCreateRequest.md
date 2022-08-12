# Org.HelloSign.Model.UnclaimedDraftCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  The type of unclaimed draft to create. Use `send_document` to create a claimable file, and `request_signature` for a claimable signature request. If the type is `request_signature` then signers name and email_address are not optional.  | 
**File** | **List&lt;System.IO.Stream&gt;** |  Use `file[]` to indicate the uploaded file(s) to send for signature.<br><br>This endpoint requires either **file** or **file_url[]**, but not both.  | [optional] 
**FileUrl** | **List&lt;string&gt;** |  Use `file_url[]` to have HelloSign download the file(s) to send for signature.<br><br>This endpoint requires either **file** or **file_url[]**, but not both.  | [optional] 
**AllowDecline** | **bool** |  Allows signers to decline to sign a document if `true`. Defaults to `false`.  | [optional] [default to false]
**Attachments** | [**List&lt;SubAttachment&gt;**](SubAttachment.md) |  A list describing the attachments  | [optional] 
**CcEmailAddresses** | **List&lt;string&gt;** |  The email addresses that should be CCed.  | [optional] 
**ClientId** | **string** |  Client id of the app used to create the draft. Used to apply the branding and callback url defined for the app.  | [optional] 
**CustomFields** | [**List&lt;SubCustomField&gt;**](SubCustomField.md) |  When used together with merge fields, `custom_fields` allows users to add pre-filled data to their signature requests.<br><br>Pre-filled data can be used with &quot;send-once&quot; signature requests by adding merge fields with `form_fields_per_document` or [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) while passing values back with `custom_fields` together in one API call.<br><br>For using pre-filled on repeatable signature requests, merge fields are added to templates in the HelloSign UI or by calling [/template/create_embedded_draft](/api/reference/operation/templateCreateEmbeddedDraft) and then passing `custom_fields` on subsequent signature requests referencing that template.  | [optional] 
**FieldOptions** | [**SubFieldOptions**](SubFieldOptions.md) |    | [optional] 
**FormFieldGroups** | [**List&lt;SubFormFieldGroup&gt;**](SubFormFieldGroup.md) |  Group information for fields defined in `form_fields_per_document`. String-indexed JSON array with `group_label` and `requirement` keys. `form_fields_per_document` must contain fields referencing a group defined in `form_field_groups`.  | [optional] 
**FormFieldRules** | [**List&lt;SubFormFieldRule&gt;**](SubFormFieldRule.md) |  Conditional Logic rules for fields defined in `form_fields_per_document`.  | [optional] 
**FormFieldsPerDocument** | [**List&lt;SubFormFieldsPerDocumentBase&gt;**](SubFormFieldsPerDocumentBase.md) |  The fields that should appear on the document, expressed as an array of objects.<br><br>**NOTE**: Fields like **text**, **dropdown**, **checkbox**, **radio**, and **hyperlink** have additional required and optional parameters. Check out the list of [additional parameters](/api/reference/constants/#form-fields-per-document) for these field types.<br><br>* Text Field use `SubFormFieldsPerDocumentText`<br>* Dropdown Field use `SubFormFieldsPerDocumentDropdown`<br>* Hyperlink Field use `SubFormFieldsPerDocumentHyperlink`<br>* Checkbox Field use `SubFormFieldsPerDocumentCheckbox`<br>* Radio Field use `SubFormFieldsPerDocumentRadio`<br>* Signature Field use `SubFormFieldsPerDocumentSignature`<br>* Date Signed Field use `SubFormFieldsPerDocumentDateSigned`<br>* Initials Field use `SubFormFieldsPerDocumentInitials`<br>* Text Merge Field use `SubFormFieldsPerDocumentTextMerge`<br>* Checkbox Merge Field use `SubFormFieldsPerDocumentCheckboxMerge`  | [optional] 
**HideTextTags** | **bool** |  Send with a value of `true` if you wish to enable automatic Text Tag removal. Defaults to `false`. When using Text Tags it is preferred that you set this to `false` and hide your tags with white text or something similar because the automatic removal system can cause unwanted clipping. See the [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) walkthrough for more details.  | [optional] [default to false]
**Message** | **string** |  The custom message in the email that will be sent to the signers.  | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** |  Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.<br><br>Each request can include up to 10 metadata keys, with key names up to 40 characters long and values up to 1000 characters long.  | [optional] 
**ShowProgressStepper** | **bool** |  When only one step remains in the signature request process and this parameter is set to `false` then the progress stepper will be hidden.  | [optional] [default to true]
**Signers** | [**List&lt;SubUnclaimedDraftSigner&gt;**](SubUnclaimedDraftSigner.md) |  Add Signers to your Unclaimed Draft Signature Request.  | [optional] 
**SigningOptions** | [**SubSigningOptions**](SubSigningOptions.md) |    | [optional] 
**SigningRedirectUrl** | **string** |  The URL you want signers redirected to after they successfully sign.  | [optional] 
**Subject** | **string** |  The subject in the email that will be sent to the signers.  | [optional] 
**TestMode** | **bool** |  Whether this is a test, the signature request created from this draft will not be legally binding if set to `true`. Defaults to `false`.  | [optional] [default to false]
**UsePreexistingFields** | **bool** |  Set `use_text_tags` to `true` to enable [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) parsing in your document (defaults to disabled, or `false`). Alternatively, if your PDF contains pre-defined fields, enable the detection of these fields by setting the `use_preexisting_fields` to `true` (defaults to disabled, or `false`). Currently we only support use of either `use_text_tags` or `use_preexisting_fields` parameter, not both.  | [optional] [default to false]
**UseTextTags** | **bool** |  Set `use_text_tags` to `true` to enable [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) parsing in your document (defaults to disabled, or `false`). Alternatively, if your PDF contains pre-defined fields, enable the detection of these fields by setting the `use_preexisting_fields` to `true` (defaults to disabled, or `false`). Currently we only support use of either `use_text_tags` or `use_preexisting_fields` parameter, not both.  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
