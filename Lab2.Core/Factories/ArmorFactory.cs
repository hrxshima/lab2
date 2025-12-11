using Lab2.Core.Items;

namespace Lab2.Core.Factories
{
    public class ArmorFactory : IItemFactory
    {
        public IItem CreateItem(string name, string description)
        {
            int defaultDefense = 5;
            return new Armor(name, description, defaultDefense);
        }
    }
}
