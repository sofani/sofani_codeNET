using System.Collections.Generic;
using PizzaStore.Library.Interfaces;

namespace PizzaStore.Library.Models.ToppingClasses
{

    class Ham : Topping
    {
      
        public Ham(IPizza pizza) : base(pizza) { }

        public override string Name
        {
            get
            {
                return base.Name + " with Ham Topping";
            }
        }

        public override decimal Price
        {
            get
            {
                return base.Price + .65M;
            }
        }

    }
}