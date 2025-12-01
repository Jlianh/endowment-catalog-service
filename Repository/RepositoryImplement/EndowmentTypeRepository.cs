using CatalogWebApi.Data;
using CatalogWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogWebApi.Repository.RepositoryImplement
{
    public class EndowmentTypeRepository :IEndowmentTypeRepository
    {
        private readonly Data.AppDbContext _context;

        public EndowmentTypeRepository(Data.AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EndowmentType>> GetAllAsync()
        {
            return await _context.EndowmentTypes.ToListAsync();
        }
    }
}
