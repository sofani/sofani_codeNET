using System;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using System.Linq;


namespace AsycAwait
{
    class Program
    {
      
        static void Main(string[] args)
        {
              Customer  s  = new Customer();
              bool bValidInteger  = false;
              int value  = 0;
              do {
                  Console.WriteLine("Enter an Integer");
                  bValidInteger = GetValidInteger(ref value);

              } while (!bValidInteger);
               Console.WriteLine("You entered a valid Integer " + value);
            // Derived d = new Derived();
            // Customer c = d as Customer;
            // if (c != null) {
            //       Console.WriteLine(c.ToString());
            // }
             // Provide the query string with a parameter placeholder.
            //  calculate(2.45f);
         
              //s.sortedListMethod();
          
             Console.ReadLine();
        

        }
        public static bool GetValidInteger(ref int val) {
                    string sLine = Console.ReadLine();
                    int number ;
                    if ((!int.TryParse(sLine, out number))) {
                        return false;
                    } else {
                        val = number;
                        return true;
                    }
            }
        public static void calculate(float amount) {
            object amountRef  = amount;
            int balance = (int) (float) amountRef;
            Console.WriteLine(balance);
        }
        

   
        static void overFlowExce() {
            //The exception that is thrown when an arithmetic, casting, or conversion operation in a checked context results in an overflow.
            int value = 7800000;
             checked {
                try {
                   int square  = value * value;
                   Console.WriteLine("{0} ^ {1} ", value, square);


                } catch (OverflowException) {
                    double square = Math.Pow(value, 2);
                    Console.WriteLine("Exception: {0} > {1:E}.", square, Int32.MaxValue);

                }
            }
            
        }

        public static string displayTemprature() {
           double temp = 24.6899;
         
           string s = String.Format("It is now {0:d} at {0:t} {1:C2} {2:mm/dd/yy}", DateTime.Now, temp, DateTime.Today);
           return s;
        }
        
        public static void queExample() {
            Queue q = new Queue();
            q.Enqueue("sofani");
            q.Enqueue("sofani1");
            q.Enqueue("sofani2");
            q.Enqueue("sofani3");
            Queue mySyncdQ = Queue.Synchronized(q);
             Console.WriteLine( "myQ is {0}.", mySyncdQ.IsSynchronized ? "synchronized" : "not synchronized" );
             Console.WriteLine( "\tCount:    {0}", q.Count );
             Console.Write( "\tValues:" );
           // print(q);
              
        }
        public static void print(IEnumerable myCollection) {
            foreach(Object obj  in myCollection) {
                Console.Write("     {0}", obj);
                Console.WriteLine();
            }
        }

     

    }
}
