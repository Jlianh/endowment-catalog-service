using CatalogWebApi.DTO;
using CatalogWebApi.Models;

namespace CatalogWebApi.Mapper
{
    public interface IColorMapper
    {
        public Color DtoToEntity(ColorsDTO colorsDTO);

        public ColorsDTO EntitytoDto(Color color);

        public IEnumerable<ColorsDTO> EntityToDtoList(IEnumerable<Color> color);
    }
}
