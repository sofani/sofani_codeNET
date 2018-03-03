using Newtonsoft.Json;
using SoapPizza.Library;
using SoapPizzaConsumer.Peater.PizzaReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;


namespace SoapPizzaConsumer.Peater.Models
{
    public class PizzaModel
    {
        public List<PizzaReference.PizzaPie> Pies { get; set; }

        public List<RestPizzaPies> RestPies { get; private set; }

        public PizzaModel()
        {
            Pies = new List<PizzaReference.PizzaPie>();


        }

        public void ProjectReference()
        {
            var p = PizzaMaker.MakePizza("Pineapple");
        }

        public void ServiceReference()
        {
            var svc = new PizzaServiceClient();

            Pies = svc.OrderPizza("Pineapple",1).ToList();
        }

        public bool CreatePizza(string name)
        {
            var svc = new PizzaServiceClient();
            var count = Pies.Count;

            Pies.AddRange(svc.OrderPizza(name, 1).ToList());

            return Pies.Count > count;
        }

        public List<PizzaReference.PizzaPie> List()
        {
            return Pies;
        }

        public bool RestCreate(string name)
        {
            var svc = new HttpClient();

            //svc.DefaultRequestHeaders.Add("Content-Type", "application/json");
            var content = JsonConvert.SerializeObject(new { Name = name });

            var res = svc.PostAsync("http://localhost/restpizza/api/pizza",
                new StringContent(content, Encoding.UTF8, "application/json")).GetAwaiter().GetResult();

            return res.IsSuccessStatusCode;
        }

        public List<RestPizzaPies> RestList()
        {
            var svc = new HttpClient();
            var res = svc.GetAsync("http://localhost/restpizza/api/pizza").GetAwaiter().GetResult();

            if (res.IsSuccessStatusCode)
            {
                RestPies = JsonConvert.DeserializeObject<List<RestPizzaPies>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                return RestPies;
            }
            else
            {
                return RestPies;
            }

        }
    }
}