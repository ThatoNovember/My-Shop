using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OnlineWebStore.Core.Models;

namespace OnlineWebStore.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }
        public DbSet<Product>Pproducts { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
