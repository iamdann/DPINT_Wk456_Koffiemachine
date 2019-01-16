using KoffieMachineDomain.Decorator;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain
{
    public class Coffee : BaseDrinkDecorator
    {
        public Coffee(IDrink iDrink) : base(iDrink)
        {
            Price = 1;
        }

        public override void LogText(ICollection<string> log)
        {
            base.LogText(log);
            log.Add($"Setting coffee strength to {Strength}.");
            log.Add("Filling with coffee...");
        }
    }
}
