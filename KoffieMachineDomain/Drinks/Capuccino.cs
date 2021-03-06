﻿using KoffieMachineDomain.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain
{
    public class Capuccino : BaseDrinkDecorator
    {
        public Capuccino(IDrink iDrink) : base(iDrink)
        {
            Price = 1.8;
        }

        public override void LogText(ICollection<string> log)
        {
            base.LogText(log);
            log.Add($"Setting coffee strength to {Strength}.");
            log.Add("Filling with coffee...");

            log.Add("Creaming milk...");
            log.Add("Adding milk to coffee...");
        }
    }
}
