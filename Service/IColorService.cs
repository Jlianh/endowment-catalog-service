using CatalogWebApi.DTO;

namespace CatalogWebApi.Service
{
    public interface IColorService
    {
        Task<IEnumerable<ColorsDTO>> GetAllColorssAsync();
    }
}
