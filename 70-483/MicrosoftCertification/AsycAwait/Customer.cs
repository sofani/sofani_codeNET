using System;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using System.Linq;


namespace AsycAwait
{
         public class Derived : Customer
        {
        
        }
        public  class  Customer {

        public override string ToString() {
            return "Base";
        }
        public static decimal calculateInterest(decimal loanAmount, int loanterm, decimal loanRate) {
                // Trace.Assert method if you want to do assertions in release builds. 
            //By default, the Debug.Assert method works only in debug builds.
                Debug.Assert(loanAmount > 0);
                decimal interestAmount = loanAmount * loanRate * loanterm;      
                return interestAmount;
        }

        //SortedList<TKey, TValue> - Represents a collection of key/value pairs 
        //that are sorted by key based on the associated IComparer<T> implementation

            public  void  sortedListMethod() {
    // Create a new sorted list of strings, with string
            // keys.
                    SortedList<string, string> openWith = new SortedList<string, string>();

                    // Add some elements to the list. There are no 
                    // duplicate keys, but some of the values are duplicates.
                    openWith.Add("txt", "notepad.exe");
                    openWith.Add("bmp", "paint.exe");
                    openWith.Add("dib", "paint.exe");
                    openWith.Add("rtf", "wordpad.exe");

                    // The Add method throws an exception if the new key is 
                    // already in the list.
                    try
                    {
                        openWith.Add("txt", "winword.exe");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("An element with Key = \"txt\" already exists.");
                    }
                }

                
        }
    
      
      
}
