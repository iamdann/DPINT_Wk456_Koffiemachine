using KoffieMachineDomain.Decorator;
using System.Collections.Generic;

namespace KoffieMachineDomain.Drinks
{
    public class Tea : BaseDrinkDecorator
    {
        public Tea(IDrink iDrink) : base(iDrink)
        {
            Price = 0.5;
        }

        public override void LogText(ICollection<string> log)
        {
            base.LogText(log);
            log.Add($"Picked blend: {TeaBlend}, mixing your blend...");
            log.Add("Filling with tea...");
        }
    }
}
