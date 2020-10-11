using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineWebStore.Core.Models;
using System.Threading.Tasks;

namespace OnlineWebStore.Core.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}
