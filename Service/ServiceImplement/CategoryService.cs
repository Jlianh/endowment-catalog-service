using CatalogWebApi.Data;
using CatalogWebApi.DTO;
using CatalogWebApi.Mapper;
using CatalogWebApi.Models;
using CatalogWebApi.Repository;

namespace CatalogWebApi.Service.ServiceImplement
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICategoryMapper _categoryMapper;
        public CategoryService(ICategoryRepository categoryRepository, ICategoryMapper categoryMapper)
        {
            _categoryRepository = categoryRepository;
            _categoryMapper = categoryMapper;
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync()
        {
            IEnumerable<Category> categories = await _categoryRepository.GetAllAsync();

            return _categoryMapper.EntityToDtoList(categories);

        }
    }
}
