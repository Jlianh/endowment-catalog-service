using CatalogWebApi.DTO;
using CatalogWebApi.Models;

namespace CatalogWebApi.Mapper.MapperImplement
{
    public class ColorMapper : IColorMapper
    {
        public Color DtoToEntity(ColorsDTO colorsDTO)
        {
            return new Color
            {
                Id = colorsDTO.id,
                Name = colorsDTO.name
            };
        }
        public ColorsDTO EntitytoDto(Color color)
        {
            return new ColorsDTO
            {
                id = color.Id,
                name = color.Name
            };
        }

        public IEnumerable<ColorsDTO> EntityToDtoList(IEnumerable<Color> color)
        {
            return color.Select(color => EntitytoDto(color));
        }
    }
}
