using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapPizzaConsumer.Peater.Models
{
    public class RestPizzaPies
    {
        public long Id { get; set; } = DateTime.Now.Ticks;
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}