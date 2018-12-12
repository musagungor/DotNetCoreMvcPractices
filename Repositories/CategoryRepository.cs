using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreMvcPractices.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreMvcPractices.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MvcPracticeDbContext _context;

        public CategoryRepository(MvcPracticeDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            var categories = await _context.Categories
                .Include(m => m.ChildCategories)
                .Include(c=>c.Products).ToListAsync();
            return categories;
        }

    }
}
