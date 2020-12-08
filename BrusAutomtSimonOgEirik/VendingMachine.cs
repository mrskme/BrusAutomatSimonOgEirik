using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    abstract class VendingMachine : Transactions
    {
        public abstract Soda ChooseSoda(Product.Types type);
        public abstract void getProductFromStorage();
        internal abstract void SpitOutProduct();
    }
}
