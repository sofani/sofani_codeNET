using System.Collections.Generic;
using PizzaStore.Library.Interfaces;

namespace PizzaStore.Library.Models.ToppingClasses
{

    class Bacon : Topping
    {
        
        public Bacon(IPizza pizza) : base(pizza) { }

        public override string Name
        {
            get
            {
                return base.Name + " with Bacon Topping";
            }
        }

        public override decimal Price
        {
            get
            {
                return base.Price + .85M;
            }
        }

    }
}