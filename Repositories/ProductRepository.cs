using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DotNetCoreMvcPractices.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace DotNetCoreMvcPractices.Repositories
{

    public class ProductRepository : IProductRepository
    {
      
        private readonly MvcPracticeDbContext context;

        public ProductRepository(MvcPracticeDbContext context)
        {
            this.context = context;
        }

        public async Task<Product> GetAsync(int id)
        {

            var product = await context.Products
                        .Include(m => m.Brand)
                .Include(p=>p.Category).SingleOrDefaultAsync(p => p.Id == id);
            return product;
        }
        public async Task<List<Product>> GetAllAsync()
        {
            var products = await context.Products
                .Include(m => m.Brand)
                .Include(p=>p.Category).ToListAsync();
            return products;
        }

        public async Task<List<Product>> FindAsync(Func<Product, bool> predicate)
        {
            var filtered = await context.Products.Include(p=>p.Category).Where(predicate).ToAsyncEnumerable().ToList();
            return filtered;
        }
        public async Task AddAsync(Product product)
        {
            await context.Products.AddAsync(product);
        }
        public void Remove(Product product)
        {
            context.Products.Remove(product);

        }
    }
}