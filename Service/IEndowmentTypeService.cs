using CatalogWebApi.DTO;

namespace CatalogWebApi.Service
{
    public interface IEndowmentTypeService
    {
        Task<IEnumerable<EndowmentTypeDTO>> GetAllEndowmentsTypesAsync();
    }
}
