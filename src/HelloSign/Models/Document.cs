using System.Collections.Generic;

namespace HelloSign
{
    public class Document
    {
        public List<CustomField> CustomFields { get; set; }
        public List<FormField> FormFields { get; set; }
        public List<FieldGroup> FieldGroups { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }

        public Document()
        {
            CustomFields = new List<CustomField>();
            FormFields = new List<FormField>();
            FieldGroups = new List<FieldGroup>();
        }
    }
}
