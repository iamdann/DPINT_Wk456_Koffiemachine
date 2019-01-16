using KoffieMachineDomain.Drinks;
using KoffieMachineDomain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain.Decorator
{
    public class DrinkFactory
    {
        public IDrink MakeDrink(string name, Strength strength, Amount sugar, Amount milk, Blend blend)
        {
            IDrink drink = new Drink(name, strength, sugar, milk, blend);

            switch (name)
            {
                case "Coffee":
                    drink = new Coffee(drink);
                    break;
                case "Espresso":
                    drink = new Espresso(drink);
                    break;
                case "Capuccino":
                    drink = new Capuccino(drink);
                    break;
                case "Wiener Melange":
                    drink = new WienerMelange(drink);
                    break;
                case "Café au Lait":
                    drink = new CafeAuLait(drink);
                    break;
                case "Chocolate":
                    drink = new Chocolate(drink);
                    break;
                case "Chocolate Deluxe":
                    drink = new Chocolate(drink, true);
                    break;
                case "Tea":
                    drink = new Tea(drink);
                    break;
                case "CoffeeChoc":
                    drink = new Chocolate(new Coffee(drink));
                    break;
                case "IrishCoffee":
                    drink = new CreamDecorator(new Whiskey(new Coffee(drink)));
                    break;
                case "SpanishCoffee":
                    drink = new CreamDecorator(new Cointreau(new Cognac(new Coffee(drink))));
                    break;
                case "ItalianCoffee":
                    drink = new CreamDecorator(new Amaretto(new Coffee(drink)));
                    break;
            }

            return drink;
        }

        public IDrink AddSugar(IDrink drink)
        {
            return new SugarDecorator(drink);
        }

        public IDrink AddMilk(IDrink drink)
        {
            return new MilkDecorator(drink);
        }

        public IDrink AddSugarAndMilk(IDrink drink)
        {
            IDrink drinkWithSugar = AddSugar(drink);
            IDrink drinkWithSugarAndMilk = AddMilk(drinkWithSugar);
            return drinkWithSugarAndMilk;
        }
    }
}
