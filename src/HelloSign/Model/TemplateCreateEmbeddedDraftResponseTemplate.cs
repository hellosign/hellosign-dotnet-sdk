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
    /// Template object with parameters: &#x60;template_id&#x60;, &#x60;edit_url&#x60;, &#x60;expires_at&#x60;.
    /// </summary>
    [DataContract(Name = "TemplateCreateEmbeddedDraftResponseTemplate")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class TemplateCreateEmbeddedDraftResponseTemplate : IOpenApiTyped, IEquatable<TemplateCreateEmbeddedDraftResponseTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateCreateEmbeddedDraftResponseTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateCreateEmbeddedDraftResponseTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateCreateEmbeddedDraftResponseTemplate" /> class.
        /// </summary>
        /// <param name="templateId">The id of the Template..</param>
        /// <param name="editUrl">Link to edit the template..</param>
        /// <param name="expiresAt">When the link expires..</param>
        /// <param name="warnings">A list of warnings..</param>
        public TemplateCreateEmbeddedDraftResponseTemplate(string templateId = default(string), string editUrl = default(string), int expiresAt = default(int), List<WarningResponse> warnings = default(List<WarningResponse>))
        {
            
            this.TemplateId = templateId;
            this.EditUrl = editUrl;
            this.ExpiresAt = expiresAt;
            this.Warnings = warnings;
        }

        /// <summary>
        /// The id of the Template.
        /// </summary>
        /// <value>The id of the Template.</value>
        [DataMember(Name = "template_id", EmitDefaultValue = true)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Link to edit the template.
        /// </summary>
        /// <value>Link to edit the template.</value>
        [DataMember(Name = "edit_url", EmitDefaultValue = true)]
        public string EditUrl { get; set; }

        /// <summary>
        /// When the link expires.
        /// </summary>
        /// <value>When the link expires.</value>
        [DataMember(Name = "expires_at", EmitDefaultValue = true)]
        public int ExpiresAt { get; set; }

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
            sb.Append("class TemplateCreateEmbeddedDraftResponseTemplate {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  EditUrl: ").Append(EditUrl).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
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
            return this.Equals(input as TemplateCreateEmbeddedDraftResponseTemplate);
        }

        /// <summary>
        /// Returns true if TemplateCreateEmbeddedDraftResponseTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateCreateEmbeddedDraftResponseTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateCreateEmbeddedDraftResponseTemplate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.EditUrl == input.EditUrl ||
                    (this.EditUrl != null &&
                    this.EditUrl.Equals(input.EditUrl))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    this.ExpiresAt.Equals(input.ExpiresAt)
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
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.EditUrl != null)
                {
                    hashCode = (hashCode * 59) + this.EditUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
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
                Name = "template_id",
                Property = "TemplateId",
                Type = "string",
                Value = TemplateId,
            });
            types.Add(new OpenApiType(){
                Name = "edit_url",
                Property = "EditUrl",
                Type = "string",
                Value = EditUrl,
            });
            types.Add(new OpenApiType(){
                Name = "expires_at",
                Property = "ExpiresAt",
                Type = "int",
                Value = ExpiresAt,
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
