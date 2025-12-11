using System;
using Lab2.Core.Items;

namespace Lab2.Core.ItemStates
{
    public class BrokenState : IItemState
    {
        public void Use(IItem item)
        {
            Console.WriteLine($"{item.Name} сломан и не может быть использован.");
        }

        public void Upgrade(IItem item)
        {
            Console.WriteLine($"{item.Name} отремонтирован!");
            item.State = new NormalState();
        }

        public string GetStatus()
        {
            return "Broken";
        }
    }
}
