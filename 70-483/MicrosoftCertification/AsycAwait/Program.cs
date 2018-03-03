using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
namespace AsycAwait
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //var dir = System.IO.Directory.GetCurrentDirectory();
            // var file = System.IO.Path.Combine(dir, "file.txt");

            // var content = "Hi how are you";

            //write
            // System.IO.File.WriteAllText(file, content);

            //read
            // var read = System.IO.File.ReadAllText(file);
            //Trace.Assert(read.Equals(content))

            //Reflection r = new Reflection();
            // r.Property();


            // var data = Enumerable.Range(1, 50);
            /* var method = data.Where(x => x % 2 == 0).Select(x => x.ToString());
             var projection = from d in data
                         select new
                         {
                             Even = (d % 2 == 0),
                             odd = !(d % 2 == 0),
                             value = d,

                         };

             Debugger.Break();*/

            int x = 10;
            int y = 2;

            double result = 0;

            result = x + y;
            result = x * y;


            printNumbers(result);


            Console.ReadLine();
        }

        static void printNumbers(double res)
        {
            for (int i = 0; i < res; i++)
            {
                Console.WriteLine("{0}\t",  i);
            }
        }
      


    }
}
