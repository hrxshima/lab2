using Lab2.Core.ItemStates;

namespace Lab2.Core.Items
{
    public interface IItem
    {
        string Name { get; }
        string Description { get; }
        IItemState State { get; set; }

        void Use();
    }
}
