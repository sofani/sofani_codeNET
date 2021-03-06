using System.Collections.Generic;
using PizzaStore.Library.Interfaces;

namespace PizzaStore.Library.Models.CrustClasses
{

     class HandTossed : Crust
    {
   
         public HandTossed(IPizza pizza) : base(pizza) { }
      
        public override string Name
        {
            get
            {
                return base.Name + " Hand ";
            }
        }
        public override decimal Price
        {
            get
            {
                return base.Price + 2.00M;
            }
        }

    }
}