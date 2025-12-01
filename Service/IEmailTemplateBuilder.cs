using CatalogWebApi.DTO;

namespace CatalogWebApi.Service
{
    public interface IEmailTemplateBuilder
    {
        Task<string> BuildCotizationTemplateAsync(string clientName);
    }
}
