using CatalogWebApi.DTO;

namespace CatalogWebApi.Service
{
    public interface IQuotationsService
    {
        Task<IEnumerable<QuotationDTO>> GetAllQuotationsAsync();
        Task<QuotationDTO> GetQuotationByIdAsync(int id);

        Task<QuotationDTO> CreateQuotationAsync(QuotationDTO quotationDTO);
    }
}
