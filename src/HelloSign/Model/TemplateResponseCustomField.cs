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
    /// TemplateResponseCustomField
    /// </summary>
    [DataContract(Name = "TemplateResponseCustomField")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class TemplateResponseCustomField : IOpenApiTyped, IEquatable<TemplateResponseCustomField>, IValidatableObject
    {
        /// <summary>
        /// The type of this Custom Field. Only &#x60;text&#x60; and &#x60;checkbox&#x60; are currently supported.
        /// </summary>
        /// <value>The type of this Custom Field. Only &#x60;text&#x60; and &#x60;checkbox&#x60; are currently supported.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 1,

            /// <summary>
            /// Enum Checkbox for value: checkbox
            /// </summary>
            [EnumMember(Value = "checkbox")]
            Checkbox = 2

        }


        /// <summary>
        /// The type of this Custom Field. Only &#x60;text&#x60; and &#x60;checkbox&#x60; are currently supported.
        /// </summary>
        /// <value>The type of this Custom Field. Only &#x60;text&#x60; and &#x60;checkbox&#x60; are currently supported.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponseCustomField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateResponseCustomField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponseCustomField" /> class.
        /// </summary>
        /// <param name="name">The name of the Custom Field..</param>
        /// <param name="type">The type of this Custom Field. Only &#x60;text&#x60; and &#x60;checkbox&#x60; are currently supported..</param>
        /// <param name="x">The horizontal offset in pixels for this form field..</param>
        /// <param name="y">The vertical offset in pixels for this form field..</param>
        /// <param name="width">The width in pixels of this form field..</param>
        /// <param name="height">The height in pixels of this form field..</param>
        /// <param name="required">Boolean showing whether or not this field is required..</param>
        /// <param name="apiId">The unique ID for this field..</param>
        /// <param name="group">The name of the group this field is in. If this field is not a group, this defaults to &#x60;null&#x60;..</param>
        /// <param name="avgTextLength">avgTextLength.</param>
        /// <param name="isMultiline">Whether this form field is multiline text..</param>
        /// <param name="originalFontSize">Original font size used in this form field&#39;s text..</param>
        /// <param name="fontFamily">Font family used in this form field&#39;s text..</param>
        public TemplateResponseCustomField(string name = default(string), TypeEnum? type = default(TypeEnum?), int x = default(int), int y = default(int), int width = default(int), int height = default(int), bool required = default(bool), string apiId = default(string), string group = default(string), TemplateResponseFieldAvgTextLength avgTextLength = default(TemplateResponseFieldAvgTextLength), bool? isMultiline = default(bool?), int? originalFontSize = default(int?), string fontFamily = default(string))
        {
            
            this.Name = name;
            this.Type = type;
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Required = required;
            this.ApiId = apiId;
            this.Group = group;
            this.AvgTextLength = avgTextLength;
            this.IsMultiline = isMultiline;
            this.OriginalFontSize = originalFontSize;
            this.FontFamily = fontFamily;
        }

        /// <summary>
        /// The name of the Custom Field.
        /// </summary>
        /// <value>The name of the Custom Field.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The horizontal offset in pixels for this form field.
        /// </summary>
        /// <value>The horizontal offset in pixels for this form field.</value>
        [DataMember(Name = "x", EmitDefaultValue = true)]
        public int X { get; set; }

        /// <summary>
        /// The vertical offset in pixels for this form field.
        /// </summary>
        /// <value>The vertical offset in pixels for this form field.</value>
        [DataMember(Name = "y", EmitDefaultValue = true)]
        public int Y { get; set; }

        /// <summary>
        /// The width in pixels of this form field.
        /// </summary>
        /// <value>The width in pixels of this form field.</value>
        [DataMember(Name = "width", EmitDefaultValue = true)]
        public int Width { get; set; }

        /// <summary>
        /// The height in pixels of this form field.
        /// </summary>
        /// <value>The height in pixels of this form field.</value>
        [DataMember(Name = "height", EmitDefaultValue = true)]
        public int Height { get; set; }

        /// <summary>
        /// Boolean showing whether or not this field is required.
        /// </summary>
        /// <value>Boolean showing whether or not this field is required.</value>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// The unique ID for this field.
        /// </summary>
        /// <value>The unique ID for this field.</value>
        [DataMember(Name = "api_id", EmitDefaultValue = true)]
        public string ApiId { get; set; }

        /// <summary>
        /// The name of the group this field is in. If this field is not a group, this defaults to &#x60;null&#x60;.
        /// </summary>
        /// <value>The name of the group this field is in. If this field is not a group, this defaults to &#x60;null&#x60;.</value>
        [DataMember(Name = "group", EmitDefaultValue = true)]
        public string Group { get; set; }

        /// <summary>
        /// Gets or Sets AvgTextLength
        /// </summary>
        [DataMember(Name = "avg_text_length", EmitDefaultValue = true)]
        public TemplateResponseFieldAvgTextLength AvgTextLength { get; set; }

        /// <summary>
        /// Whether this form field is multiline text.
        /// </summary>
        /// <value>Whether this form field is multiline text.</value>
        [DataMember(Name = "isMultiline", EmitDefaultValue = true)]
        public bool? IsMultiline { get; set; }

        /// <summary>
        /// Original font size used in this form field&#39;s text.
        /// </summary>
        /// <value>Original font size used in this form field&#39;s text.</value>
        [DataMember(Name = "originalFontSize", EmitDefaultValue = true)]
        public int? OriginalFontSize { get; set; }

        /// <summary>
        /// Font family used in this form field&#39;s text.
        /// </summary>
        /// <value>Font family used in this form field&#39;s text.</value>
        [DataMember(Name = "fontFamily", EmitDefaultValue = true)]
        public string FontFamily { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateResponseCustomField {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  ApiId: ").Append(ApiId).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  AvgTextLength: ").Append(AvgTextLength).Append("\n");
            sb.Append("  IsMultiline: ").Append(IsMultiline).Append("\n");
            sb.Append("  OriginalFontSize: ").Append(OriginalFontSize).Append("\n");
            sb.Append("  FontFamily: ").Append(FontFamily).Append("\n");
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
            return this.Equals(input as TemplateResponseCustomField);
        }

        /// <summary>
        /// Returns true if TemplateResponseCustomField instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateResponseCustomField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateResponseCustomField input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.X == input.X ||
                    this.X.Equals(input.X)
                ) && 
                (
                    this.Y == input.Y ||
                    this.Y.Equals(input.Y)
                ) && 
                (
                    this.Width == input.Width ||
                    this.Width.Equals(input.Width)
                ) && 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.Required == input.Required ||
                    this.Required.Equals(input.Required)
                ) && 
                (
                    this.ApiId == input.ApiId ||
                    (this.ApiId != null &&
                    this.ApiId.Equals(input.ApiId))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.AvgTextLength == input.AvgTextLength ||
                    (this.AvgTextLength != null &&
                    this.AvgTextLength.Equals(input.AvgTextLength))
                ) && 
                (
                    this.IsMultiline == input.IsMultiline ||
                    (this.IsMultiline != null &&
                    this.IsMultiline.Equals(input.IsMultiline))
                ) && 
                (
                    this.OriginalFontSize == input.OriginalFontSize ||
                    (this.OriginalFontSize != null &&
                    this.OriginalFontSize.Equals(input.OriginalFontSize))
                ) && 
                (
                    this.FontFamily == input.FontFamily ||
                    (this.FontFamily != null &&
                    this.FontFamily.Equals(input.FontFamily))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.X.GetHashCode();
                hashCode = (hashCode * 59) + this.Y.GetHashCode();
                hashCode = (hashCode * 59) + this.Width.GetHashCode();
                hashCode = (hashCode * 59) + this.Height.GetHashCode();
                hashCode = (hashCode * 59) + this.Required.GetHashCode();
                if (this.ApiId != null)
                {
                    hashCode = (hashCode * 59) + this.ApiId.GetHashCode();
                }
                if (this.Group != null)
                {
                    hashCode = (hashCode * 59) + this.Group.GetHashCode();
                }
                if (this.AvgTextLength != null)
                {
                    hashCode = (hashCode * 59) + this.AvgTextLength.GetHashCode();
                }
                if (this.IsMultiline != null)
                {
                    hashCode = (hashCode * 59) + this.IsMultiline.GetHashCode();
                }
                if (this.OriginalFontSize != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalFontSize.GetHashCode();
                }
                if (this.FontFamily != null)
                {
                    hashCode = (hashCode * 59) + this.FontFamily.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "name",
                Property = "Name",
                Type = "string",
                Value = Name,
            });
            types.Add(new OpenApiType(){
                Name = "type",
                Property = "Type",
                Type = "string",
                Value = Type,
            });
            types.Add(new OpenApiType(){
                Name = "x",
                Property = "X",
                Type = "int",
                Value = X,
            });
            types.Add(new OpenApiType(){
                Name = "y",
                Property = "Y",
                Type = "int",
                Value = Y,
            });
            types.Add(new OpenApiType(){
                Name = "width",
                Property = "Width",
                Type = "int",
                Value = Width,
            });
            types.Add(new OpenApiType(){
                Name = "height",
                Property = "Height",
                Type = "int",
                Value = Height,
            });
            types.Add(new OpenApiType(){
                Name = "required",
                Property = "Required",
                Type = "bool",
                Value = Required,
            });
            types.Add(new OpenApiType(){
                Name = "api_id",
                Property = "ApiId",
                Type = "string",
                Value = ApiId,
            });
            types.Add(new OpenApiType(){
                Name = "group",
                Property = "Group",
                Type = "string",
                Value = Group,
            });
            types.Add(new OpenApiType(){
                Name = "avg_text_length",
                Property = "AvgTextLength",
                Type = "TemplateResponseFieldAvgTextLength",
                Value = AvgTextLength,
            });
            types.Add(new OpenApiType(){
                Name = "isMultiline",
                Property = "IsMultiline",
                Type = "bool?",
                Value = IsMultiline,
            });
            types.Add(new OpenApiType(){
                Name = "originalFontSize",
                Property = "OriginalFontSize",
                Type = "int?",
                Value = OriginalFontSize,
            });
            types.Add(new OpenApiType(){
                Name = "fontFamily",
                Property = "FontFamily",
                Type = "string",
                Value = FontFamily,
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
