using System;
using Lab2.Core.Items;
using Lab2.Core.Factories;
using Lab2.Core.Inventory;
using Lab2.Core.Builders;
using Lab2.Core.Strategies;
using Lab2.Core.Combiner;

namespace Lab2.App
{
    class Program
    {
        static void Main()
        {
            var inventory = new PlayerInventory();

            var sword = (Weapon)new WeaponFactory().CreateItem("Меч", "Стальной меч");
            var armor = (Armor)new ArmorFactory().CreateItem("Шлем", "Железный шлем");
            var potion = (Potion)new PotionFactory().CreateItem("Зелье", "Восстанавливает здоровье");

            var greatsword = new WeaponBuilder()
                .SetName("Крутой меч")
                .SetDamage(20)
                .SetUpgradeStrategy(new WeaponUpgradeStrategy(10))
                .Build();

            inventory.AddItem(sword);
            inventory.AddItem(armor);
            inventory.AddItem(potion);
            inventory.AddItem(greatsword);

            sword.Use(); 
            sword.Use();  

            potion.Use();  

            greatsword.ApplyUpgradeStrategy();

            var combined = ItemCombiner.Combine(sword, greatsword);
            if (combined != null)
                inventory.AddItem(combined);

            inventory.ListItems();
        }
    }
}
