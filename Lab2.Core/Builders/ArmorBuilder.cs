using Lab2.Core.Items;
using Lab2.Core.Strategies;

namespace Lab2.Core.Builders
{
    public class ArmorBuilder
    {
        private string _name = "Default Armor";
        private string _description = "No description";
        private int _defense = 3;
        private IUpgradeStrategy? _upgradeStrategy;

        public ArmorBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public ArmorBuilder SetDescription(string description)
        {
            _description = description;
            return this;
        }

        public ArmorBuilder SetUpgradeStrategy(IUpgradeStrategy strategy)
        {
            _upgradeStrategy = strategy;
            return this;
        }

        public Armor Build()
        {
            return new Armor(_name, _description, _defense)
            {
                UpgradeStrategy = _upgradeStrategy
            };
        }
    }
}
