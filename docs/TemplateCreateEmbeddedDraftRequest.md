# HelloSign.Model.TemplateCreateEmbeddedDraftRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** |  Client id of the app you&#39;re using to create this draft. Used to apply the branding and callback url defined for the app.  | 
**File** | **List&lt;System.IO.Stream&gt;** |  Use `file[]` to indicate the uploaded file(s) to send for signature.<br><br>This endpoint requires either **file** or **file_url[]**, but not both.  | [optional] 
**FileUrl** | **List&lt;string&gt;** |  Use `file_url[]` to have Dropbox Sign download the file(s) to send for signature.<br><br>This endpoint requires either **file** or **file_url[]**, but not both.  | [optional] 
**AllowCcs** | **bool** |  This allows the requester to specify whether the user is allowed to provide email addresses to CC when creating a template.  | [optional] [default to true]
**AllowReassign** | **bool** |  Allows signers to reassign their signature requests to other signers if set to `true`. Defaults to `false`.<br><br>**Note**: Only available for Premium plan and higher.  | [optional] [default to false]
**Attachments** | [**List&lt;SubAttachment&gt;**](SubAttachment.md) |  A list describing the attachments  | [optional] 
**CcRoles** | **List&lt;string&gt;** |  The CC roles that must be assigned when using the template to send a signature request  | [optional] 
**EditorOptions** | [**SubEditorOptions**](SubEditorOptions.md) |    | [optional] 
**FieldOptions** | [**SubFieldOptions**](SubFieldOptions.md) |    | [optional] 
**ForceSignerRoles** | **bool** |  Provide users the ability to review/edit the template signer roles.  | [optional] [default to false]
**ForceSubjectMessage** | **bool** |  Provide users the ability to review/edit the template subject and message.  | [optional] [default to false]
**FormFieldGroups** | [**List&lt;SubFormFieldGroup&gt;**](SubFormFieldGroup.md) |  Group information for fields defined in `form_fields_per_document`. String-indexed JSON array with `group_label` and `requirement` keys. `form_fields_per_document` must contain fields referencing a group defined in `form_field_groups`.  | [optional] 
**FormFieldRules** | [**List&lt;SubFormFieldRule&gt;**](SubFormFieldRule.md) |  Conditional Logic rules for fields defined in `form_fields_per_document`.  | [optional] 
**FormFieldsPerDocument** | [**List&lt;SubFormFieldsPerDocumentBase&gt;**](SubFormFieldsPerDocumentBase.md) |  The fields that should appear on the document, expressed as an array of objects. (We&#39;re currently fixing a bug where this property only accepts a two-dimensional array. You can read about it here: &lt;a href&#x3D;&quot;/docs/placing-fields/form-fields-per-document&quot; target&#x3D;&quot;_blank&quot;&gt;Using Form Fields per Document&lt;/a&gt;.)<br><br>**NOTE**: Fields like **text**, **dropdown**, **checkbox**, **radio**, and **hyperlink** have additional required and optional parameters. Check out the list of [additional parameters](/api/reference/constants/#form-fields-per-document) for these field types.<br><br>* Text Field use `SubFormFieldsPerDocumentText`<br>* Dropdown Field use `SubFormFieldsPerDocumentDropdown`<br>* Hyperlink Field use `SubFormFieldsPerDocumentHyperlink`<br>* Checkbox Field use `SubFormFieldsPerDocumentCheckbox`<br>* Radio Field use `SubFormFieldsPerDocumentRadio`<br>* Signature Field use `SubFormFieldsPerDocumentSignature`<br>* Date Signed Field use `SubFormFieldsPerDocumentDateSigned`<br>* Initials Field use `SubFormFieldsPerDocumentInitials`<br>* Text Merge Field use `SubFormFieldsPerDocumentTextMerge`<br>* Checkbox Merge Field use `SubFormFieldsPerDocumentCheckboxMerge`  | [optional] 
**MergeFields** | [**List&lt;SubMergeField&gt;**](SubMergeField.md) |  Add merge fields to the template. Merge fields are placed by the user creating the template and used to pre-fill data by passing values into signature requests with the `custom_fields` parameter. If the signature request using that template *does not* pass a value into a merge field, then an empty field remains in the document.  | [optional] 
**Message** | **string** |  The default template email message.  | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** |  Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.<br><br>Each request can include up to 10 metadata keys (or 50 nested metadata keys), with key names up to 40 characters long and values up to 1000 characters long.  | [optional] 
**ShowPreview** | **bool** |  This allows the requester to enable the editor/preview experience.<br><br>- `show_preview&#x3D;true`: Allows requesters to enable the editor/preview experience. - `show_preview&#x3D;false`: Allows requesters to disable the editor/preview experience.  | [optional] [default to false]
**ShowProgressStepper** | **bool** |  When only one step remains in the signature request process and this parameter is set to `false` then the progress stepper will be hidden.  | [optional] [default to true]
**SignerRoles** | [**List&lt;SubTemplateRole&gt;**](SubTemplateRole.md) |  An array of the designated signer roles that must be specified when sending a SignatureRequest using this Template.  | [optional] 
**SkipMeNow** | **bool** |  Disables the &quot;Me (Now)&quot; option for the person preparing the document. Does not work with type `send_document`. Defaults to `false`.  | [optional] [default to false]
**Subject** | **string** |  The template title (alias).  | [optional] 
**TestMode** | **bool** |  Whether this is a test, the signature request created from this draft will not be legally binding if set to `true`. Defaults to `false`.  | [optional] [default to false]
**Title** | **string** |  The title you want to assign to the SignatureRequest.  | [optional] 
**UsePreexistingFields** | **bool** |  Enable the detection of predefined PDF fields by setting the `use_preexisting_fields` to `true` (defaults to disabled, or `false`).  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

