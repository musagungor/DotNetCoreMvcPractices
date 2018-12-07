using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreMvcPractices.Models;

namespace DotNetCoreMvcPractices.Repositories
{
    public interface IBrandRepository
    {
        Task<List<Brand>> GetAllAsync();
    }
}