using System.Collections.Generic;

namespace KoffieMachineDomain.Decorator
{
    public class MilkDecorator : BaseDrinkDecorator
    {
        public MilkDecorator(IDrink iDrink) : base(iDrink)
        {
            Price += 0.15;
        }

        public override void LogText(ICollection<string> log)
        {
            base.LogText(log);
            log.Add($"Setting milk amount to {MilkAmount}.");
            log.Add("Adding milk...");
        }
    }
}
