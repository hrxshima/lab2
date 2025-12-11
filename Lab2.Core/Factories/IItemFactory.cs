using Lab2.Core.Items;

namespace Lab2.Core.Factories
{
    public interface IItemFactory
    {
        IItem CreateItem(string name, string description);
    }
}
