using CatalogWebApi.Data;
using CatalogWebApi.DTO;
using CatalogWebApi.Mapper;
using CatalogWebApi.Models;
using CatalogWebApi.Repository;

namespace CatalogWebApi.Service.ServiceImplement
{
    public class ColorService : IColorService
    {
        private readonly IColorsRepository _colorRepository;
        private readonly IColorMapper _colorMapper;
        public ColorService(IColorsRepository colorsRepository, IColorMapper colorMapper)
        {
            _colorRepository = colorsRepository;
            _colorMapper = colorMapper;
        }

        public async Task<IEnumerable<ColorsDTO>> GetAllColorssAsync()
        {
            IEnumerable<Color> colors = await _colorRepository.GetAllAsync();

            return _colorMapper.EntityToDtoList(colors);

        }
    }
}
