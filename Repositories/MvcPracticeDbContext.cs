using DotNetCoreMvcPractices.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreMvcPractices.Repositories
{
    public class MvcPracticeDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public MvcPracticeDbContext(DbContextOptions<MvcPracticeDbContext> options) : base(options)
        {

        }



    }
}