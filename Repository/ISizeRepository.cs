using CatalogWebApi.Models;

namespace CatalogWebApi.Repository
{
    public interface ISizeRepository
    {
        Task<IEnumerable<Size>> GetAllAsync();
    }
}
