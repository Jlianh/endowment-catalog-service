using CatalogWebApi.DTO;
using CatalogWebApi.Models;

namespace CatalogWebApi.Mapper.MapperImplement
{
    public class EndowmentTypeMapper : IEndowmentTypeMapper
    {
        public EndowmentType DtoToEntity(EndowmentTypeDTO endowmentTypeDTO)
        {
            return new EndowmentType
            {
                Id = endowmentTypeDTO.id,
                Name = endowmentTypeDTO.name,
                Description = endowmentTypeDTO.description
            };
        }
        public EndowmentTypeDTO EntitytoDto(EndowmentType endowmentType)
        {
            return new EndowmentTypeDTO
            {
                id = endowmentType.Id,
                name = endowmentType.Name,
                description = endowmentType.Description,
            };
        }

        public IEnumerable<EndowmentTypeDTO> EntityToDtoList(IEnumerable<EndowmentType> endowmentTypes)
        {
            return endowmentTypes.Select(endowments => EntitytoDto(endowments));
        }
    }
}
