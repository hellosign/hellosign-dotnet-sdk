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
    /// TemplateRemoveUserRequest
    /// </summary>
    [DataContract(Name = "TemplateRemoveUserRequest")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class TemplateRemoveUserRequest : IOpenApiTyped, IEquatable<TemplateRemoveUserRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRemoveUserRequest" /> class.
        /// </summary>
        /// <param name="accountId">The id or email address of the Account to remove access to the Template. The account id prevails if both are provided..</param>
        /// <param name="emailAddress">The id or email address of the Account to remove access to the Template. The account id prevails if both are provided..</param>
        public TemplateRemoveUserRequest(string accountId = default(string), string emailAddress = default(string))
        {
            
            this.AccountId = accountId;
            this.EmailAddress = emailAddress;
        }

        /// <summary>
        /// The id or email address of the Account to remove access to the Template. The account id prevails if both are provided.
        /// </summary>
        /// <value>The id or email address of the Account to remove access to the Template. The account id prevails if both are provided.</value>
        [DataMember(Name = "account_id", EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// The id or email address of the Account to remove access to the Template. The account id prevails if both are provided.
        /// </summary>
        /// <value>The id or email address of the Account to remove access to the Template. The account id prevails if both are provided.</value>
        [DataMember(Name = "email_address", EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateRemoveUserRequest {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
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
            return this.Equals(input as TemplateRemoveUserRequest);
        }

        /// <summary>
        /// Returns true if TemplateRemoveUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateRemoveUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateRemoveUserRequest input)
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
