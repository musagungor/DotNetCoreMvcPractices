using System.Threading.Tasks;

namespace DotNetCoreMvcPractices.Repositories
{
    public interface IUnitOfWork
    {
      Task ComplateAsync ();
    }
}