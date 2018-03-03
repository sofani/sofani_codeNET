

using System.Collections.Generic;
using PizzaStore.Library.Enums;
using PizzaStore.Library.Interfaces;
using PizzaStore.Library.Models.CrustClasses;
using PizzaStore.Library.Models.PizzaClasses;
using PizzaStore.Library.Models.ToppingClasses;

namespace PizzaStore.Library.Models.PizzaClasses

 {
         public static class Pizza {
      //  public  static string Name{get; set;}
        // SizeObject Size{get; set;}
        // List<Topping> ListTopping{get; set;}

        // Crust Crust{get;set;}

       // public static decimal Price {get; set;}


       

        public static IPizza OrderPizza(SizesEnum size) {
         
            switch (size) {
                case SizesEnum.SmallSize:
                   return new SmallPizza();
                case SizesEnum.MeduimSize:
                  return new MeduimPizza();
                case SizesEnum.LargeSize:
                  return new LargePizza();
                default:
                    return null;
            }

        }

        public static IPizza AddTopping(IPizza pizza, ToppingsEnums topping) {
             switch (topping) {
                case ToppingsEnums.Pepperoni:
                    return new Pepporeni(pizza);
                case ToppingsEnums.Ham:
                    return new Ham(pizza);
                case ToppingsEnums.Bacon:
                    return new Bacon(pizza);
                default:
                    return pizza;

            }

        }

        public static IPizza AddCrust(IPizza pizza, CrustsEnums crusts)
        {
            switch (crusts)
            {
                case CrustsEnums.HandTossed:
                    return new HandTossed(pizza);
                case CrustsEnums.Pan:
                    return new Pan(pizza);
                case CrustsEnums.Thin:
                    return new Thin(pizza);
                default:
                    return pizza;

            }

        }
        
        public static decimal Totalprice(IPizza pizza) {
                return pizza.Price;
        }

        public static string pizzaCreatedByName(IPizza pizza)
        {
            return pizza.Name;
        }

}


}
