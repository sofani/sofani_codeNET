using System;
using System.Collections.Generic;

namespace PizzaStore.Data.Model
{
    public partial class Pizza
    {
        public Pizza()
        {
            PizzaTopping = new HashSet<PizzaTopping>();
        }

        public int PizzaId { get; set; }
        public int? CrustId { get; set; }
        public int? SizeId { get; set; }
        public int? OrderId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Active { get; set; }

        public Crust Crust { get; set; }
        public Orders Order { get; set; }
        public Size Size { get; set; }
        public ICollection<PizzaTopping> PizzaTopping { get; set; }
        public decimal Price { get; set; }
    }
}
