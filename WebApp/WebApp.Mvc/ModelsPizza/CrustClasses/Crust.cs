using System.Collections.Generic;
using PizzaStore.Library.Interfaces;

namespace PizzaStore.Library.Models.CrustClasses
{
   
      abstract class Crust : IPizza
        {
           
            private IPizza pizza;
            
            public Crust(IPizza pizza)
            {
                this.pizza = pizza;
            }

            public virtual string Name
            {
                get
                {
                    return pizza.Name;
                }
            }
            //it is virtual there is a posibility to be overriden
            public virtual decimal Price
            {
                get
                {
                    return pizza.Price;
                }
            }
        }
    }


