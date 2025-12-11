using Lab2.Core.ItemStates;
using Lab2.Core.Strategies;

namespace Lab2.Core.Items
{
    public abstract class BaseItem : IItem
    {
        public string Name { get; }

        public string Description { get; }

        public IItemState State { get; set; }

        public IUpgradeStrategy? UpgradeStrategy { get; set; }

        public BaseItem(string name, string description)
        {
            Name = name;
            Description = description;
            State = new NormalState();
        }

        public void Use()
        {
            State.Use(this);
        }

        public void ApplyUpgradeStrategy()
        {
            UpgradeStrategy?.ApplyUpgrade(this);
        }
    }
}
