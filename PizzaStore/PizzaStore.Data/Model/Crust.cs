using System;
using System.Collections.Generic;

namespace PizzaStore.Data.Model
{
    public partial class Crust
    {
        public Crust()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int CrustId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Active { get; set; }
        public decimal CrustPrice { get; set; }

        public ICollection<Pizza> Pizza { get; set; }
    }
}
