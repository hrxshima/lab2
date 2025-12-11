using System;
using System.Collections.Generic;
using System.Linq;
using Lab2.Core.Items;

namespace Lab2.Core.Inventory
{
    public class PlayerInventory : IInventory
    {
        private readonly List<IItem> _items = new();

        public void AddItem(IItem item)
        {
            _items.Add(item);
            Console.WriteLine($"{item.Name} добавлен в инвентарь.");
        }

        public bool RemoveItem(IItem item)
        {
            var removed = _items.Remove(item);
            if (removed)
                Console.WriteLine($"{item.Name} удален из инвентаря.");
            return removed;
        }

        public void ListItems()
        {
            if (_items.Count == 0)
            {
                Console.WriteLine("инвентарь пуст.");
                return;
            }

            Console.WriteLine("Инвентарь:");
            foreach (var item in _items)
                Console.WriteLine($"- {item.Name} ({item.State.GetStatus()})");
        }
    }
}
