using System;
using Lab2.Core.Items;

namespace Lab2.Core.Combiner
{
    public static class ItemCombiner
    {
        public static IItem? Combine(IItem a, IItem b)
        {
            if (a is Weapon wa && b is Weapon wb)
            {
                var name = $"{wa.Name}-{wb.Name}";
                var description = $"комбинация оружий {wa.Name} + {wb.Name}";
                var damage = wa.Damage + wb.Damage;

                Console.WriteLine($"создано комбинированное оружие: {name} ({damage} урона)");

                return new Weapon(name, description, damage);
            }

            Console.WriteLine("эти предметы нельзя комбинировать.");
            return null;
        }
    }
}
