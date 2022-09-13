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
    /// AccountUpdateRequest
    /// </summary>
    [DataContract(Name = "AccountUpdateRequest")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class AccountUpdateRequest : IOpenApiTyped, IEquatable<AccountUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUpdateRequest" /> class.
        /// </summary>
        /// <param name="accountId">The ID of the Account.</param>
        /// <param name="callbackUrl">The URL that HelloSign should POST events to..</param>
        /// <param name="locale">The locale used in this Account. Check out the list of [supported locales](/api/reference/constants/#supported-locales) to learn more about the possible values..</param>
        public AccountUpdateRequest(string accountId = default(string), string callbackUrl = default(string), string locale = default(string))
        {
            
            this.AccountId = accountId;
            this.CallbackUrl = callbackUrl;
            this.Locale = locale;
        }

        /// <summary>
        /// The ID of the Account
        /// </summary>
        /// <value>The ID of the Account</value>
        [DataMember(Name = "account_id", EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// The URL that HelloSign should POST events to.
        /// </summary>
        /// <value>The URL that HelloSign should POST events to.</value>
        [DataMember(Name = "callback_url", EmitDefaultValue = true)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// The locale used in this Account. Check out the list of [supported locales](/api/reference/constants/#supported-locales) to learn more about the possible values.
        /// </summary>
        /// <value>The locale used in this Account. Check out the list of [supported locales](/api/reference/constants/#supported-locales) to learn more about the possible values.</value>
        [DataMember(Name = "locale", EmitDefaultValue = true)]
        public string Locale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountUpdateRequest {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            return this.Equals(input as AccountUpdateRequest);
        }

        /// <summary>
        /// Returns true if AccountUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountUpdateRequest input)
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
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
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
                if (this.CallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackUrl.GetHashCode();
                }
                if (this.Locale != null)
                {
                    hashCode = (hashCode * 59) + this.Locale.GetHashCode();
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
                Name = "callback_url",
                Property = "CallbackUrl",
                Type = "string",
                Value = CallbackUrl,
            });
            types.Add(new OpenApiType(){
                Name = "locale",
                Property = "Locale",
                Type = "string",
                Value = Locale,
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
