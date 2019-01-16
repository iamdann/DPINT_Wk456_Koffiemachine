using System.Collections.Generic;
using KoffieMachineDomain.Enums;

namespace KoffieMachineDomain.Decorator
{
    public abstract class BaseDrinkDecorator : IDrink
    {
        private IDrink _iDrink;

        protected BaseDrinkDecorator(IDrink iDrink)
        {
            _iDrink = iDrink;
        }

        public Amount MilkAmount
        {
            get => _iDrink.MilkAmount;
            set => _iDrink.MilkAmount = value;
        }

        public string Name
        {
            get => _iDrink.Name;
            set => _iDrink.Name = value;
        }

        public double Price
        {
            get => _iDrink.Price;
            set => _iDrink.Price = value;
        }

        public Strength Strength
        {
            get => _iDrink.Strength;
            set => _iDrink.Strength = value;
        }

        public Amount SugarAmount
        {
            get => _iDrink.SugarAmount;
            set => _iDrink.SugarAmount = value;
        }

        public Blend TeaBlend
        {
            get => _iDrink.TeaBlend;
            set => _iDrink.TeaBlend = value;
        }

        public virtual void LogText(ICollection<string> log)
        {
            _iDrink.LogText(log);
        }
    }
}
