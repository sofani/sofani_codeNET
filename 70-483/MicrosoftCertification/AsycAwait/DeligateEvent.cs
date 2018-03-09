using System;
using System.Collections.Generic;


using System.Text;

namespace AsycAwait
{
   public  class DeligateEvent {

        delegate int del(int i);  
        static void delFunc() {
            del myDelegate = x => x * x;  
            int j = myDelegate(5); //j = 25  
        }
   }
}
