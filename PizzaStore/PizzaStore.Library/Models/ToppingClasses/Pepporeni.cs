using System.Collections.Generic;
using PizzaStore.Library.Interfaces;

namespace PizzaStore.Library.Models.ToppingClasses {

    class Pepporeni : Topping {
       
       public Pepporeni(IPizza pizza) : base(pizza) { }
       
       public override string Name
        {
            get
            {
                return base.Name + " with pepporeni Topping";
            }
        }

        public override decimal Price
        {
            get
            {
                return base.Price + .75M;
            }
        }

    }
}