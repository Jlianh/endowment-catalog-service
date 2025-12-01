using CatalogWebApi.Data;
using CatalogWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogWebApi.Repository.RepositoryImplement
{
    public class ColorRepository: IColorsRepository
    {
        private readonly Data.AppDbContext _context;

        public ColorRepository(Data.AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Color>> GetAllAsync()
        {
            return await _context.Colors.ToListAsync();
        }
    }
}
