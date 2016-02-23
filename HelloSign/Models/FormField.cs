using System.Net.Configuration;

namespace HelloSign
{
    public class FormField
    {
        public enum FormFieldType
        {
            Text,
            Checkbox,
            DateSigned,
            Initials,
            Signature
        }
        
        public string ApiId { get; set; }
        public string Name { get; set; }
        public FormFieldType Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Required { get; set; }
        public int Signer { get; set; }
        public int File { get; set; }
        public int Page { get; set; }

        public FormField() { }

        public FormField(string apiId, FormFieldType type, int page, int x, int y, int width, int height, bool required, int signer)
        {
            ApiId = apiId;
            Type = type;
            Page = page;
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Required = required;
            Signer = signer;
        }
    }
}