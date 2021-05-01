using DesignPatternComposite.Component;
using System;
using System.Collections.Generic;

namespace DesignPatternComposite.Composite
{
    class WindowComposite : ItemComponent
    {
        private List<ItemComponent> _items = new List<ItemComponent>();

        public WindowComposite(string name)
            : base(name)
        {

        }

        public void AddItem(ItemComponent item)
        {
            _items.Add(item);
            Console.WriteLine($"[{item.GetName}] added to window");
        }

        public void RemoveItem(ItemComponent item)
        {
            _items.Remove(item);
            Console.WriteLine($"[{item.GetName}] removed from window:");
        }

        public void ShowItem()
        {
            Console.WriteLine("\n WINDOW COMPONENTS \n");
            foreach (var item in _items)
            {
                Console.WriteLine($"[{item.GetName}]");
            }
        }
    }
}
