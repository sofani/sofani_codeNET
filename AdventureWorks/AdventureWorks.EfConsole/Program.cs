using AdventureWorks.EFData;
using System;

namespace AdventureWorks.EFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var ef = new EFHelper();
            ef.GetCustomers2();
        }
    }
}
