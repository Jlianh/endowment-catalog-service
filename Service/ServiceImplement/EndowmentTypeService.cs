using CatalogWebApi.Data;
using CatalogWebApi.DTO;
using CatalogWebApi.Mapper;
using CatalogWebApi.Models;
using CatalogWebApi.Repository;

namespace CatalogWebApi.Service.ServiceImplement
{
    public class EndowmentTypeService : IEndowmentTypeService
    {
        private readonly IEndowmentTypeRepository _endowmentRepository;
        private readonly IEndowmentTypeMapper _endowmentTypeMapper;
        public EndowmentTypeService(IEndowmentTypeRepository endowmentTypeRepository, IEndowmentTypeMapper endowmentTypeMapper)
        {
            _endowmentRepository = endowmentTypeRepository;
            _endowmentTypeMapper = endowmentTypeMapper;
        }

        public async Task<IEnumerable<EndowmentTypeDTO>> GetAllEndowmentsTypesAsync()
        {
            IEnumerable<EndowmentType> endowments = await _endowmentRepository.GetAllAsync();

            return _endowmentTypeMapper.EntityToDtoList(endowments);

        }
    }
}
