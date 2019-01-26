using Newtonsoft.Json;
using System.Collections.Generic;

namespace HelloSign
{
    /// <summary>
    /// Information about a Custom Field in a Template.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CustomField
    {
        // These properties are used when defining custom field values to send in a request
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("editor")]
        public string Editor { get; set; }
        [JsonProperty("required")]
        public bool Required { get; set; }

        // Properties below are just used when deserializing API responses
        public string Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string ApiId { get; set; }
        public CustomFieldInfo AvgTextLength { get; set; }

        public class CustomFieldInfo 
        {
            public int NumLines { get; set; }
            public int NumCharsPerLine { get; set; }
        }
    }
}
