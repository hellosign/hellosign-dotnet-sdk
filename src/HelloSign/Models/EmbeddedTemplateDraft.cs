using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HelloSign
{
    /// <summary>
    /// A new Template draft to be loaded in the Embedded Template editor
    /// </summary>
    public class EmbeddedTemplateDraft : SignatureRequest
    {
		public List<SignerRole> SignerRoles { get; set; }
        public List<MergeField> MergeFields { get; set; }

        public EmbeddedTemplateDraft() : base()
        {
            SignerRoles = new List<SignerRole>();
            MergeFields = new List<MergeField>();
        }

        /// <summary>
        /// Add a Signer Role to this template draft.
        /// </summary>
        /// <param name="name">Unique name for this role</param>
        /// <param name="order">Unique signer order from 0, or null if unordered</param>
        public void AddSignerRole(string name, int? order = null)
        {
            var role = new SignerRole();
            role.Name = name;
            role.Order = order;
            SignerRoles.Add(role);
        }
        
        /// <summary>
        /// Add a Signer Role to this template draft.
        /// </summary>
        /// <param name="name"></param>
        public void AddCcRole(string name)
        {
            Ccs.Add(name);
        }
        
        public void AddMergeField(string name, MergeField.FieldType type)
        {
            var mergeField = new MergeField();
            mergeField.Name = name;
            mergeField.Type = type;
            MergeFields.Add(mergeField);
        }
	}
	
	public class MergeField
	{
		public enum FieldType
        {
            [EnumMember(Value = "text")]
            Text,
            [EnumMember(Value = "checkbox")]
            Checkbox
        }

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FieldType Type { get; set; }
	}
}