using CatalogWebApi.Data;
using CatalogWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogWebApi.Repository.RepositoryImplement
{
    public class  CategoryRepository: ICategoryRepository
    {
        private readonly Data.AppDbContext _context;

        public CategoryRepository(Data.AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
