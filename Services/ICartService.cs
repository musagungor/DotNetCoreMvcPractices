using System.Threading.Tasks;
using DotNetCoreMvcPractices.Models;

namespace DotNetCoreMvcPractices.Services
{
    public interface ICartService
    {
        Task Add(int id);
        Cart GetCart();
        Task Remove(int id);
    }
}