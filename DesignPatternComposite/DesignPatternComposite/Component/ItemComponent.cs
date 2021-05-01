namespace DesignPatternComposite.Component
{
    abstract class ItemComponent
    {
        protected string Name;

        public ItemComponent(string name)
        {
            Name = name;
        }

        public string GetName
        {
            get { return Name; }
        }
    }
}
