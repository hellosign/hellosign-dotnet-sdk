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
using OpenAPIDateConverter = Org.HelloSign.Client.OpenAPIDateConverter;

namespace Org.HelloSign.Model
{
    /// <summary>
    /// EmbeddedEditUrlResponse
    /// </summary>
    [DataContract(Name = "EmbeddedEditUrlResponse")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class EmbeddedEditUrlResponse : IOpenApiTyped, IEquatable<EmbeddedEditUrlResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedEditUrlResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmbeddedEditUrlResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedEditUrlResponse" /> class.
        /// </summary>
        /// <param name="embedded">embedded.</param>
        /// <param name="warnings">A list of warnings..</param>
        public EmbeddedEditUrlResponse(EmbeddedEditUrlResponseEmbedded embedded = default(EmbeddedEditUrlResponseEmbedded), List<WarningResponse> warnings = default(List<WarningResponse>))
        {
            
            this.Embedded = embedded;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Gets or Sets Embedded
        /// </summary>
        [DataMember(Name = "embedded", EmitDefaultValue = true)]
        public EmbeddedEditUrlResponseEmbedded Embedded { get; set; }

        /// <summary>
        /// A list of warnings.
        /// </summary>
        /// <value>A list of warnings.</value>
        [DataMember(Name = "warnings", EmitDefaultValue = true)]
        public List<WarningResponse> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmbeddedEditUrlResponse {\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(input as EmbeddedEditUrlResponse);
        }

        /// <summary>
        /// Returns true if EmbeddedEditUrlResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmbeddedEditUrlResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbeddedEditUrlResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Embedded == input.Embedded ||
                    (this.Embedded != null &&
                    this.Embedded.Equals(input.Embedded))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                if (this.Embedded != null)
                {
                    hashCode = (hashCode * 59) + this.Embedded.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "embedded",
                Property = "Embedded",
                Type = "EmbeddedEditUrlResponseEmbedded",
                Value = Embedded,
            });
            types.Add(new OpenApiType(){
                Name = "warnings",
                Property = "Warnings",
                Type = "List<WarningResponse>",
                Value = Warnings,
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