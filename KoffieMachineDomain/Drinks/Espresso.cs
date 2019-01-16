using KoffieMachineDomain.Decorator;
using System.Collections.Generic;

namespace KoffieMachineDomain
{
    public class Espresso : BaseDrinkDecorator
    {
        public Espresso(IDrink iDrink) : base(iDrink)
        {
            Price = 1.7;
            Strength = Strength.Strong;
            MilkAmount = Amount.Few;
        }

        public override void LogText(ICollection<string> log)
        {
            base.LogText(log);
            log.Add($"Setting coffee strength to {Strength.Strong}.");
            log.Add("Filling with coffee...");

            log.Add("Creaming milk...");
        }
    }
}
