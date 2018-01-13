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
        public string Api_Id { get; set; }
        public CustomFieldInfo Avg_Text_Length { get; set; }

        public class CustomFieldInfo
        {
            public int Num_Lines { get; set; }
            public int Num_Chars_Per_Line { get; set; }
        }
    }
}
