using Lab2.Core.Items;

namespace Lab2.Core.Factories
{
    public class QuestItemFactory : IItemFactory
    {
        public IItem CreateItem(string name, string description)
        {
            return new QuestItem(name, description);
        }
    }
}
