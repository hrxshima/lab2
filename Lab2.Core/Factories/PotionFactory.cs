using Lab2.Core.Items;

namespace Lab2.Core.Factories
{
    public class PotionFactory : IItemFactory
    {
        public IItem CreateItem(string name, string description)
        {
            int defaultRestore = 10;
            return new Potion(name, description, defaultRestore);
        }
    }
}
