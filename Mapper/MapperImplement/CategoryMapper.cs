using CatalogWebApi.DTO;
using CatalogWebApi.Models;

namespace CatalogWebApi.Mapper.MapperImplement
{
    public class CategoryMapper : ICategoryMapper
    {
        public Category DtoToEntity(CategoryDTO categoryDTO)
        {
            return new Category
            {
                Id = categoryDTO.id,
                Name = categoryDTO.name,
                Description = categoryDTO.description
            };
        }
        public CategoryDTO EntitytoDto(Category category)
        {
            return new CategoryDTO
            {
                id = category.Id,
                name = category.Name,
                description = category.Description,
            };
        }

        public IEnumerable<CategoryDTO> EntityToDtoList(IEnumerable<Category> categories)
        {
            return categories.Select(endowments => EntitytoDto(endowments));
        }
    }
}
