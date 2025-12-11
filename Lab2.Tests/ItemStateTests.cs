using Lab2.Core.Items;
using Lab2.Core.ItemStates;
using Lab2.Core.Strategies;
using Xunit;

namespace Lab2.Tests;

public class ItemStateTests
{
    [Fact]
    public void WeaponUse_ShouldChangeStateToBroken()
    {
        var weapon = new Weapon("Меч", "Стальной меч", 10);

        weapon.Use();

        Assert.IsType<BrokenState>(weapon.State);
    }

    [Fact]
    public void Upgrade_ShouldApplyStrategyAndChangeStateToEnhanced()
    {
        var weapon = new Weapon("Меч", "Стальной меч", 10);
        var strategy = new WeaponUpgradeStrategy(5);
        weapon.UpgradeStrategy = strategy;

        weapon.State.Upgrade(weapon);

        Assert.IsType<EnhancedState>(weapon.State);
        Assert.Equal(15, weapon.Damage);
    }
}
