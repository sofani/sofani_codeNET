using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Models
{
   public  class Pizza
    {
        public string Name { get; set; }
        public List<Topping> Toppings { get; set; }
        public Crust Crust { get; set; }
        public Size Size { get; set; }
    }
}
