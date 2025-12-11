using Lab2.Core.ItemStates;
using Lab2.Core.Strategies;

namespace Lab2.Core.Items
{ 
    public class Weapon : BaseItem
    {
        public int Damage { get; private set; } 

        public Weapon(string name, string description, int damage) 
            : base(name, description)
        {
            Damage = damage;
            UpgradeStrategy = new WeaponUpgradeStrategy(5);
        }

        public void IncreaseDamage(int amount) => Damage += amount;
    }
}
