using Lab2.Core.ItemStates;
using Lab2.Core.Strategies;

namespace Lab2.Core.Items
{
    public class Potion : BaseItem
    {
        public int RestoreAmount { get; set; }

        public Potion(string name, string description, int restoreAmount = 10) : base(name, description)
        {
            RestoreAmount = restoreAmount;
            UpgradeStrategy = new PotionUpgradeStrategy(10);
        }
    }
}
