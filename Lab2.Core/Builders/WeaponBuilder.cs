using Lab2.Core.Items;
using Lab2.Core.Strategies;

namespace Lab2.Core.Builders
{
    public class WeaponBuilder
    {
        private string _name = "Default Weapon";
        private string _description = "No description";
        private int _damage = 5;
        private IUpgradeStrategy? _upgradeStrategy;

        public WeaponBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public WeaponBuilder SetDescription(string description)
        {
            _description = description;
            return this;
        }

        public WeaponBuilder SetDamage(int damage)
        {
            _damage = damage;
            return this;
        }

        public WeaponBuilder SetUpgradeStrategy(IUpgradeStrategy strategy)
        {
            _upgradeStrategy = strategy;
            return this;
        }

        public Weapon Build()
        {
            return new Weapon(_name, _description, _damage)
            {
                UpgradeStrategy = _upgradeStrategy
            };
        }
    }
}
