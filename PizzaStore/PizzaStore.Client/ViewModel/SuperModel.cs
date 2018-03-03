using PizzaStore.Client.Models;
using Lib = PizzaStore.Library.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaStore.Client.Interface;

namespace PizzaStore.Client.ViewModel
{
    public class SuperModel
    {
        private Lib.LibHelper _LH = Lib.LibHelper.Instance();
        //Adding a user to data base

        public void AddPizza(Pizza pizza)
        {
           // _LH.AddPizza(PizzaToLibrary(new List<Pizza>() { pizza }).FirstOrDefault());
        }

        private List<Lib.Pizza> PizzaToLibrary(List<Pizza> p)
        {
            var ls = new List<Lib.Pizza>();
            foreach (var item in p)
            {
                ls.Add(new Lib.Pizza()
                {
                    Name = item.Name,
                   // Crust = item.Crust,
                  
                    //Size = item.Size,

                });
            }
            return ls;
        }





        public void AddSize(Size size)
        {
            _LH.AddSize(SizeToLibrary(new List<Size>() { size }).FirstOrDefault());

        }

        public void AddCrust(Crust crust)
        {
            _LH.AddCrust(CrustToLibrary(new List<Crust>() { crust }).FirstOrDefault());

        }

        private List<Lib.Size> SizeToLibrary(List<Size> s)
        {
            var ls = new List<Lib.Size>();
            foreach (var item in s)
            {
                ls.Add(new Lib.Size()
                {
                    Name = item.Name,
                    Price = item.Price
                });
            }
            return ls;
        }

        private List<Lib.Crust> CrustToLibrary(List<Crust> c)
        {
            var ls = new List<Lib.Crust>();
            foreach (var item in c)
            {
                ls.Add(new Lib.Crust()
                {
                    Name = item.Name,
                    Price = item.Price
                });
            }
            return ls;
        }




        public List<Size> GetSizes()
        {
            return SizeToClient(_LH.GetSize());
        }

        public List<Size> SizeToClient(List<Lib.Size> ss)
        {
            var ls = new List<Size>();
            foreach(var item in ss)
            {
                ls.Add(new Size() {

                    Name = item.Name,
                    Price = item.Price
                   
                });


            }

            return ls;

        }
    }
}
