using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class SodaFactory : Factory
    {
        private List<Soda> FactorySodaStorage = new List<Soda>();
        public override void MakeProduct(Product.Types type, int amount)
        {
            for (var i = 0; i < amount; i++)
            {
                FactorySodaStorage.Add(new Soda(type));
            }
        }
        public override void SendProductToStorage()
        {
            Storage.StorageContainer = FactorySodaStorage;
            FactorySodaStorage.Clear();
        }
    }
}
