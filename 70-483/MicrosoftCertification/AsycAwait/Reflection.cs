using System;
using System.Collections.Generic;
using System.Text;

namespace AsycAwait
{
   public  class Reflection
    {
        public string Name { get; set; }
        public void Property()
        {
            var horse = new Reflection() { Name = "horse" };
            var type = horse.GetType();
            var property = type.GetProperty("Name");
            var value = property.GetValue(horse, null);
            Console.WriteLine(value);
        }
    }
   
}
