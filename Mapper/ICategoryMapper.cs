using CatalogWebApi.DTO;
using CatalogWebApi.Models;

namespace CatalogWebApi.Mapper
{
    public interface ICategoryMapper
    {
        public Category DtoToEntity(CategoryDTO categoryDTO);

        public CategoryDTO EntitytoDto(Category category);

        public IEnumerable<CategoryDTO> EntityToDtoList(IEnumerable<Category> category);
    }
}
