using System;
using System.Collections.Generic;
using DotNetCoreMvcPractices.Models;

namespace DotNetCoreMvcPractices.Repositories
{
    public interface IProductRepository
    {
        Product Get(int id);
        List<Product> GetAll();
        List<Product> Find(Func<Product, bool> predicate);
        void Add(Product product);
        void Remove(Product product);
    }
}