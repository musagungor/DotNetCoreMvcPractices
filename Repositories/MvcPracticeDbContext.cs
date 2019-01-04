using DotNetCoreMvcPractices.Models;
using DotNetCoreMvcPractices.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreMvcPractices.Repositories
{
    public class MvcPracticeDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,string>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }

        public MvcPracticeDbContext(DbContextOptions<MvcPracticeDbContext> options) : base(options)
        {

        }



    }
}