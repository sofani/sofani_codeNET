using PizzaStore.Data;
using PizzaStore.Data.Model;
using Dac = PizzaStore.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PizzaStore.Library.Interfaces;
using PizzaStore.Library.Models.PizzaClasses;
using PizzaStore.Library.Enums;

namespace PizzaStore.Library.Models
{
    public class LibHelper
    {
        private static LibHelper _LH;
        private static AdventureContext _DB = new AdventureContext();
        private LibHelper() { }

        public static LibHelper Instance()
        {
            if (_LH == null)
            {
                _LH = new LibHelper();
            }

            return _LH;
        }
        

        public bool AddSize(Size s)
        {
            try
            {
                if (s == null)
                {
                    return false;
                }

                var ss = SizeToDataAccess(new List<Size>() { s }).FirstOrDefault();

                _DB.Size.Add(ss);
                _DB.SaveChanges();
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }

            return true;
        }

        public bool AddCrust(Crust s)
        {
            try
            {
                if (s == null)
                {
                    return false;
                }

                var ss = CrustToDataAccess(new List<Crust>() { s }).FirstOrDefault();

                _DB.Crust.Add(ss);
                _DB.SaveChanges();
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }

            return true;
        }

        private static List<Dac.Size> SizeToDataAccess(List<Size> libSize)
        {
            var ls = new List<Dac.Size>();

            foreach (var item in libSize)
            {
                ls.Add(new Dac.Size()
                {
                    Name = item.Name,
                    SizePrice = item.Price,
                    ModifiedDate = DateTime.Now,
                    Active = true

                });
            }

            return ls;
        }

        private static  List<Dac.Crust> CrustToDataAccess(List<Crust> libCrust)
        {
            var ls = new List<Dac.Crust>();

            foreach (var item in libCrust)
            {
                ls.Add(new Dac.Crust()
                {
                    Name = item.Name,
                    CrustPrice = item.Price,
                    ModifiedDate = DateTime.Now,
                    Active = true

                });
            }

            return ls;
        }



        private List<Size> SizeToLibrary(List<Dac.Size> ss)
        {
            var ls = new List<Size>();

            foreach (var item in ss)
            {
                ls.Add(new Size()
                {
                    Name = item.Name,
                    Price = item.SizePrice,
                    

                });
            }

            return ls;
        }


        public List<Size> GetSize(Size s = null)
        {
            if (s == null)
            {
                return SizeToLibrary(_DB.Size.ToList());
            }

            return SizeToLibrary(_DB.Size.ToList());
            
        }
    }
}
