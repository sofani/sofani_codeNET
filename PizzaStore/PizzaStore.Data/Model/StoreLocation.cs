using System;
using System.Collections.Generic;

namespace PizzaStore.Data.Model
{
    public partial class StoreLocation
    {
        public StoreLocation()
        {
            Orders = new HashSet<Orders>();
        }

        public int StoreLocationId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Active { get; set; }
        public string LocationAddress { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
