using CatalogWebApi.Data;
using CatalogWebApi.DTO;
using CatalogWebApi.Helper;
using CatalogWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogWebApi.Repository.RepositoryImplement
{
    public class EndowmentRepository : IEndowmentRepository
    {
        private readonly Data.AppDbContext _context;

        public EndowmentRepository(Data.AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Endowment>> GetAllAsync()
        {
            return await _context.Endowments
                .Include(e => e.Images)
                .ToListAsync();
        }

        public async Task<Endowment> GetByIdAsync(int id)
        {
            var endowment = await _context.Endowments
                .Include(e => e.Images)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (endowment == null)
                throw new KeyNotFoundException("The endowment wasn't found");

            return endowment;
        }

        public async Task<IEnumerable<Endowment>> GetByEndowmentTypeIdAsync(int id)
        {
            var endowment = await _context.Endowments
                .Include(e => e.Images)
                .Where(e => e.EndowmentTypeId == id)
                .ToListAsync();
                

            if (endowment == null)
                throw new KeyNotFoundException("The endowment wasn't found");

            return endowment;
        }

        public async Task<IEnumerable<Endowment>> GetFilteredAsync(FiltersDTO filtersDTO)
        {
            var query = _context.Endowments.AsQueryable();

            if (filtersDTO.categoryId.HasValue)
                query = query.Where(e => e.EndowmentCategoryId == filtersDTO.categoryId);

            if (filtersDTO.endowmentTypeId.HasValue)
                query = query.Where(e => e.EndowmentTypeId == filtersDTO.endowmentTypeId);

            return await query.Include(e => e.Images)
                .ToListAsync(); 
        }

        public async Task<IEnumerable<Endowment>> GetEndowmentsByNameAsync(NameSeachDTO nameSearchDTO)
        {
            var query = _context.Endowments.AsQueryable();

            var result = await query.Include(e => e.Images)
                .ToListAsync();

            if (!string.IsNullOrWhiteSpace(nameSearchDTO.name))
            {
                var normalized = NameNormalizer.Normalize(nameSearchDTO.name);
                result = result.Where(e => NameNormalizer.Normalize(e.Name).Contains(normalized)).ToList();
            }

            return result;
        }

        public async Task AddAsync(Endowment endowment)
        {
            await _context.Endowments.AddAsync(endowment);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Endowment endowment)
        {
            _context.Endowments.Update(endowment);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var endowment = await _context.Endowments.FindAsync(id);

            if (endowment != null) {

                _context.Endowments.Remove(endowment);

                await _context.SaveChangesAsync();
            }

           
        }
    }
}
