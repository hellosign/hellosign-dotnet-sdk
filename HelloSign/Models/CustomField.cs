using System.Collections.Generic;

namespace HelloSign
{
    /// <summary>
    /// Information about a Custom Field in a Template.
    /// </summary>
    public class CustomField
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
    }
}
