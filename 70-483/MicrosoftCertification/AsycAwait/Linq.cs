using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsycAwait
{
   public  class Linq
    {
        static void linqMethods() {
             var data = Enumerable.Range(1, 50);
             var method = data.Where(x => x % 2 == 0).Select(x => x.ToString());
             var projection = from d in data
                         select new
                         {
                             Even = (d % 2 == 0),
                             odd = !(d % 2 == 0),
                             value = d,

                         };

        }
    }
}