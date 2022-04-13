
namespace HelloSign
{
    public class FieldGroup
    {
        public FieldGroup()
        {
            Rule = new Rule();
        }

        public string Name { get; set; }
        public Rule Rule { get; set; }
    }
}
