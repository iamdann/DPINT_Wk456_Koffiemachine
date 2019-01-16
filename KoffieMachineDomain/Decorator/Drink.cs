using KoffieMachineDomain.Decorator;
using KoffieMachineDomain.Enums;
using System.Collections.Generic;

namespace KoffieMachineDomain
{
    public class Drink : IDrink
    {
        public Amount MilkAmount { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Strength Strength { get; set; }
        public Amount SugarAmount { get; set; }
        public Blend TeaBlend { get; set; }

        public Drink(string name, Strength strength, Amount sugarAmount, Amount milkAmount, Blend blend)
        {
            Name = name;
            Strength = strength;
            SugarAmount = sugarAmount;
            MilkAmount = milkAmount;
            TeaBlend = blend;
        }

        public void LogText(ICollection<string> log)
        {
            log.Add($"Making {Name}...");
            log.Add($"Heating up...");
        }
    }
}
