/*
 * HelloSign API
 *
 * HelloSign v3 API
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: apisupport@hellosign.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = HelloSign.Client.OpenAPIDateConverter;

namespace HelloSign.Model
{
    /// <summary>
    /// BulkSendJobGetResponseSignatureRequests
    /// </summary>
    [DataContract(Name = "BulkSendJobGetResponseSignatureRequests")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class BulkSendJobGetResponseSignatureRequests : IOpenApiTyped, IEquatable<BulkSendJobGetResponseSignatureRequests>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSendJobGetResponseSignatureRequests" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkSendJobGetResponseSignatureRequests() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSendJobGetResponseSignatureRequests" /> class.
        /// </summary>
        /// <param name="testMode">Whether this is a test signature request. Test requests have no legal value. Defaults to &#x60;false&#x60;. (default to false).</param>
        /// <param name="signatureRequestId">The id of the SignatureRequest..</param>
        /// <param name="requesterEmailAddress">The email address of the initiator of the SignatureRequest..</param>
        /// <param name="title">The title the specified Account uses for the SignatureRequest..</param>
        /// <param name="originalTitle">Default Label for account..</param>
        /// <param name="subject">The subject in the email that was initially sent to the signers..</param>
        /// <param name="message">The custom message in the email that was initially sent to the signers..</param>
        /// <param name="metadata">The metadata attached to the signature request..</param>
        /// <param name="createdAt">Time the signature request was created..</param>
        /// <param name="isComplete">Whether or not the SignatureRequest has been fully executed by all signers..</param>
        /// <param name="isDeclined">Whether or not the SignatureRequest has been declined by a signer..</param>
        /// <param name="hasError">Whether or not an error occurred (either during the creation of the SignatureRequest or during one of the signings)..</param>
        /// <param name="filesUrl">The URL where a copy of the request&#39;s documents can be downloaded..</param>
        /// <param name="signingUrl">The URL where a signer, after authenticating, can sign the documents. This should only be used by users with existing HelloSign accounts as they will be required to log in before signing..</param>
        /// <param name="detailsUrl">The URL where the requester and the signers can view the current status of the SignatureRequest..</param>
        /// <param name="ccEmailAddresses">A list of email addresses that were CCed on the SignatureRequest. They will receive a copy of the final PDF once all the signers have signed..</param>
        /// <param name="signingRedirectUrl">The URL you want the signer redirected to after they successfully sign..</param>
        /// <param name="templateIds">Templates IDs used in this SignatureRequest (if any)..</param>
        /// <param name="customFields">An array of Custom Field objects containing the name and type of each custom field.  * Text Field uses &#x60;SignatureRequestResponseCustomFieldText&#x60; * Checkbox Field uses &#x60;SignatureRequestResponseCustomFieldCheckbox&#x60;.</param>
        /// <param name="attachments">Signer attachments..</param>
        /// <param name="responseData">An array of form field objects containing the name, value, and type of each textbox or checkmark field filled in by the signers..</param>
        /// <param name="signatures">An array of signature objects, 1 for each signer..</param>
        /// <param name="bulkSendJobId">The id of the BulkSendJob..</param>
        public BulkSendJobGetResponseSignatureRequests(bool? testMode = false, string signatureRequestId = default(string), string requesterEmailAddress = default(string), string title = default(string), string originalTitle = default(string), string subject = default(string), string message = default(string), Object metadata = default(Object), int createdAt = default(int), bool isComplete = default(bool), bool isDeclined = default(bool), bool hasError = default(bool), string filesUrl = default(string), string signingUrl = default(string), string detailsUrl = default(string), List<string> ccEmailAddresses = default(List<string>), string signingRedirectUrl = default(string), List<string> templateIds = default(List<string>), List<SignatureRequestResponseCustomFieldBase> customFields = default(List<SignatureRequestResponseCustomFieldBase>), List<SignatureRequestResponseAttachment> attachments = default(List<SignatureRequestResponseAttachment>), List<SignatureRequestResponseDataBase> responseData = default(List<SignatureRequestResponseDataBase>), List<SignatureRequestResponseSignatures> signatures = default(List<SignatureRequestResponseSignatures>), string bulkSendJobId = default(string))
        {
            
            // use default value if no "testMode" provided
            this.TestMode = testMode ?? false;
            this.SignatureRequestId = signatureRequestId;
            this.RequesterEmailAddress = requesterEmailAddress;
            this.Title = title;
            this.OriginalTitle = originalTitle;
            this.Subject = subject;
            this.Message = message;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.IsComplete = isComplete;
            this.IsDeclined = isDeclined;
            this.HasError = hasError;
            this.FilesUrl = filesUrl;
            this.SigningUrl = signingUrl;
            this.DetailsUrl = detailsUrl;
            this.CcEmailAddresses = ccEmailAddresses;
            this.SigningRedirectUrl = signingRedirectUrl;
            this.TemplateIds = templateIds;
            this.CustomFields = customFields;
            this.Attachments = attachments;
            this.ResponseData = responseData;
            this.Signatures = signatures;
            this.BulkSendJobId = bulkSendJobId;
        }

        /// <summary>
        /// Whether this is a test signature request. Test requests have no legal value. Defaults to &#x60;false&#x60;.
        /// </summary>
        /// <value>Whether this is a test signature request. Test requests have no legal value. Defaults to &#x60;false&#x60;.</value>
        [DataMember(Name = "test_mode", EmitDefaultValue = true)]
        public bool? TestMode { get; set; }

        /// <summary>
        /// The id of the SignatureRequest.
        /// </summary>
        /// <value>The id of the SignatureRequest.</value>
        [DataMember(Name = "signature_request_id", EmitDefaultValue = true)]
        public string SignatureRequestId { get; set; }

        /// <summary>
        /// The email address of the initiator of the SignatureRequest.
        /// </summary>
        /// <value>The email address of the initiator of the SignatureRequest.</value>
        [DataMember(Name = "requester_email_address", EmitDefaultValue = true)]
        public string RequesterEmailAddress { get; set; }

        /// <summary>
        /// The title the specified Account uses for the SignatureRequest.
        /// </summary>
        /// <value>The title the specified Account uses for the SignatureRequest.</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Default Label for account.
        /// </summary>
        /// <value>Default Label for account.</value>
        [DataMember(Name = "original_title", EmitDefaultValue = true)]
        public string OriginalTitle { get; set; }

        /// <summary>
        /// The subject in the email that was initially sent to the signers.
        /// </summary>
        /// <value>The subject in the email that was initially sent to the signers.</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// The custom message in the email that was initially sent to the signers.
        /// </summary>
        /// <value>The custom message in the email that was initially sent to the signers.</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// The metadata attached to the signature request.
        /// </summary>
        /// <value>The metadata attached to the signature request.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Time the signature request was created.
        /// </summary>
        /// <value>Time the signature request was created.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public int CreatedAt { get; set; }

        /// <summary>
        /// Whether or not the SignatureRequest has been fully executed by all signers.
        /// </summary>
        /// <value>Whether or not the SignatureRequest has been fully executed by all signers.</value>
        [DataMember(Name = "is_complete", EmitDefaultValue = true)]
        public bool IsComplete { get; set; }

        /// <summary>
        /// Whether or not the SignatureRequest has been declined by a signer.
        /// </summary>
        /// <value>Whether or not the SignatureRequest has been declined by a signer.</value>
        [DataMember(Name = "is_declined", EmitDefaultValue = true)]
        public bool IsDeclined { get; set; }

        /// <summary>
        /// Whether or not an error occurred (either during the creation of the SignatureRequest or during one of the signings).
        /// </summary>
        /// <value>Whether or not an error occurred (either during the creation of the SignatureRequest or during one of the signings).</value>
        [DataMember(Name = "has_error", EmitDefaultValue = true)]
        public bool HasError { get; set; }

        /// <summary>
        /// The URL where a copy of the request&#39;s documents can be downloaded.
        /// </summary>
        /// <value>The URL where a copy of the request&#39;s documents can be downloaded.</value>
        [DataMember(Name = "files_url", EmitDefaultValue = true)]
        public string FilesUrl { get; set; }

        /// <summary>
        /// The URL where a signer, after authenticating, can sign the documents. This should only be used by users with existing HelloSign accounts as they will be required to log in before signing.
        /// </summary>
        /// <value>The URL where a signer, after authenticating, can sign the documents. This should only be used by users with existing HelloSign accounts as they will be required to log in before signing.</value>
        [DataMember(Name = "signing_url", EmitDefaultValue = true)]
        public string SigningUrl { get; set; }

        /// <summary>
        /// The URL where the requester and the signers can view the current status of the SignatureRequest.
        /// </summary>
        /// <value>The URL where the requester and the signers can view the current status of the SignatureRequest.</value>
        [DataMember(Name = "details_url", EmitDefaultValue = true)]
        public string DetailsUrl { get; set; }

        /// <summary>
        /// A list of email addresses that were CCed on the SignatureRequest. They will receive a copy of the final PDF once all the signers have signed.
        /// </summary>
        /// <value>A list of email addresses that were CCed on the SignatureRequest. They will receive a copy of the final PDF once all the signers have signed.</value>
        [DataMember(Name = "cc_email_addresses", EmitDefaultValue = true)]
        public List<string> CcEmailAddresses { get; set; }

        /// <summary>
        /// The URL you want the signer redirected to after they successfully sign.
        /// </summary>
        /// <value>The URL you want the signer redirected to after they successfully sign.</value>
        [DataMember(Name = "signing_redirect_url", EmitDefaultValue = true)]
        public string SigningRedirectUrl { get; set; }

        /// <summary>
        /// Templates IDs used in this SignatureRequest (if any).
        /// </summary>
        /// <value>Templates IDs used in this SignatureRequest (if any).</value>
        [DataMember(Name = "template_ids", EmitDefaultValue = true)]
        public List<string> TemplateIds { get; set; }

        /// <summary>
        /// An array of Custom Field objects containing the name and type of each custom field.  * Text Field uses &#x60;SignatureRequestResponseCustomFieldText&#x60; * Checkbox Field uses &#x60;SignatureRequestResponseCustomFieldCheckbox&#x60;
        /// </summary>
        /// <value>An array of Custom Field objects containing the name and type of each custom field.  * Text Field uses &#x60;SignatureRequestResponseCustomFieldText&#x60; * Checkbox Field uses &#x60;SignatureRequestResponseCustomFieldCheckbox&#x60;</value>
        [DataMember(Name = "custom_fields", EmitDefaultValue = true)]
        public List<SignatureRequestResponseCustomFieldBase> CustomFields { get; set; }

        /// <summary>
        /// Signer attachments.
        /// </summary>
        /// <value>Signer attachments.</value>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<SignatureRequestResponseAttachment> Attachments { get; set; }

        /// <summary>
        /// An array of form field objects containing the name, value, and type of each textbox or checkmark field filled in by the signers.
        /// </summary>
        /// <value>An array of form field objects containing the name, value, and type of each textbox or checkmark field filled in by the signers.</value>
        [DataMember(Name = "response_data", EmitDefaultValue = true)]
        public List<SignatureRequestResponseDataBase> ResponseData { get; set; }

        /// <summary>
        /// An array of signature objects, 1 for each signer.
        /// </summary>
        /// <value>An array of signature objects, 1 for each signer.</value>
        [DataMember(Name = "signatures", EmitDefaultValue = true)]
        public List<SignatureRequestResponseSignatures> Signatures { get; set; }

        /// <summary>
        /// The id of the BulkSendJob.
        /// </summary>
        /// <value>The id of the BulkSendJob.</value>
        [DataMember(Name = "bulk_send_job_id", EmitDefaultValue = true)]
        public string BulkSendJobId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BulkSendJobGetResponseSignatureRequests {\n");
            sb.Append("  TestMode: ").Append(TestMode).Append("\n");
            sb.Append("  SignatureRequestId: ").Append(SignatureRequestId).Append("\n");
            sb.Append("  RequesterEmailAddress: ").Append(RequesterEmailAddress).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  OriginalTitle: ").Append(OriginalTitle).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
            sb.Append("  IsDeclined: ").Append(IsDeclined).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
            sb.Append("  FilesUrl: ").Append(FilesUrl).Append("\n");
            sb.Append("  SigningUrl: ").Append(SigningUrl).Append("\n");
            sb.Append("  DetailsUrl: ").Append(DetailsUrl).Append("\n");
            sb.Append("  CcEmailAddresses: ").Append(CcEmailAddresses).Append("\n");
            sb.Append("  SigningRedirectUrl: ").Append(SigningRedirectUrl).Append("\n");
            sb.Append("  TemplateIds: ").Append(TemplateIds).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  ResponseData: ").Append(ResponseData).Append("\n");
            sb.Append("  Signatures: ").Append(Signatures).Append("\n");
            sb.Append("  BulkSendJobId: ").Append(BulkSendJobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BulkSendJobGetResponseSignatureRequests);
        }

        /// <summary>
        /// Returns true if BulkSendJobGetResponseSignatureRequests instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkSendJobGetResponseSignatureRequests to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkSendJobGetResponseSignatureRequests input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TestMode == input.TestMode ||
                    (this.TestMode != null &&
                    this.TestMode.Equals(input.TestMode))
                ) && 
                (
                    this.SignatureRequestId == input.SignatureRequestId ||
                    (this.SignatureRequestId != null &&
                    this.SignatureRequestId.Equals(input.SignatureRequestId))
                ) && 
                (
                    this.RequesterEmailAddress == input.RequesterEmailAddress ||
                    (this.RequesterEmailAddress != null &&
                    this.RequesterEmailAddress.Equals(input.RequesterEmailAddress))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.OriginalTitle == input.OriginalTitle ||
                    (this.OriginalTitle != null &&
                    this.OriginalTitle.Equals(input.OriginalTitle))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.IsComplete == input.IsComplete ||
                    this.IsComplete.Equals(input.IsComplete)
                ) && 
                (
                    this.IsDeclined == input.IsDeclined ||
                    this.IsDeclined.Equals(input.IsDeclined)
                ) && 
                (
                    this.HasError == input.HasError ||
                    this.HasError.Equals(input.HasError)
                ) && 
                (
                    this.FilesUrl == input.FilesUrl ||
                    (this.FilesUrl != null &&
                    this.FilesUrl.Equals(input.FilesUrl))
                ) && 
                (
                    this.SigningUrl == input.SigningUrl ||
                    (this.SigningUrl != null &&
                    this.SigningUrl.Equals(input.SigningUrl))
                ) && 
                (
                    this.DetailsUrl == input.DetailsUrl ||
                    (this.DetailsUrl != null &&
                    this.DetailsUrl.Equals(input.DetailsUrl))
                ) && 
                (
                    this.CcEmailAddresses == input.CcEmailAddresses ||
                    this.CcEmailAddresses != null &&
                    input.CcEmailAddresses != null &&
                    this.CcEmailAddresses.SequenceEqual(input.CcEmailAddresses)
                ) && 
                (
                    this.SigningRedirectUrl == input.SigningRedirectUrl ||
                    (this.SigningRedirectUrl != null &&
                    this.SigningRedirectUrl.Equals(input.SigningRedirectUrl))
                ) && 
                (
                    this.TemplateIds == input.TemplateIds ||
                    this.TemplateIds != null &&
                    input.TemplateIds != null &&
                    this.TemplateIds.SequenceEqual(input.TemplateIds)
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.ResponseData == input.ResponseData ||
                    this.ResponseData != null &&
                    input.ResponseData != null &&
                    this.ResponseData.SequenceEqual(input.ResponseData)
                ) && 
                (
                    this.Signatures == input.Signatures ||
                    this.Signatures != null &&
                    input.Signatures != null &&
                    this.Signatures.SequenceEqual(input.Signatures)
                ) && 
                (
                    this.BulkSendJobId == input.BulkSendJobId ||
                    (this.BulkSendJobId != null &&
                    this.BulkSendJobId.Equals(input.BulkSendJobId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TestMode != null)
                {
                    hashCode = (hashCode * 59) + this.TestMode.GetHashCode();
                }
                if (this.SignatureRequestId != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureRequestId.GetHashCode();
                }
                if (this.RequesterEmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.RequesterEmailAddress.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.OriginalTitle != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalTitle.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                hashCode = (hashCode * 59) + this.IsComplete.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDeclined.GetHashCode();
                hashCode = (hashCode * 59) + this.HasError.GetHashCode();
                if (this.FilesUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FilesUrl.GetHashCode();
                }
                if (this.SigningUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SigningUrl.GetHashCode();
                }
                if (this.DetailsUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DetailsUrl.GetHashCode();
                }
                if (this.CcEmailAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.CcEmailAddresses.GetHashCode();
                }
                if (this.SigningRedirectUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SigningRedirectUrl.GetHashCode();
                }
                if (this.TemplateIds != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateIds.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.ResponseData != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseData.GetHashCode();
                }
                if (this.Signatures != null)
                {
                    hashCode = (hashCode * 59) + this.Signatures.GetHashCode();
                }
                if (this.BulkSendJobId != null)
                {
                    hashCode = (hashCode * 59) + this.BulkSendJobId.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "test_mode",
                Property = "TestMode",
                Type = "bool?",
                Value = TestMode,
            });
            types.Add(new OpenApiType(){
                Name = "signature_request_id",
                Property = "SignatureRequestId",
                Type = "string",
                Value = SignatureRequestId,
            });
            types.Add(new OpenApiType(){
                Name = "requester_email_address",
                Property = "RequesterEmailAddress",
                Type = "string",
                Value = RequesterEmailAddress,
            });
            types.Add(new OpenApiType(){
                Name = "title",
                Property = "Title",
                Type = "string",
                Value = Title,
            });
            types.Add(new OpenApiType(){
                Name = "original_title",
                Property = "OriginalTitle",
                Type = "string",
                Value = OriginalTitle,
            });
            types.Add(new OpenApiType(){
                Name = "subject",
                Property = "Subject",
                Type = "string",
                Value = Subject,
            });
            types.Add(new OpenApiType(){
                Name = "message",
                Property = "Message",
                Type = "string",
                Value = Message,
            });
            types.Add(new OpenApiType(){
                Name = "metadata",
                Property = "Metadata",
                Type = "Object",
                Value = Metadata,
            });
            types.Add(new OpenApiType(){
                Name = "created_at",
                Property = "CreatedAt",
                Type = "int",
                Value = CreatedAt,
            });
            types.Add(new OpenApiType(){
                Name = "is_complete",
                Property = "IsComplete",
                Type = "bool",
                Value = IsComplete,
            });
            types.Add(new OpenApiType(){
                Name = "is_declined",
                Property = "IsDeclined",
                Type = "bool",
                Value = IsDeclined,
            });
            types.Add(new OpenApiType(){
                Name = "has_error",
                Property = "HasError",
                Type = "bool",
                Value = HasError,
            });
            types.Add(new OpenApiType(){
                Name = "files_url",
                Property = "FilesUrl",
                Type = "string",
                Value = FilesUrl,
            });
            types.Add(new OpenApiType(){
                Name = "signing_url",
                Property = "SigningUrl",
                Type = "string",
                Value = SigningUrl,
            });
            types.Add(new OpenApiType(){
                Name = "details_url",
                Property = "DetailsUrl",
                Type = "string",
                Value = DetailsUrl,
            });
            types.Add(new OpenApiType(){
                Name = "cc_email_addresses",
                Property = "CcEmailAddresses",
                Type = "List<string>",
                Value = CcEmailAddresses,
            });
            types.Add(new OpenApiType(){
                Name = "signing_redirect_url",
                Property = "SigningRedirectUrl",
                Type = "string",
                Value = SigningRedirectUrl,
            });
            types.Add(new OpenApiType(){
                Name = "template_ids",
                Property = "TemplateIds",
                Type = "List<string>",
                Value = TemplateIds,
            });
            types.Add(new OpenApiType(){
                Name = "custom_fields",
                Property = "CustomFields",
                Type = "List<SignatureRequestResponseCustomFieldBase>",
                Value = CustomFields,
            });
            types.Add(new OpenApiType(){
                Name = "attachments",
                Property = "Attachments",
                Type = "List<SignatureRequestResponseAttachment>",
                Value = Attachments,
            });
            types.Add(new OpenApiType(){
                Name = "response_data",
                Property = "ResponseData",
                Type = "List<SignatureRequestResponseDataBase>",
                Value = ResponseData,
            });
            types.Add(new OpenApiType(){
                Name = "signatures",
                Property = "Signatures",
                Type = "List<SignatureRequestResponseSignatures>",
                Value = Signatures,
            });
            types.Add(new OpenApiType(){
                Name = "bulk_send_job_id",
                Property = "BulkSendJobId",
                Type = "string",
                Value = BulkSendJobId,
            });

            return types;
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
