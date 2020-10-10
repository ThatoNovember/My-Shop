using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using OnlineWebStore.Core.Models;

namespace OnlineWebStore.DataAccess.InMemory
{
    public class ProductCategoryRepository
    {
        ObjectCache cache = MemoryCache.Default;
        List<ProductCategory> productCategories = new List<ProductCategory>();

        public ProductCategoryRepository()
        {
            productCategories = cache["productCategories"] as List<ProductCategory>;
            if (productCategories == null)
            {
                productCategories = new List<ProductCategory>();
            }
        }
        public void Commit()
        {
            cache["productsCategories"] = productCategories;
        }
        public void Insert(ProductCategory p)
        {
            productCategories.Add(p);
        }
        public void Update(ProductCategory productCategory)
        {
            ProductCategory productCategoryUpdate = productCategories.Find(p => p.Id == productCategory.Id);
            if (productCategoryUpdate != null)
            {
                productCategoryUpdate = productCategory;
            }
            else
            {
                throw new Exception("Product Category not found");

            }
        }
        public ProductCategory Find(string Id)
        {
            ProductCategory productCategory = productCategories.Find(p => p.Id == Id);
            if (productCategory != null)
            {
                return productCategory;
            }
            else
            {
                throw new Exception("Product Category not found");

            }
        }
        public IQueryable<ProductCategory> Collection()
        {
            return productCategories.AsQueryable();
        }
        public void Delete(string Id)
        {
            ProductCategory productCategoryDelete = productCategories.Find(p => p.Id == Id);
            if (productCategoryDelete != null)
            {
                productCategories.Remove(productCategoryDelete);
            }
            else
            {
                throw new Exception("Product Category not found");

            }
        }

    }
}
