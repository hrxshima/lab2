using Lab2.Core.ItemStates;
using Lab2.Core.Strategies;

namespace Lab2.Core.Items
{
    public class Armor : BaseItem
    {
        public int Defense { get; internal set; }

        public Armor(string name, string description, int defense) : base(name, description)
        {
            Defense = defense;
            UpgradeStrategy = new ArmorUpgradeStrategy(3);
        }

        public void IncreaseDefense(int amount) => Defense += amount;
    }
}
