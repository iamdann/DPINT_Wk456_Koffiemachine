using KoffieMachineDomain.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain
{
    public class CafeAuLait : BaseDrinkDecorator
    {
        public CafeAuLait(IDrink iDrink) : base(iDrink)
        {
            Price = 1.5;
        }

        public override void LogText(ICollection<string> log)
        {
            base.LogText(log);
            log.Add("Filling half with coffee...");
            log.Add("Filling other half with milk...");
            log.Add($"Finished making {Name}");
        }
    }
}
