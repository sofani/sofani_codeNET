using System.Collections.Generic;
using PizzaStore.Library.Interfaces;

namespace PizzaStore.Library.Models.CrustClasses
{

     class Pan : Crust
    {
    
        public Pan(IPizza pizza) : base(pizza) { }

        public override string Name
        {
            get
            {
                return base.Name + " Pan ";
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