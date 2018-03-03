using System;
using System.Collections.Generic;

namespace PizzaStore.Data.Model
{
    public partial class Size
    {
        public Size()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int SizeId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Active { get; set; }
        public decimal SizePrice { get; set; }

        public ICollection<Pizza> Pizza { get; set; }
    }
}
