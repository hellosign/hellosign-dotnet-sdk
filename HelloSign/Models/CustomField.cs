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
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Required { get; set; }
        public string ApiId { get; set; }
        public CustomFieldInfo AvgTextLength { get; set; }

        public class CustomFieldInfo 
        {
            public int NumLines { get; set; }
            public int NumCharsPerLine { get; set; }
        }
    }
}
