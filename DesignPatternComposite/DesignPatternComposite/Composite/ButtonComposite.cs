using System;
using System.Collections.Generic;
using DesignPatternComposite.Component;

namespace DesignPatternComposite.Composite
{
    class ButtonComposite : ItemComponent
    {
        private List<ItemComponent> _items = new List<ItemComponent>();

        public ButtonComposite(string name)
            : base(name)
        {

        }

        public void AddItem(ItemComponent item)
        {
            _items.Add(item);
            Console.WriteLine($"[{item.GetName}] added to button");
        }

        public void RemoveItem(ItemComponent item)
        {
            _items.Remove(item);
            Console.WriteLine($"[{item.GetName}] removed from button:");
        }

        public void ShowItem()
        {
            Console.WriteLine("BUTTON COMPONENTS \n");
            foreach (var item in _items)
            {
                Console.WriteLine($"[{item.GetName}] added to button");
            }
        }
    }
}
