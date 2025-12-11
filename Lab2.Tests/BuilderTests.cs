using Lab2.Core.Builders;
using Lab2.Core.Items;
using Lab2.Core.Strategies;
using Xunit;

namespace Lab2.Tests;

public class BuilderTests
{
    [Fact]
    public void WeaponBuilder_ShouldCreateWeaponWithCorrectProperties()
    {
        var weapon = new WeaponBuilder()
            .SetName("Крутой меч")
            .SetDamage(20)
            .SetUpgradeStrategy(new WeaponUpgradeStrategy(10))
            .Build();

        Assert.Equal("Крутой меч", weapon.Name);
        Assert.Equal(20, weapon.Damage);
        Assert.NotNull(weapon.UpgradeStrategy);
    }
}
