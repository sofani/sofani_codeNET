using SoapPizza.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SoapPizza.Service
{
    [ServiceContract]
    public interface IPizzaService
    {
        [OperationContract]
        List<PizzaPie> OrderPizza(string name, int quantity);

        [OperationContract(Action = "OrderPizzaNew")]
        List<PizzaPie> OrderPizza(string name, int quantity, decimal price);

        //bool PayPizza(decimal payment);
    }
}
