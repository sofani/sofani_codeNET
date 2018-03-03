using System;
using System.Collections.Generic;

namespace PizzaStore.Data.Model
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }
        public int? StoreLocationId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Stat { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Active { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
