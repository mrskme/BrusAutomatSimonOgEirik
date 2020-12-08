using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class Product
    {
        public enum Types { CocaCola, Fanta, Solo, Battery, Water, ChocolateBar /*addMoreCandystuff*/ };
        public double Price;
        private Types Type;

        public Product(Types type)
        {
            Type = type;
        }
    }
}
