using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PizzaStore.Library.Interfaces;
using PizzaStore.Library;
using PizzaStore.Library.Enums;
using PizzaStore.Library.Models.CrustClasses;
using PizzaStore.Library.Models.PizzaClasses;
using PizzaStore.Library.Models.ToppingClasses;
using PizzaStore.Library.Models.OrderClasses;
namespace PizzaStore.Tests
{
    [TestClass]
    public class PizzaStoreXunitTest
    {
        [TestMethod]
        public void TestOrderPizza()
        {
            IPizza pizza1  = Pizza.OrderPizza(SizesEnum.MeduimSize); 
            pizza1 =  Pizza.AddCrust(pizza1, CrustsEnums.Thin);
            pizza1 =  Pizza.AddTopping(pizza1, ToppingsEnums.Bacon);
            Assert.AreEqual(Pizza.Totalprice(pizza1), 7.85M);
        }
        

            [TestMethod]
        public void TestpizzaCreatedByName()
        {
            IPizza pizza1  = Pizza.OrderPizza(SizesEnum.MeduimSize);
             
            pizza1 =  Pizza.AddCrust(pizza1, CrustsEnums.Thin);
            pizza1 =  Pizza.AddTopping(pizza1, ToppingsEnums.Bacon);
            
            
            
            Assert.AreEqual(Pizza.pizzaCreatedByName(pizza1), "Meduim pizza Thin with Bacon Topping");
        }
        
        [TestMethod]
         public void TestAddPizza() 
         {
              Orders OrderTest = new Orders();
              IPizza pizza1  = Pizza.OrderPizza(SizesEnum.MeduimSize);  
                               pizza1 =  Pizza.AddCrust(pizza1, CrustsEnums.Thin);
                               pizza1 =  Pizza.AddTopping(pizza1, ToppingsEnums.Bacon);
             IPizza pizza2  = Pizza.OrderPizza(SizesEnum.MeduimSize);  

              OrderTest.AddPizza(pizza1);
              OrderTest.AddPizza(pizza2);

              Assert.IsTrue(OrderTest.getPizzasInOrder().Count == 2);
        }

           [TestMethod]
          public void TestTotalPricePizza() 
          {
              Orders OrderTest = new Orders();
              IPizza pizza1  = Pizza.OrderPizza(SizesEnum.MeduimSize);  
                               pizza1 =  Pizza.AddCrust(pizza1, CrustsEnums.Thin);
                               pizza1 =  Pizza.AddTopping(pizza1, ToppingsEnums.Bacon);
             IPizza pizza2  = Pizza.OrderPizza(SizesEnum.MeduimSize);  

              OrderTest.AddPizza(pizza1);
              OrderTest.AddPizza(pizza2);
              
              Assert.AreEqual(OrderTest.getTotalPriceOrder(),  12.85M);
          }
           [TestMethod]
          public void TestRemovePizza() 
          {
              Orders OrderTest = new Orders();
              IPizza pizza1  = Pizza.OrderPizza(SizesEnum.MeduimSize);  
                               pizza1 =  Pizza.AddCrust(pizza1, CrustsEnums.Thin);
                               pizza1 =  Pizza.AddTopping(pizza1, ToppingsEnums.Bacon);
             IPizza pizza2  = Pizza.OrderPizza(SizesEnum.MeduimSize);  

              OrderTest.AddPizza(pizza1);
              OrderTest.AddPizza(pizza2);
              OrderTest.RemovePizza(pizza1);
              Assert.AreEqual(OrderTest.getTotalPriceOrder(),  5.00M);
        
         }
    }
}