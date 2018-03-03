using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapPizza.Library
{
    public class PizzaMaker
    {

        public static PizzaPie MakePizza(string name)
        {
            return new PizzaPie()
            {
                ID = DateTime.Now.Ticks,
                Name = name,
                Price = 9.99m
            };
        }
    }
}