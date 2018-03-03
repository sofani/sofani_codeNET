using System;
using PizzaStore.Library.Interfaces;

namespace PizzaStore.Library.Models.PizzaClasses
{

    public class SmallPizza : IPizza
    {
       
        public string Name
        {
            get
            {
                return "Small pizza";
            }
        }
        public decimal Price
        {
            get
            {
                return 4.00M;
            }
        }

    }
}