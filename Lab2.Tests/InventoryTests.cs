using Lab2.Core.Inventory;
using Lab2.Core.Items;
using Lab2.Core.Factories;
using Xunit;

namespace Lab2.Tests
{
    public class InventoryTests
    {
        [Fact]
        public void AddItem_ShouldIncreaseInventory()
        {
            var inventory = new PlayerInventory();
            var sword = new WeaponFactory().CreateItem("Меч", "Стальной меч");

            inventory.AddItem(sword);
            bool removed = inventory.RemoveItem(sword);

            Assert.True(removed);
        }

        [Fact]
        public void RemoveItem_ShouldReturnFalseIfNotExist()
        {
            var inventory = new PlayerInventory();
            var sword = new WeaponFactory().CreateItem("Меч", "Стальной меч");

            bool removed = inventory.RemoveItem(sword);

            Assert.False(removed);
        }

        [Fact]
        public void ListItems_ShouldNotThrow()
        {
            var inventory = new PlayerInventory();
            var sword = new WeaponFactory().CreateItem("Меч", "Стальной меч");

            inventory.AddItem(sword);

            var exception = Record.Exception(() => inventory.ListItems());
            Assert.Null(exception);
        }
    }
}
