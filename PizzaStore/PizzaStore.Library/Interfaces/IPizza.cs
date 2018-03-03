using System;
using System.Collections.Generic;
using PizzaStore.Data.Model;

namespace PizzaStore.Library.Interfaces {
    public interface IPizza {
       
        string Name { get; }

        decimal Price { get; }
       
    }
}