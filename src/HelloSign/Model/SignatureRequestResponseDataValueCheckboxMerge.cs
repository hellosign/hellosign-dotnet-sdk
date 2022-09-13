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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = HelloSign.Client.OpenAPIDateConverter;

namespace HelloSign.Model
{
    /// <summary>
    /// SignatureRequestResponseDataValueCheckboxMerge
    /// </summary>
    [DataContract(Name = "SignatureRequestResponseDataValueCheckboxMerge")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueCheckbox), "checkbox")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueCheckboxMerge), "checkbox-merge")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueDateSigned), "date_signed")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueDropdown), "dropdown")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueInitials), "initials")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueRadio), "radio")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueSignature), "signature")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueText), "text")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseDataValueTextMerge), "text-merge")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SignatureRequestResponseDataValueCheckboxMerge : SignatureRequestResponseDataBase, IOpenApiTyped, IEquatable<SignatureRequestResponseDataValueCheckboxMerge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestResponseDataValueCheckboxMerge" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignatureRequestResponseDataValueCheckboxMerge() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestResponseDataValueCheckboxMerge" /> class.
        /// </summary>
        /// <param name="type">A checkbox field that has default value set by the api (default to &quot;checkbox-merge&quot;).</param>
        /// <param name="value">The value of the form field..</param>
        /// <param name="apiId">The unique ID for this field..</param>
        /// <param name="signatureId">The ID of the signature to which this response is linked..</param>
        /// <param name="name">The name of the form field..</param>
        /// <param name="required">A boolean value denoting if this field is required..</param>
        public SignatureRequestResponseDataValueCheckboxMerge(string type = "checkbox-merge", string value = default(string), string apiId = default(string), string signatureId = default(string), string name = default(string), bool required = default(bool))
        {
            this.ApiId = apiId;
            this.SignatureId = signatureId;
            this.Name = name;
            this.Required = required;
            
            // use default value if no "type" provided
            this.Type = type ?? "checkbox-merge";
            this.Value = value;
        }

        /// <summary>
        /// A checkbox field that has default value set by the api
        /// </summary>
        /// <value>A checkbox field that has default value set by the api</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The value of the form field.
        /// </summary>
        /// <value>The value of the form field.</value>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignatureRequestResponseDataValueCheckboxMerge {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as SignatureRequestResponseDataValueCheckboxMerge);
        }

        /// <summary>
        /// Returns true if SignatureRequestResponseDataValueCheckboxMerge instances are equal
        /// </summary>
        /// <param name="input">Instance of SignatureRequestResponseDataValueCheckboxMerge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureRequestResponseDataValueCheckboxMerge input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                int hashCode = base.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "type",
                Property = "Type",
                Type = "string",
                Value = Type,
            });
            types.Add(new OpenApiType(){
                Name = "value",
                Property = "Value",
                Type = "string",
                Value = Value,
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
