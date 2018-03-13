using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.EFData
{
    /*
     * Scaffold-DbContext -Connection "server=nicholassqlweek.database.windows.net;database=nicholassqlweek;user=sqladmin;password=Password123" -Provider "Microsoft.EntityFrameworkCore.SqlServer" -Project "AdventureWorks.EFData"
     */

    public class EFHelper
    {
        private nicholassqlweekContext db = new nicholassqlweekContext();

        public void GetCustomers()
        {
            foreach (var item in db.Customer.ToList())
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }

        public void GetCustomers2()
        {
            var query = from c in db.Customer
                        select new { c.LastName, c.FirstName };

            db.Address.Add(new Address
            {
                AddressLine1 = "11730 plaza america dr",
                City = "reston",
                CountryRegion = "usa",
                PostalCode = "20190",
                StateProvince = "virginia"
            });

            db.SaveChanges();

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.AddressLine1)
            //}
        }
    }
}
