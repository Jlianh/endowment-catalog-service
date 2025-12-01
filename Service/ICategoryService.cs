using CatalogWebApi.DTO;

namespace CatalogWebApi.Service
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync();
    }
}
