using CatalogWebApi.DTO;
using CatalogWebApi.Models;

namespace CatalogWebApi.Mapper
{
    public interface IEndowmentMapper
    {
        public Endowment SaveDtoToEntity(SaveEndowmentDTO dto);

        public Endowment DtoToEntity(EndowmentDTO endowmentDTO);

        public EndowmentDTO EntitytoDto(Endowment endowment);

        public IEnumerable<EndowmentDTO> EntityToDtoList(IEnumerable<Endowment> endowments);
    }
}
