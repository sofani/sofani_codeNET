using Microsoft.EntityFrameworkCore;
using PizzaStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Data
{
    public  class PizzaStoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=sofanisqlweek.database.windows.net;database=sofanisqlweek;user=sofa;password=Sami114173;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pizza>().HasKey("PizzaId");
        }

        public DbSet<Pizza> Pizzas { get; set; }
    }
}
