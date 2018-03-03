using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PizzaStore.Client.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {

            var client = new HttpClient();
            return View();
        }
    }
}