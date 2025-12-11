using Lab2.Core.Items;
using Lab2.Core.Factories;
using Xunit;

namespace Lab2.Tests;

public class FactoryTests
{
    [Fact]
    public void WeaponFactory_ShouldCreateWeapon()
    {
        IItem item = new WeaponFactory().CreateItem("Меч", "Стальной меч");
        Assert.IsType<Weapon>(item);
    }

    [Fact]
    public void ArmorFactory_ShouldCreateArmor()
    {
        IItem item = new ArmorFactory().CreateItem("Шлем", "Железный шлем");
        Assert.IsType<Armor>(item);
    }

    [Fact]
    public void PotionFactory_ShouldCreatePotion()
    {
        IItem item = new PotionFactory().CreateItem("Зелье", "Восстанавливает здоровье");
        Assert.IsType<Potion>(item);
    }

    [Fact]
    public void QuestItemFactory_ShouldCreateQuestItem()
    {
        IItem item = new QuestItemFactory().CreateItem("Амулет", "Важный квестовый предмет");
        Assert.IsType<QuestItem>(item);
    }
}
