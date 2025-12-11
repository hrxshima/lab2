using System;
using Lab2.Core.Items;

namespace Lab2.Core.ItemStates
{ 
    public class EnhancedState : IItemState
    { 
        public void Use(IItem item)
        {
            Console.WriteLine($"{item.Name} используется с повышенной эффективностью!");
            item.State = new NormalState();
        }

        public void Upgrade(IItem item)
        {
            Console.WriteLine($"{item.Name} уже улучшен - нельзя улучшить снова.");
        }

        public string GetStatus()
        {
            return "Enhanced";
        }
    }
}
