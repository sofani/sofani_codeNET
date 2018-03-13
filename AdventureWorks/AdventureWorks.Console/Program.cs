using AdventureWorks.AdoData;

namespace AdventureWorks.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var ador = new AdoReader();
            var adoa = new AdoAdapter();

            //ador.GetCustomers();
            adoa.GetCustomers();
        }
    }
}
