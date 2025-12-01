using CatalogWebApi.DTO;

namespace CatalogWebApi.Service
{
    public interface ISizeService
    {
        Task<IEnumerable<SizesDTO>> GetAllSizesAsync();
    }
}
