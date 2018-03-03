using System;
using System.Collections.Generic;

namespace PizzaStore.Data.Model
{
    public partial class Topping
    {
        public Topping()
        {
            PizzaTopping = new HashSet<PizzaTopping>();
        }

        public int ToppingId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Active { get; set; }
        public decimal ToppingPrice { get; set; }

        public ICollection<PizzaTopping> PizzaTopping { get; set; }
    }
}
