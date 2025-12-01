using CatalogWebApi.Models;

namespace CatalogWebApi.Repository
{
    public interface IColorsRepository
    {
        Task<IEnumerable<Color>> GetAllAsync();
    }
}
