using CatalogWebApi.DTO;
using CatalogWebApi.Models;

namespace CatalogWebApi.Mapper
{
    public interface IEndowmentTypeMapper
    {
        public EndowmentType DtoToEntity(EndowmentTypeDTO endowmentTypeDTO);

        public EndowmentTypeDTO EntitytoDto(EndowmentType endowmentType);

        public IEnumerable<EndowmentTypeDTO> EntityToDtoList(IEnumerable<EndowmentType> endowmentTypes);
    }
}
