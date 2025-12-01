using CatalogWebApi.Models;

namespace CatalogWebApi.Repository
{
    public interface IEndowmentTypeRepository
    {
        Task<IEnumerable<EndowmentType>> GetAllAsync();
    }
}
