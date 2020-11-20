using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Rheal_MVP_App.Models
{
    public class RHealDbContext: DbContext
    {

        //constructor that will read the connection
        public RHealDbContext():base("name=RhealDBConnection")
        {
            
        }

        //defining properties DbSet<T> for Categories and Products
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}