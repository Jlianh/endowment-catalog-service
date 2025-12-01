using CatalogWebApi.Data;
using CatalogWebApi.DTO;
using CatalogWebApi.Mapper;
using CatalogWebApi.Models;
using CatalogWebApi.Repository;

namespace CatalogWebApi.Service.ServiceImplement
{
    public class SizeService : ISizeService
    {
        private readonly ISizeRepository _sizeRepository;
        private readonly ISizeMapper _sizeMapper;
        public SizeService(ISizeRepository sizeRepository, ISizeMapper sizeMapper)
        {
            _sizeRepository = sizeRepository;
            _sizeMapper = sizeMapper;
        }

        public async Task<IEnumerable<SizesDTO>> GetAllSizesAsync()
        {
            IEnumerable<Size> colors = await _sizeRepository.GetAllAsync();

            return _sizeMapper.EntityToDtoList(colors);

        }
    }
}
