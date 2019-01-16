using KoffieMachineDomain.Decorator;
using System.Collections.Generic;
using System.Linq;
using KoffieMachineDomain.Adapter;

namespace KoffieMachineDomain.Drinks
{
    public class Chocolate : ChocolateAdapter
    {
        public Chocolate(IDrink iDrink, bool isDeluxe = false) : base(iDrink)
        {
            Price = GetPrice();
            Name = GetName();
            MilkAmount = Amount.Extra;

            if(isDeluxe)
                chocolate.MakeDeluxe();
        }

        public override void LogText(ICollection<string> log)
        {
            base.LogText(log);
            log.Concat(GetLogText());
        }
    }
}
