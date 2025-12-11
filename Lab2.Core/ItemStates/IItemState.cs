using Lab2.Core.Items;

namespace Lab2.Core.ItemStates
{
    public interface IItemState
    {
        void Use(IItem item);
        void Upgrade(IItem item);
        string GetStatus();
    }
}
