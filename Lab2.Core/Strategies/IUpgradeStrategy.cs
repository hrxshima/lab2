using Lab2.Core.Items;

namespace Lab2.Core.Strategies
{
    public interface IUpgradeStrategy
    {
        void ApplyUpgrade(BaseItem item);
    }
}
