using Lab2.Core.Items;

namespace Lab2.Core.Factories
{
    public class WeaponFactory : IItemFactory
    {
        public IItem CreateItem(string name, string description)
        {
            int defaultDamage = 10;
            return new Weapon(name, description, defaultDamage);
        }
    }
}
