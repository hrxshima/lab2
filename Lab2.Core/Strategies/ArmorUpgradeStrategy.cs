using Lab2.Core.Items;

namespace Lab2.Core.Strategies
{
    public class ArmorUpgradeStrategy : IUpgradeStrategy
    {
        private readonly int _extraDefense;

        public ArmorUpgradeStrategy(int extraDefense)
        {
            _extraDefense = extraDefense;
        }

        public void ApplyUpgrade(BaseItem item)
        {
            if (item is Armor armor)
            {
                armor.Defense += _extraDefense;
            }
        }
    }
}
