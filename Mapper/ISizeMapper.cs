using CatalogWebApi.DTO;
using CatalogWebApi.Models;

namespace CatalogWebApi.Mapper
{
    public interface ISizeMapper
    {
        public Size DtoToEntity(SizesDTO sizesDTO);

        public SizesDTO EntitytoDto(Size size);

        public IEnumerable<SizesDTO> EntityToDtoList(IEnumerable<Size> size);
    }
}
