using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreMvcPractices.Models;

namespace DotNetCoreMvcPractices.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetAsync(int id);
        Task<List<Product>> GetAllAsync();
        Task<List<Product>> FindAsync(Func<Product, bool> predicate);
        Task AddAsync(Product product);
        void Remove(Product product);
    }
}