using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreMvcPractices.Models;

namespace DotNetCoreMvcPractices.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllAsync();
    }
}