using System;
using System.Collections.Generic;

namespace PizzaStore.Data.Model
{
    public partial class Orders
    {
        public Orders()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int OrderId { get; set; }
        public int? StoreLocationId { get; set; }
        public int? CustomerId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Active { get; set; }

        public Customer Customer { get; set; }
        public StoreLocation StoreLocation { get; set; }
        public ICollection<Pizza> Pizza { get; set; }
    }
}
