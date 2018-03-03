using System;
using System.Collections.Generic;
using PizzaStore.Library.Interfaces;

namespace PizzaStore.Library.Models.OrderClasses { 
     public  class Orders {
        int OrderId{get;set;}
        List<IPizza> ListOfPizza{ get; set; }
       
        DateTime  DateOrder{get;set;}
        StoreLocation StoreLocation{get;set;}

       
        decimal TotalOrderPrice{get;set;}
        bool Status {get; set;}
        Customer Customer{get; set;}

        public Orders() {
            ListOfPizza  = new List<IPizza>();
           TotalOrderPrice = 0.0M;
        }

        public List<IPizza> getPizzasInOrder()
        {
            return ListOfPizza;
        }

        public decimal getTotalPriceOrder()
        {
            return TotalOrderPrice;
        }
        public void AddPizza(IPizza AddPizza) {
           
            if (ListOfPizza.Count < 12.00M || (TotalOrderPrice + AddPizza.Price) > 500.00M) {
                ListOfPizza.Add(AddPizza);
                TotalOrderPrice += AddPizza.Price;
            } else {
                Console.Error.WriteLine("12 pizzas ONLY, and $500. maximum");
            }
        }
        public void RemovePizza(IPizza RemovePizza) {
            ListOfPizza.Remove(RemovePizza);
            TotalOrderPrice -= RemovePizza.Price;
        }
    }
}
