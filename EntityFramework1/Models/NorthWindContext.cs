using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityFramework1.Models
{
    public class NorthWindContext:DbContext
    {
        public NorthWindContext()
            :base("name =SchoolDBConnectionString")
        {

        }

        public DbSet<Category> CategoriesTable { get; set; }
        public DbSet<Product> ProductTable { get; set; }
    }

}