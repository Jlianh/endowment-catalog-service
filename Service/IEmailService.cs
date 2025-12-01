using CatalogWebApi.DTO;

namespace CatalogWebApi.Service
{
    public interface IEmailService
    {
        Task sendEmail(SendQuotationDTO sendQuotationDTO, byte[] file, string fileName, string clientName);
    }
}
