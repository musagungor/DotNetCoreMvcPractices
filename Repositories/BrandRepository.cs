using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreMvcPractices.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreMvcPractices.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly MvcPracticeDbContext context;

        public BrandRepository(MvcPracticeDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Brand>> GetAllAsync()
        {
            var brands = await context.Brands.ToListAsync();
            return brands;
        }
    }
}