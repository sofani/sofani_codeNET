using System.Collections.Generic;
using PizzaStore.Library.Interfaces;

namespace PizzaStore.Library.Models.ToppingClasses {

    abstract class Topping : IPizza {
       
        // int Price { get; set; }
        // Toppings NameTopping { get; set; }

        // int Amount { get; set; }
        int ToppingId{get;set;}
        private IPizza pizza;
        public Topping(IPizza pizza)
        {
          this.pizza = pizza;
        }

       public virtual string Name {
           get {
               return pizza.Name;
           }
       }
       //it is virtual there is a posibility to be overriden
       public virtual decimal Price {
           get {
               return pizza.Price;
           }
       }
    }
}