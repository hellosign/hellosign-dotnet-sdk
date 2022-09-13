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
    /// OAuthTokenResponse
    /// </summary>
    [DataContract(Name = "OAuthTokenResponse")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class OAuthTokenResponse : IOpenApiTyped, IEquatable<OAuthTokenResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthTokenResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OAuthTokenResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthTokenResponse" /> class.
        /// </summary>
        /// <param name="accessToken">accessToken.</param>
        /// <param name="tokenType">tokenType.</param>
        /// <param name="refreshToken">refreshToken.</param>
        /// <param name="expiresIn">Number of seconds until the &#x60;access_token&#x60; expires. Uses epoch time..</param>
        /// <param name="state">state.</param>
        public OAuthTokenResponse(string accessToken = default(string), string tokenType = default(string), string refreshToken = default(string), int expiresIn = default(int), string state = default(string))
        {
            
            this.AccessToken = accessToken;
            this.TokenType = tokenType;
            this.RefreshToken = refreshToken;
            this.ExpiresIn = expiresIn;
            this.State = state;
        }

        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name = "access_token", EmitDefaultValue = true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets TokenType
        /// </summary>
        [DataMember(Name = "token_type", EmitDefaultValue = true)]
        public string TokenType { get; set; }

        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        [DataMember(Name = "refresh_token", EmitDefaultValue = true)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Number of seconds until the &#x60;access_token&#x60; expires. Uses epoch time.
        /// </summary>
        /// <value>Number of seconds until the &#x60;access_token&#x60; expires. Uses epoch time.</value>
        [DataMember(Name = "expires_in", EmitDefaultValue = true)]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuthTokenResponse {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as OAuthTokenResponse);
        }

        /// <summary>
        /// Returns true if OAuthTokenResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuthTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthTokenResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    this.ExpiresIn.Equals(input.ExpiresIn)
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.AccessToken != null)
                {
                    hashCode = (hashCode * 59) + this.AccessToken.GetHashCode();
                }
                if (this.TokenType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
                }
                if (this.RefreshToken != null)
                {
                    hashCode = (hashCode * 59) + this.RefreshToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiresIn.GetHashCode();
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "access_token",
                Property = "AccessToken",
                Type = "string",
                Value = AccessToken,
            });
            types.Add(new OpenApiType(){
                Name = "token_type",
                Property = "TokenType",
                Type = "string",
                Value = TokenType,
            });
            types.Add(new OpenApiType(){
                Name = "refresh_token",
                Property = "RefreshToken",
                Type = "string",
                Value = RefreshToken,
            });
            types.Add(new OpenApiType(){
                Name = "expires_in",
                Property = "ExpiresIn",
                Type = "int",
                Value = ExpiresIn,
            });
            types.Add(new OpenApiType(){
                Name = "state",
                Property = "State",
                Type = "string",
                Value = State,
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
