using Lab2.Core.Items;

namespace Lab2.Core.Strategies
{
    public class PotionUpgradeStrategy : IUpgradeStrategy
    {
        private readonly int _extraRestore;

        public PotionUpgradeStrategy(int extraRestore)
        {
            _extraRestore = extraRestore;
        }

        public void ApplyUpgrade(BaseItem item)
        {
            if (item is Potion potion)
            {
                potion.RestoreAmount += _extraRestore;
            }
        }
    }
}
