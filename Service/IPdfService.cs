using CatalogWebApi.DTO;
using CatalogWebApi.Models;

namespace CatalogWebApi.Service
{
    public interface IPdfService
    {
        Task<byte[]> GenerateQuotationPdf(QuotationDTO quotationDTO);
    }
}
