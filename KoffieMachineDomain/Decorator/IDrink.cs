using KoffieMachineDomain.Enums;
using System.Collections.Generic;

namespace KoffieMachineDomain.Decorator
{
    public interface IDrink
    {
        string Name { get; set; }
        Amount SugarAmount { get; set; }
        Amount MilkAmount { get; set; }
        Strength Strength { get; set; }
        Blend TeaBlend { get; set; }
        double Price { get; set; }

        void LogText(ICollection<string> log);
    }
}
