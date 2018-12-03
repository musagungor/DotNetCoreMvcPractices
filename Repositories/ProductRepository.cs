using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DotNetCoreMvcPractices.Models;

namespace DotNetCoreMvcPractices.Repositories
{

    public class ProductRepository : IProductRepository
    {
        public static List<Product> Products = new List<Product>();
       

        public Product Get(int id)
        {
            var product = Products.SingleOrDefault(p => p.Id == id);
            return product;
        }
        public List<Product> GetAll()
        {
            return Products;
        }

        public List<Product> Find(Func<Product, bool> predicate)
        {
            var filtered = Products.ToList().Where(predicate).ToList();
            return filtered;
        }
        public void Add(Product product)
        {
            Products.Add(product);
        }
        public void Remove(Product product)
        {
            Products.Remove(product);

        }
    }
}