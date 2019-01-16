using System;
using TeaAndChocoLibrary;
using System.Drawing;

namespace KoffieMachineDomain.Adapter
{
    public class TeaAdapter
    {
        private Tea tea;

        private string name;

        private Color bagColor;

        public TeaAdapter(TeaBlend teaBlend)
        {
            tea = new Tea();

            name = teaBlend.Name;
            bagColor = teaBlend.BagColor;
        }

        public double GetPrice()
        {
            return Tea.Price;
        }

        public string GetName()
        {
            return name;
        }

        public Color GetColor()
        {
            return bagColor;
        }
    }
}
