using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Client.Models;

namespace PizzaStore.Client.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var sizes = new List<Size> {
              new Size { Name = "SmallSize", Price = 5.00M},
              new Size { Name = "MeduimSize", Price = 6.00M},
              new Size { Name = "LargeSize", Price = 7.00M}
            };

            var topping = new List<Topping> {
              new Topping { Name = "Bacon", Price = 2.00M},
              new Topping { Name = "Ham", Price = 2.00M},
              new Topping { Name = "Pepporeni", Price = 2.00M}
           };

            var crust = new List<Crust> {
              new Crust { Name = "HandTossed", Price = 2.00M},
              new Crust { Name = "Pan", Price = 2.00M},
              new Crust { Name = "Thin", Price = 2.00M}
           };

          
            return View(sizes);
           
        }

       
      
    }
}
