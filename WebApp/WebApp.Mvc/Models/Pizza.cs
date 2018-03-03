using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Mvc.Interface;

namespace WebApp.Mvc.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public List<Topping> Pizzas { get; set; }
        public Crust Crust { get; set; }
        public Size Size { get; set; }
    }
}