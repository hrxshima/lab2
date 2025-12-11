using Lab2.Core.Items;

namespace Lab2.Core.Strategies
{
    public class WeaponUpgradeStrategy : IUpgradeStrategy
    {
        private readonly int _extraDamage;

        public WeaponUpgradeStrategy(int extraDamage)
        {
            _extraDamage = extraDamage;
        }

        public void ApplyUpgrade(BaseItem item)
        {
            if (item is Weapon weapon)
            {
                weapon.IncreaseDamage(_extraDamage);
            }
        }
    }
}