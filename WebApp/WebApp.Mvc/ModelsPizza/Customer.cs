using System;
using System.Collections.Generic;
using PizzaStore.Library;
using PizzaStore.Library.Interfaces;
using PizzaStore.Library.Models.OrderClasses;

namespace PizzaStore.Library.Models { 
    public class Customer {
     int customerId{get;set;}
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string CompanyName{get; set;}
        string Address1{ get; set; }
        string Address2{ get; set; }
        string City{ get; set; }
        string Stat{ get; set; }
        string Zip{ get; set; }
        string Country{ get; set; }
        List<Orders> NewOrder { get; set; }
        List<IPizza> HistoryOrderPizza { get; set; }
        StoreLocation DefaultLocation{get;set;}
       
        
         public Customer()
        {
        
            FirstName = "sofani";
            LastName = "mesfun";
            Email = "sofanib@gmail.com";
            CompanyName = "Revature";
            Address1 = "2500 american plaza";
            Address2 = "";
            City = "reston";
            Stat = "va";
            Zip = "20000";
            Country = "u.s.a";
            NewOrder  = new List<Orders>();
            DefaultLocation = new StoreLocation();
            HistoryOrderPizza = new List<IPizza>();
        }

        public string getAddressHTMLFormat()
        {
            string Address = FirstName + " " + LastName + "<br>";

            if (CompanyName == null || CompanyName.Equals("") || CompanyName.Equals(" "))
                Address += "";
            else
                Address += CompanyName + "<br>";
                Address += Address1 + "<br>";

            if (Address2 == null || Address2.Equals("") || Address2.Equals(" "))
                Address += "";
            else
                Address += Address2 + "<br>";

            Address += City + ", " + Stat + " " + Zip + "<br>"
                    + Country;

            return Address;
        }
        public bool AddingCustomerOrder(Orders order) {
            if (NewOrder.Count <= 3) {
                NewOrder.Add(order);
                return true;
            } 
          

            return false;
            
        }
        public void  AddingCustomerHistoryPizza(IPizza pizza)
        {
                HistoryOrderPizza.Add(pizza); 

        }



         

      
    }
}