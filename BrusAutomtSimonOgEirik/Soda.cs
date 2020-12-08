using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class Soda : Product
    {
        //public enum Types { CocaCola, Fanta, Solo, Battery, Water, ChocolateBar };
        //private string[] Typess = new [] { "Coca Cola", "Fanta", "Solo", "Water" };

        public Soda(Types type) :base(type)
        {
            if (type == Types.CocaCola)
            {
                Price = 200;
            }
            if (type == Types.Fanta)
            {
                Price = 1;
            }
            if (type == Types.Solo)
            {
                Price = 69;
            }
            if (type == Types.Battery)
            {
                Price = 13.37;
            }
            if (type == Types.Water)
            {
                Price = 420;
            }
        }
    }
}
