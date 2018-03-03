using System.Collections.Generic;
using PizzaStore.Library.Models.OrderClasses;
using PizzaStore.Library.Models.ToppingClasses;

namespace PizzaStore.Library.Models {

    public class StoreLocation {
        int StoreLocationId{get;set;}
        string LocationName{get; set;}
        string Address { get; set; }
        List<Orders> OrderHistory{get; set;}

        Customer CustomerAddress{get;set;}
 
         Dictionary<string, int> Inventory{get;set;}

        // List<Orders> Sales{get;set;}

        // List<Orders> ListOpenOrders{get;set;}
       public StoreLocation() {


          LocationName = "Oakland pizza House";
          Address  = "744 26th street";
        
          OrderHistory  = new List<Orders>();
          CustomerAddress = new Customer();
          Inventory = new Dictionary<string, int>();
       }

       public string OrderSuggestion() {
          
            return CustomerAddress.getAddressHTMLFormat() + OrderHistory[0].ToString();
       }

      public void AddInventory(string items, int quantity) {
          Inventory.Add(items, quantity);
      }
      


    }

}