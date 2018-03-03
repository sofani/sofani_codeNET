using System;
using PizzaStore.Library.Interfaces;

namespace PizzaStore.Library.Models.PizzaClasses {

    public class LargePizza : IPizza
    {
     
        public string Name {
            get
            {
                return "Large pizza";
            }
        }
        public decimal Price {
            get
            {
                return 6.00M; 
            }
        }

    }
}