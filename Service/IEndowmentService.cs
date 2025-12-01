using CatalogWebApi.DTO;

namespace CatalogWebApi.Service
{
    public interface IEndowmentService
    {
        Task<IEnumerable<EndowmentDTO>> GetAllEndowmentsAsync();
        Task<EndowmentDTO> GetEndowmentByIdAsync(int id);
        Task<IEnumerable<EndowmentDTO>> GetEndowmentByEndowmentTypeIdAsync(int id);
        Task<IEnumerable<EndowmentDTO>> GetEndowmentsByFiltersAsync(FiltersDTO filtersDTO);
        Task<IEnumerable<EndowmentDTO>> GetEndowmentByNameAsync(NameSeachDTO nameSeachDTO);
        Task<EndowmentDTO> CreateEndowmentAsync(SaveEndowmentDTO saveEndowmentDTO);
        Task<EndowmentDTO> UpdateEndowmentAsync(int id, SaveEndowmentDTO saveEndowmentDTO);
        Task DeleteEndowmentAsync(int id);


    }
}
