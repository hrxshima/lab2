using Lab2.Core.Items;

namespace Lab2.Core.Inventory
{
    public interface IInventory
    {
        void AddItem(IItem item);
        bool RemoveItem(IItem item);
        void ListItems();
    }
}
