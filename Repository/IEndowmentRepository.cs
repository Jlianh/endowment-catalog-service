using CatalogWebApi.DTO;
using CatalogWebApi.Models;

namespace CatalogWebApi.Repository
{
    public interface IEndowmentRepository
    {
        Task<IEnumerable<Endowment>> GetAllAsync();
        Task<Endowment> GetByIdAsync(int id);
        Task<IEnumerable<Endowment>> GetByEndowmentTypeIdAsync(int id);
        Task<IEnumerable<Endowment>> GetFilteredAsync(FiltersDTO filtersDTO);
        Task<IEnumerable<Endowment>> GetEndowmentsByNameAsync(NameSeachDTO nameSearchDTO);
        Task AddAsync(Endowment endowment);
        Task UpdateAsync(Endowment endowment);
        Task DeleteAsync(int id);




    }
}
