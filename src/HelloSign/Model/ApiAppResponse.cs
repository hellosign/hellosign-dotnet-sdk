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
    /// Contains information about an API App.
    /// </summary>
    [DataContract(Name = "ApiAppResponse")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class ApiAppResponse : IOpenApiTyped, IEquatable<ApiAppResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAppResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiAppResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAppResponse" /> class.
        /// </summary>
        /// <param name="callbackUrl">The app&#39;s callback URL (for events).</param>
        /// <param name="clientId">The app&#39;s client id.</param>
        /// <param name="createdAt">The time that the app was created.</param>
        /// <param name="domains">The domain name(s) associated with the app.</param>
        /// <param name="name">The name of the app.</param>
        /// <param name="isApproved">Boolean to indicate if the app has been approved.</param>
        /// <param name="oauth">oauth.</param>
        /// <param name="options">options.</param>
        /// <param name="ownerAccount">ownerAccount.</param>
        /// <param name="whiteLabelingOptions">whiteLabelingOptions.</param>
        public ApiAppResponse(string callbackUrl = default(string), string clientId = default(string), int createdAt = default(int), List<string> domains = default(List<string>), string name = default(string), bool isApproved = default(bool), ApiAppResponseOAuth oauth = default(ApiAppResponseOAuth), ApiAppResponseOptions options = default(ApiAppResponseOptions), ApiAppResponseOwnerAccount ownerAccount = default(ApiAppResponseOwnerAccount), ApiAppResponseWhiteLabelingOptions whiteLabelingOptions = default(ApiAppResponseWhiteLabelingOptions))
        {
            
            this.CallbackUrl = callbackUrl;
            this.ClientId = clientId;
            this.CreatedAt = createdAt;
            this.Domains = domains;
            this.Name = name;
            this.IsApproved = isApproved;
            this.Oauth = oauth;
            this.Options = options;
            this.OwnerAccount = ownerAccount;
            this.WhiteLabelingOptions = whiteLabelingOptions;
        }

        /// <summary>
        /// The app&#39;s callback URL (for events)
        /// </summary>
        /// <value>The app&#39;s callback URL (for events)</value>
        [DataMember(Name = "callback_url", EmitDefaultValue = true)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// The app&#39;s client id
        /// </summary>
        /// <value>The app&#39;s client id</value>
        [DataMember(Name = "client_id", EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// The time that the app was created
        /// </summary>
        /// <value>The time that the app was created</value>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public int CreatedAt { get; set; }

        /// <summary>
        /// The domain name(s) associated with the app
        /// </summary>
        /// <value>The domain name(s) associated with the app</value>
        [DataMember(Name = "domains", EmitDefaultValue = true)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// The name of the app
        /// </summary>
        /// <value>The name of the app</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Boolean to indicate if the app has been approved
        /// </summary>
        /// <value>Boolean to indicate if the app has been approved</value>
        [DataMember(Name = "is_approved", EmitDefaultValue = true)]
        public bool IsApproved { get; set; }

        /// <summary>
        /// Gets or Sets Oauth
        /// </summary>
        [DataMember(Name = "oauth", EmitDefaultValue = true)]
        public ApiAppResponseOAuth Oauth { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = true)]
        public ApiAppResponseOptions Options { get; set; }

        /// <summary>
        /// Gets or Sets OwnerAccount
        /// </summary>
        [DataMember(Name = "owner_account", EmitDefaultValue = true)]
        public ApiAppResponseOwnerAccount OwnerAccount { get; set; }

        /// <summary>
        /// Gets or Sets WhiteLabelingOptions
        /// </summary>
        [DataMember(Name = "white_labeling_options", EmitDefaultValue = true)]
        public ApiAppResponseWhiteLabelingOptions WhiteLabelingOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiAppResponse {\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsApproved: ").Append(IsApproved).Append("\n");
            sb.Append("  Oauth: ").Append(Oauth).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  OwnerAccount: ").Append(OwnerAccount).Append("\n");
            sb.Append("  WhiteLabelingOptions: ").Append(WhiteLabelingOptions).Append("\n");
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
            return this.Equals(input as ApiAppResponse);
        }

        /// <summary>
        /// Returns true if ApiAppResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiAppResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiAppResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.Domains == input.Domains ||
                    this.Domains != null &&
                    input.Domains != null &&
                    this.Domains.SequenceEqual(input.Domains)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsApproved == input.IsApproved ||
                    this.IsApproved.Equals(input.IsApproved)
                ) && 
                (
                    this.Oauth == input.Oauth ||
                    (this.Oauth != null &&
                    this.Oauth.Equals(input.Oauth))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
                ) && 
                (
                    this.OwnerAccount == input.OwnerAccount ||
                    (this.OwnerAccount != null &&
                    this.OwnerAccount.Equals(input.OwnerAccount))
                ) && 
                (
                    this.WhiteLabelingOptions == input.WhiteLabelingOptions ||
                    (this.WhiteLabelingOptions != null &&
                    this.WhiteLabelingOptions.Equals(input.WhiteLabelingOptions))
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
                if (this.CallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackUrl.GetHashCode();
                }
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.Domains != null)
                {
                    hashCode = (hashCode * 59) + this.Domains.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsApproved.GetHashCode();
                if (this.Oauth != null)
                {
                    hashCode = (hashCode * 59) + this.Oauth.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                if (this.OwnerAccount != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerAccount.GetHashCode();
                }
                if (this.WhiteLabelingOptions != null)
                {
                    hashCode = (hashCode * 59) + this.WhiteLabelingOptions.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "callback_url",
                Property = "CallbackUrl",
                Type = "string",
                Value = CallbackUrl,
            });
            types.Add(new OpenApiType(){
                Name = "client_id",
                Property = "ClientId",
                Type = "string",
                Value = ClientId,
            });
            types.Add(new OpenApiType(){
                Name = "created_at",
                Property = "CreatedAt",
                Type = "int",
                Value = CreatedAt,
            });
            types.Add(new OpenApiType(){
                Name = "domains",
                Property = "Domains",
                Type = "List<string>",
                Value = Domains,
            });
            types.Add(new OpenApiType(){
                Name = "name",
                Property = "Name",
                Type = "string",
                Value = Name,
            });
            types.Add(new OpenApiType(){
                Name = "is_approved",
                Property = "IsApproved",
                Type = "bool",
                Value = IsApproved,
            });
            types.Add(new OpenApiType(){
                Name = "oauth",
                Property = "Oauth",
                Type = "ApiAppResponseOAuth",
                Value = Oauth,
            });
            types.Add(new OpenApiType(){
                Name = "options",
                Property = "Options",
                Type = "ApiAppResponseOptions",
                Value = Options,
            });
            types.Add(new OpenApiType(){
                Name = "owner_account",
                Property = "OwnerAccount",
                Type = "ApiAppResponseOwnerAccount",
                Value = OwnerAccount,
            });
            types.Add(new OpenApiType(){
                Name = "white_labeling_options",
                Property = "WhiteLabelingOptions",
                Type = "ApiAppResponseWhiteLabelingOptions",
                Value = WhiteLabelingOptions,
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
