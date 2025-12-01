using CatalogWebApi.Models;

namespace CatalogWebApi.Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
    }
}
