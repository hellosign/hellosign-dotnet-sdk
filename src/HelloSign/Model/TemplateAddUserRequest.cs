/*
 * Dropbox Sign API
 *
 * Dropbox Sign v3 API
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
    /// TemplateAddUserRequest
    /// </summary>
    [DataContract(Name = "TemplateAddUserRequest")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class TemplateAddUserRequest : IOpenApiTyped, IEquatable<TemplateAddUserRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateAddUserRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateAddUserRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateAddUserRequest" /> class.
        /// </summary>
        /// <param name="accountId">The id of the Account to give access to the Template. &lt;b&gt;Note&lt;/b&gt; The account id prevails if email address is also provided..</param>
        /// <param name="emailAddress">The email address of the Account to give access to the Template. &lt;b&gt;Note&lt;/b&gt; The account id prevails if it is also provided..</param>
        /// <param name="skipNotification">If set to &#x60;true&#x60;, the user does not receive an email notification when a template has been shared with them. Defaults to &#x60;false&#x60;. (default to false).</param>
        public TemplateAddUserRequest(string accountId = default(string), string emailAddress = default(string), bool skipNotification = false)
        {
            
            this.AccountId = accountId;
            this.EmailAddress = emailAddress;
            this.SkipNotification = skipNotification;
        }

        /// <summary>
        /// The id of the Account to give access to the Template. &lt;b&gt;Note&lt;/b&gt; The account id prevails if email address is also provided.
        /// </summary>
        /// <value>The id of the Account to give access to the Template. &lt;b&gt;Note&lt;/b&gt; The account id prevails if email address is also provided.</value>
        [DataMember(Name = "account_id", EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// The email address of the Account to give access to the Template. &lt;b&gt;Note&lt;/b&gt; The account id prevails if it is also provided.
        /// </summary>
        /// <value>The email address of the Account to give access to the Template. &lt;b&gt;Note&lt;/b&gt; The account id prevails if it is also provided.</value>
        [DataMember(Name = "email_address", EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// If set to &#x60;true&#x60;, the user does not receive an email notification when a template has been shared with them. Defaults to &#x60;false&#x60;.
        /// </summary>
        /// <value>If set to &#x60;true&#x60;, the user does not receive an email notification when a template has been shared with them. Defaults to &#x60;false&#x60;.</value>
        [DataMember(Name = "skip_notification", EmitDefaultValue = true)]
        public bool SkipNotification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateAddUserRequest {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  SkipNotification: ").Append(SkipNotification).Append("\n");
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
            return this.Equals(input as TemplateAddUserRequest);
        }

        /// <summary>
        /// Returns true if TemplateAddUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateAddUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateAddUserRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.SkipNotification == input.SkipNotification ||
                    this.SkipNotification.Equals(input.SkipNotification)
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SkipNotification.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "account_id",
                Property = "AccountId",
                Type = "string",
                Value = AccountId,
            });
            types.Add(new OpenApiType(){
                Name = "email_address",
                Property = "EmailAddress",
                Type = "string",
                Value = EmailAddress,
            });
            types.Add(new OpenApiType(){
                Name = "skip_notification",
                Property = "SkipNotification",
                Type = "bool",
                Value = SkipNotification,
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
