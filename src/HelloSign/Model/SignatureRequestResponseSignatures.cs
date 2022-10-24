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
    /// An array of signature objects, 1 for each signer.
    /// </summary>
    [DataContract(Name = "SignatureRequestResponseSignatures")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SignatureRequestResponseSignatures : IOpenApiTyped, IEquatable<SignatureRequestResponseSignatures>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestResponseSignatures" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignatureRequestResponseSignatures() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestResponseSignatures" /> class.
        /// </summary>
        /// <param name="signatureId">Signature identifier..</param>
        /// <param name="signerEmailAddress">The email address of the signer..</param>
        /// <param name="signerName">The name of the signer..</param>
        /// <param name="signerRole">The role of the signer..</param>
        /// <param name="order">If signer order is assigned this is the 0-based index for this signer..</param>
        /// <param name="statusCode">The current status of the signature. eg: awaiting_signature, signed, declined..</param>
        /// <param name="declineReason">The reason provided by the signer for declining the request..</param>
        /// <param name="signedAt">Time that the document was signed or null..</param>
        /// <param name="lastViewedAt">The time that the document was last viewed by this signer or null..</param>
        /// <param name="lastRemindedAt">The time the last reminder email was sent to the signer or null..</param>
        /// <param name="hasPin">Boolean to indicate whether this signature requires a PIN to access..</param>
        /// <param name="hasSmsAuth">Boolean to indicate whether this signature has SMS authentication enabled..</param>
        /// <param name="hasSmsDelivery">Boolean to indicate whether this signature has SMS delivery enabled..</param>
        /// <param name="smsPhoneNumber">The SMS phone number used for authentication or signature request delivery..</param>
        /// <param name="reassignedBy">Email address of original signer who reassigned to this signer..</param>
        /// <param name="reassignmentReason">Reason provided by original signer who reassigned to this signer..</param>
        /// <param name="reassignedFrom">Previous signature identifier..</param>
        /// <param name="error">Error message pertaining to this signer, or null..</param>
        public SignatureRequestResponseSignatures(string signatureId = default(string), string signerEmailAddress = default(string), string signerName = default(string), string signerRole = default(string), int? order = default(int?), string statusCode = default(string), string declineReason = default(string), int? signedAt = default(int?), int? lastViewedAt = default(int?), int? lastRemindedAt = default(int?), bool hasPin = default(bool), bool? hasSmsAuth = default(bool?), bool? hasSmsDelivery = default(bool?), string smsPhoneNumber = default(string), string reassignedBy = default(string), string reassignmentReason = default(string), string reassignedFrom = default(string), string error = default(string))
        {
            
            this.SignatureId = signatureId;
            this.SignerEmailAddress = signerEmailAddress;
            this.SignerName = signerName;
            this.SignerRole = signerRole;
            this.Order = order;
            this.StatusCode = statusCode;
            this.DeclineReason = declineReason;
            this.SignedAt = signedAt;
            this.LastViewedAt = lastViewedAt;
            this.LastRemindedAt = lastRemindedAt;
            this.HasPin = hasPin;
            this.HasSmsAuth = hasSmsAuth;
            this.HasSmsDelivery = hasSmsDelivery;
            this.SmsPhoneNumber = smsPhoneNumber;
            this.ReassignedBy = reassignedBy;
            this.ReassignmentReason = reassignmentReason;
            this.ReassignedFrom = reassignedFrom;
            this.Error = error;
        }

        /// <summary>
        /// Signature identifier.
        /// </summary>
        /// <value>Signature identifier.</value>
        [DataMember(Name = "signature_id", EmitDefaultValue = true)]
        public string SignatureId { get; set; }

        /// <summary>
        /// The email address of the signer.
        /// </summary>
        /// <value>The email address of the signer.</value>
        [DataMember(Name = "signer_email_address", EmitDefaultValue = true)]
        public string SignerEmailAddress { get; set; }

        /// <summary>
        /// The name of the signer.
        /// </summary>
        /// <value>The name of the signer.</value>
        [DataMember(Name = "signer_name", EmitDefaultValue = true)]
        public string SignerName { get; set; }

        /// <summary>
        /// The role of the signer.
        /// </summary>
        /// <value>The role of the signer.</value>
        [DataMember(Name = "signer_role", EmitDefaultValue = true)]
        public string SignerRole { get; set; }

        /// <summary>
        /// If signer order is assigned this is the 0-based index for this signer.
        /// </summary>
        /// <value>If signer order is assigned this is the 0-based index for this signer.</value>
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public int? Order { get; set; }

        /// <summary>
        /// The current status of the signature. eg: awaiting_signature, signed, declined.
        /// </summary>
        /// <value>The current status of the signature. eg: awaiting_signature, signed, declined.</value>
        [DataMember(Name = "status_code", EmitDefaultValue = true)]
        public string StatusCode { get; set; }

        /// <summary>
        /// The reason provided by the signer for declining the request.
        /// </summary>
        /// <value>The reason provided by the signer for declining the request.</value>
        [DataMember(Name = "decline_reason", EmitDefaultValue = true)]
        public string DeclineReason { get; set; }

        /// <summary>
        /// Time that the document was signed or null.
        /// </summary>
        /// <value>Time that the document was signed or null.</value>
        [DataMember(Name = "signed_at", EmitDefaultValue = true)]
        public int? SignedAt { get; set; }

        /// <summary>
        /// The time that the document was last viewed by this signer or null.
        /// </summary>
        /// <value>The time that the document was last viewed by this signer or null.</value>
        [DataMember(Name = "last_viewed_at", EmitDefaultValue = true)]
        public int? LastViewedAt { get; set; }

        /// <summary>
        /// The time the last reminder email was sent to the signer or null.
        /// </summary>
        /// <value>The time the last reminder email was sent to the signer or null.</value>
        [DataMember(Name = "last_reminded_at", EmitDefaultValue = true)]
        public int? LastRemindedAt { get; set; }

        /// <summary>
        /// Boolean to indicate whether this signature requires a PIN to access.
        /// </summary>
        /// <value>Boolean to indicate whether this signature requires a PIN to access.</value>
        [DataMember(Name = "has_pin", EmitDefaultValue = true)]
        public bool HasPin { get; set; }

        /// <summary>
        /// Boolean to indicate whether this signature has SMS authentication enabled.
        /// </summary>
        /// <value>Boolean to indicate whether this signature has SMS authentication enabled.</value>
        [DataMember(Name = "has_sms_auth", EmitDefaultValue = true)]
        public bool? HasSmsAuth { get; set; }

        /// <summary>
        /// Boolean to indicate whether this signature has SMS delivery enabled.
        /// </summary>
        /// <value>Boolean to indicate whether this signature has SMS delivery enabled.</value>
        [DataMember(Name = "has_sms_delivery", EmitDefaultValue = true)]
        public bool? HasSmsDelivery { get; set; }

        /// <summary>
        /// The SMS phone number used for authentication or signature request delivery.
        /// </summary>
        /// <value>The SMS phone number used for authentication or signature request delivery.</value>
        [DataMember(Name = "sms_phone_number", EmitDefaultValue = true)]
        public string SmsPhoneNumber { get; set; }

        /// <summary>
        /// Email address of original signer who reassigned to this signer.
        /// </summary>
        /// <value>Email address of original signer who reassigned to this signer.</value>
        [DataMember(Name = "reassigned_by", EmitDefaultValue = true)]
        public string ReassignedBy { get; set; }

        /// <summary>
        /// Reason provided by original signer who reassigned to this signer.
        /// </summary>
        /// <value>Reason provided by original signer who reassigned to this signer.</value>
        [DataMember(Name = "reassignment_reason", EmitDefaultValue = true)]
        public string ReassignmentReason { get; set; }

        /// <summary>
        /// Previous signature identifier.
        /// </summary>
        /// <value>Previous signature identifier.</value>
        [DataMember(Name = "reassigned_from", EmitDefaultValue = true)]
        public string ReassignedFrom { get; set; }

        /// <summary>
        /// Error message pertaining to this signer, or null.
        /// </summary>
        /// <value>Error message pertaining to this signer, or null.</value>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignatureRequestResponseSignatures {\n");
            sb.Append("  SignatureId: ").Append(SignatureId).Append("\n");
            sb.Append("  SignerEmailAddress: ").Append(SignerEmailAddress).Append("\n");
            sb.Append("  SignerName: ").Append(SignerName).Append("\n");
            sb.Append("  SignerRole: ").Append(SignerRole).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  DeclineReason: ").Append(DeclineReason).Append("\n");
            sb.Append("  SignedAt: ").Append(SignedAt).Append("\n");
            sb.Append("  LastViewedAt: ").Append(LastViewedAt).Append("\n");
            sb.Append("  LastRemindedAt: ").Append(LastRemindedAt).Append("\n");
            sb.Append("  HasPin: ").Append(HasPin).Append("\n");
            sb.Append("  HasSmsAuth: ").Append(HasSmsAuth).Append("\n");
            sb.Append("  HasSmsDelivery: ").Append(HasSmsDelivery).Append("\n");
            sb.Append("  SmsPhoneNumber: ").Append(SmsPhoneNumber).Append("\n");
            sb.Append("  ReassignedBy: ").Append(ReassignedBy).Append("\n");
            sb.Append("  ReassignmentReason: ").Append(ReassignmentReason).Append("\n");
            sb.Append("  ReassignedFrom: ").Append(ReassignedFrom).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as SignatureRequestResponseSignatures);
        }

        /// <summary>
        /// Returns true if SignatureRequestResponseSignatures instances are equal
        /// </summary>
        /// <param name="input">Instance of SignatureRequestResponseSignatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureRequestResponseSignatures input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SignatureId == input.SignatureId ||
                    (this.SignatureId != null &&
                    this.SignatureId.Equals(input.SignatureId))
                ) && 
                (
                    this.SignerEmailAddress == input.SignerEmailAddress ||
                    (this.SignerEmailAddress != null &&
                    this.SignerEmailAddress.Equals(input.SignerEmailAddress))
                ) && 
                (
                    this.SignerName == input.SignerName ||
                    (this.SignerName != null &&
                    this.SignerName.Equals(input.SignerName))
                ) && 
                (
                    this.SignerRole == input.SignerRole ||
                    (this.SignerRole != null &&
                    this.SignerRole.Equals(input.SignerRole))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.DeclineReason == input.DeclineReason ||
                    (this.DeclineReason != null &&
                    this.DeclineReason.Equals(input.DeclineReason))
                ) && 
                (
                    this.SignedAt == input.SignedAt ||
                    (this.SignedAt != null &&
                    this.SignedAt.Equals(input.SignedAt))
                ) && 
                (
                    this.LastViewedAt == input.LastViewedAt ||
                    (this.LastViewedAt != null &&
                    this.LastViewedAt.Equals(input.LastViewedAt))
                ) && 
                (
                    this.LastRemindedAt == input.LastRemindedAt ||
                    (this.LastRemindedAt != null &&
                    this.LastRemindedAt.Equals(input.LastRemindedAt))
                ) && 
                (
                    this.HasPin == input.HasPin ||
                    this.HasPin.Equals(input.HasPin)
                ) && 
                (
                    this.HasSmsAuth == input.HasSmsAuth ||
                    (this.HasSmsAuth != null &&
                    this.HasSmsAuth.Equals(input.HasSmsAuth))
                ) && 
                (
                    this.HasSmsDelivery == input.HasSmsDelivery ||
                    (this.HasSmsDelivery != null &&
                    this.HasSmsDelivery.Equals(input.HasSmsDelivery))
                ) && 
                (
                    this.SmsPhoneNumber == input.SmsPhoneNumber ||
                    (this.SmsPhoneNumber != null &&
                    this.SmsPhoneNumber.Equals(input.SmsPhoneNumber))
                ) && 
                (
                    this.ReassignedBy == input.ReassignedBy ||
                    (this.ReassignedBy != null &&
                    this.ReassignedBy.Equals(input.ReassignedBy))
                ) && 
                (
                    this.ReassignmentReason == input.ReassignmentReason ||
                    (this.ReassignmentReason != null &&
                    this.ReassignmentReason.Equals(input.ReassignmentReason))
                ) && 
                (
                    this.ReassignedFrom == input.ReassignedFrom ||
                    (this.ReassignedFrom != null &&
                    this.ReassignedFrom.Equals(input.ReassignedFrom))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.SignatureId != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureId.GetHashCode();
                }
                if (this.SignerEmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.SignerEmailAddress.GetHashCode();
                }
                if (this.SignerName != null)
                {
                    hashCode = (hashCode * 59) + this.SignerName.GetHashCode();
                }
                if (this.SignerRole != null)
                {
                    hashCode = (hashCode * 59) + this.SignerRole.GetHashCode();
                }
                if (this.Order != null)
                {
                    hashCode = (hashCode * 59) + this.Order.GetHashCode();
                }
                if (this.StatusCode != null)
                {
                    hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
                }
                if (this.DeclineReason != null)
                {
                    hashCode = (hashCode * 59) + this.DeclineReason.GetHashCode();
                }
                if (this.SignedAt != null)
                {
                    hashCode = (hashCode * 59) + this.SignedAt.GetHashCode();
                }
                if (this.LastViewedAt != null)
                {
                    hashCode = (hashCode * 59) + this.LastViewedAt.GetHashCode();
                }
                if (this.LastRemindedAt != null)
                {
                    hashCode = (hashCode * 59) + this.LastRemindedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasPin.GetHashCode();
                if (this.HasSmsAuth != null)
                {
                    hashCode = (hashCode * 59) + this.HasSmsAuth.GetHashCode();
                }
                if (this.HasSmsDelivery != null)
                {
                    hashCode = (hashCode * 59) + this.HasSmsDelivery.GetHashCode();
                }
                if (this.SmsPhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SmsPhoneNumber.GetHashCode();
                }
                if (this.ReassignedBy != null)
                {
                    hashCode = (hashCode * 59) + this.ReassignedBy.GetHashCode();
                }
                if (this.ReassignmentReason != null)
                {
                    hashCode = (hashCode * 59) + this.ReassignmentReason.GetHashCode();
                }
                if (this.ReassignedFrom != null)
                {
                    hashCode = (hashCode * 59) + this.ReassignedFrom.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "signature_id",
                Property = "SignatureId",
                Type = "string",
                Value = SignatureId,
            });
            types.Add(new OpenApiType(){
                Name = "signer_email_address",
                Property = "SignerEmailAddress",
                Type = "string",
                Value = SignerEmailAddress,
            });
            types.Add(new OpenApiType(){
                Name = "signer_name",
                Property = "SignerName",
                Type = "string",
                Value = SignerName,
            });
            types.Add(new OpenApiType(){
                Name = "signer_role",
                Property = "SignerRole",
                Type = "string",
                Value = SignerRole,
            });
            types.Add(new OpenApiType(){
                Name = "order",
                Property = "Order",
                Type = "int?",
                Value = Order,
            });
            types.Add(new OpenApiType(){
                Name = "status_code",
                Property = "StatusCode",
                Type = "string",
                Value = StatusCode,
            });
            types.Add(new OpenApiType(){
                Name = "decline_reason",
                Property = "DeclineReason",
                Type = "string",
                Value = DeclineReason,
            });
            types.Add(new OpenApiType(){
                Name = "signed_at",
                Property = "SignedAt",
                Type = "int?",
                Value = SignedAt,
            });
            types.Add(new OpenApiType(){
                Name = "last_viewed_at",
                Property = "LastViewedAt",
                Type = "int?",
                Value = LastViewedAt,
            });
            types.Add(new OpenApiType(){
                Name = "last_reminded_at",
                Property = "LastRemindedAt",
                Type = "int?",
                Value = LastRemindedAt,
            });
            types.Add(new OpenApiType(){
                Name = "has_pin",
                Property = "HasPin",
                Type = "bool",
                Value = HasPin,
            });
            types.Add(new OpenApiType(){
                Name = "has_sms_auth",
                Property = "HasSmsAuth",
                Type = "bool?",
                Value = HasSmsAuth,
            });
            types.Add(new OpenApiType(){
                Name = "has_sms_delivery",
                Property = "HasSmsDelivery",
                Type = "bool?",
                Value = HasSmsDelivery,
            });
            types.Add(new OpenApiType(){
                Name = "sms_phone_number",
                Property = "SmsPhoneNumber",
                Type = "string",
                Value = SmsPhoneNumber,
            });
            types.Add(new OpenApiType(){
                Name = "reassigned_by",
                Property = "ReassignedBy",
                Type = "string",
                Value = ReassignedBy,
            });
            types.Add(new OpenApiType(){
                Name = "reassignment_reason",
                Property = "ReassignmentReason",
                Type = "string",
                Value = ReassignmentReason,
            });
            types.Add(new OpenApiType(){
                Name = "reassigned_from",
                Property = "ReassignedFrom",
                Type = "string",
                Value = ReassignedFrom,
            });
            types.Add(new OpenApiType(){
                Name = "error",
                Property = "Error",
                Type = "string",
                Value = Error,
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
