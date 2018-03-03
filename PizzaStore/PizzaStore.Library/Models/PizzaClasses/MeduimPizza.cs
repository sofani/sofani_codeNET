using System;
using PizzaStore.Library.Interfaces;

namespace PizzaStore.Library.Models.PizzaClasses
{

    public class MeduimPizza : IPizza
    {
     
        public string Name
        {
            get
            {
                return "Meduim pizza";
            }
        }
        public decimal Price
        {
            get
            {
                return 5.00M;
            }
        }

    }
}