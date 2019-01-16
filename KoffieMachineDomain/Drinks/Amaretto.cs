using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoffieMachineDomain.Decorator;

namespace KoffieMachineDomain.Drinks
{
    class Amaretto : BaseDrinkDecorator
    {
        public Amaretto(IDrink iDrink) : base(iDrink)
        {
            Price += 1.3;
        }

        public override void LogText(ICollection<string> log)
        {
            base.LogText(log);
            log.Add("Adding amaretto");
        }
    }
}
