using CatalogWebApi.DTO;
using CatalogWebApi.Models;

namespace CatalogWebApi.Mapper.MapperImplement
{
    public class SizeMapper : ISizeMapper
    {
        public Size DtoToEntity(SizesDTO sizesDTO)
        {
            return new Size
            {
                Id = sizesDTO.id,
                Name = sizesDTO.name,
                Description = sizesDTO.description
            };
        }
        public SizesDTO EntitytoDto(Size size)
        {
            return new SizesDTO
            {
                id = size.Id,
                name = size.Name,
                description = size.Description
            };
        }

        public IEnumerable<SizesDTO> EntityToDtoList(IEnumerable<Size> size)
        {
            return size.Select(size => EntitytoDto(size));
        }
    }
}
