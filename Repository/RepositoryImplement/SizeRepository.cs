using CatalogWebApi.Data;
using CatalogWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogWebApi.Repository.RepositoryImplement
{
    public class SizeRepository: ISizeRepository
    {
        private readonly Data.AppDbContext _context;

        public SizeRepository(Data.AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Size>> GetAllAsync()
        {
            return await _context.Sizes.ToListAsync();
        }
    }
}
