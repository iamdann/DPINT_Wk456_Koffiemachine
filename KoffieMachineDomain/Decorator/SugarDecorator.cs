using System.Collections.Generic;

namespace KoffieMachineDomain.Decorator
{
    public class SugarDecorator : BaseDrinkDecorator
    {
        public SugarDecorator(IDrink iDrink) : base(iDrink)
        {
            Price += 0.10;
        }

        public override void LogText(ICollection<string> log)
        {
            base.LogText(log);
            log.Add($"Setting sugar amount to {SugarAmount}.");
            log.Add("Adding sugar...");
        }
    }
}
