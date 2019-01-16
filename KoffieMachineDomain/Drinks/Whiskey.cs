using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoffieMachineDomain.Decorator;

namespace KoffieMachineDomain.Drinks
{
    class Whiskey : BaseDrinkDecorator
    {
        public Whiskey(IDrink iDrink) : base(iDrink)
        {
            Price += 1;
        }

        public override void LogText(ICollection<string> log)
        {
            base.LogText(log);
            log.Add("Adding whiskey");
        }
    }
}
