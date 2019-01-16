using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoffieMachineDomain.Decorator;
using TeaAndChocoLibrary;

namespace KoffieMachineDomain.Adapter
{
    public class ChocolateAdapter : BaseDrinkDecorator
    {
        protected HotChocolate chocolate;

        public ChocolateAdapter(IDrink iDrink) : base(iDrink)
        {
            chocolate = new HotChocolate();
        }

        protected double GetPrice()
        {
            return chocolate.Cost();
        }

        protected string GetName()
        {
            return chocolate.GetNameOfDrink();
        }

        protected ICollection<string> GetLogText()
        {
            return chocolate.GetBuildSteps().ToList();
        }
    }
}
