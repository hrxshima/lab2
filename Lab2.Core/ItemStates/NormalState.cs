using System;
using Lab2.Core.Items;

namespace Lab2.Core.ItemStates
{
    public class NormalState : IItemState
    {
        public void Use(IItem item)
        {
            Console.WriteLine($"{item.Name} используется в обычном состоянии.");

            if (item is Weapon)
            {
                item.State = new BrokenState();
            }

            if (item is Potion)
            {
                item.State = new BrokenState();
            }
        }

        public void Upgrade(IItem item)
        {
            if (item is BaseItem baseItem)
            {
                baseItem.UpgradeStrategy?.ApplyUpgrade(baseItem);
                Console.WriteLine($"{item.Name} улучшен!");
                baseItem.State = new EnhancedState();
            }
        }

        public string GetStatus()
        {
            return "Normal";
        }
    }
}
