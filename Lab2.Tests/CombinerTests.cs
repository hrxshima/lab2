using Lab2.Core.Combiner;
using Lab2.Core.Items;
using Xunit;

namespace Lab2.Tests;

public class CombinerTests
{
    [Fact]
    public void CombineTwoWeapons_ShouldReturnNewWeaponWithSummedDamage()
    {
        var weaponA = new Weapon("Меч A", "Обычный меч", 10);
        var weaponB = new Weapon("Меч B", "Обычный меч", 15);

        var combined = ItemCombiner.Combine(weaponA, weaponB);

        Assert.NotNull(combined);
        Assert.IsType<Weapon>(combined);
        Assert.Equal(25, ((Weapon)combined).Damage);
    }

    [Fact]
    public void CombineWeaponAndArmor_ShouldReturnNull()
    {
        var weapon = new Weapon("Меч", "Стальной меч", 10);
        var armor = new Armor("Шлем", "Железный шлем", 5);

        var combined = ItemCombiner.Combine(weapon, armor);

        Assert.Null(combined);
    }
}
