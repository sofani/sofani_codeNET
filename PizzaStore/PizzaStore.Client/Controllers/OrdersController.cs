using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Client.ViewModel;

namespace PizzaStore.Client.Controllers
{
    public class OrdersController : Controller
    {
        private static SuperModel s = new SuperModel();
        public IActionResult Index()
        {
            return View();
        }
    }
}