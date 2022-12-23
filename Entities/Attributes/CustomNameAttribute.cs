namespace Entities.Attributes
{
    public class CustomNameAttribute : Attribute
    {
        public CustomNameAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
