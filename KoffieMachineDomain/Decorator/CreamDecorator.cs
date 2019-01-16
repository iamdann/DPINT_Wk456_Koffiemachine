using System.Collections.Generic;

namespace KoffieMachineDomain.Decorator
{
    public class CreamDecorator : BaseDrinkDecorator
    {
        public CreamDecorator(IDrink iDrink) : base(iDrink)
        {
            Price += 0.20;
        }

        public override void LogText(ICollection<string> log)
        {
            base.LogText(log);
            log.Add("Adding cream...");
        }
    }
}
