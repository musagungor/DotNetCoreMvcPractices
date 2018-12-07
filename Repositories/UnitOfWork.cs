using System.Threading.Tasks;

namespace DotNetCoreMvcPractices.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MvcPracticeDbContext context;

        public UnitOfWork(MvcPracticeDbContext context)
        {
            this.context = context;
        }
        public async Task ComplateAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}