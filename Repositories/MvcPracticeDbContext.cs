using DotNetCoreMvcPractices.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreMvcPractices.Repositories
{
    public class MvcPracticeDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
         public MvcPracticeDbContext(DbContextOptions<MvcPracticeDbContext> options) : base(options)
        {

        }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     // optionsBuilder.UseSqlite("Data Source=vega.db");
        //     var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "MvcPracticeDb.db" };
        //     var connectionString = connectionStringBuilder.ToString();
        //     var connection = new SqliteConnection(connectionString);

        //     optionsBuilder.UseSqlite(connection);
        // }

       
    }
}