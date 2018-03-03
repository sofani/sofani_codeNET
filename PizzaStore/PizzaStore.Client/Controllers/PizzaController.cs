using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Client.Models;
using PizzaStore.Client.ViewModel;

namespace PizzaStore.Client.Controllers
{
    public class PizzaController : Controller
    {
        private static SuperModel _SM = new SuperModel();
        public ActionResult Index() { 

            return View(_SM.GetSizes());
        }
        //
        // GET: /Store/Browse
        public ActionResult Create()
        { 
            return View(new Size());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Size s)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new ArgumentException("");
                }

                _SM.AddSize(s);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult CreateCrust()
        {
            return View(new Crust());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCrust(Crust s)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new ArgumentException(" ");
                }

                _SM.AddCrust(s);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            return View();

        }

        public ActionResult SignUp()
        { 
            return View();
        }
        public ActionResult LogIn()
        {
            return View();
        }
        public ActionResult AddCart()
        {

            ViewBag.MyString = "$7.85M Bacon small Pizza with Handtossed";
            return View();
        }
        public ActionResult AddCart1()
        {

            ViewBag.MyString1 = "$8.85 Meduim pizza Thin with Bacon Topping";
            return View();
        }
        public ActionResult AddCart2()
        {

            ViewBag.MyString2 = "$11.00 cheese Large Pizza with Pan";
            return View();
        }
    }
}