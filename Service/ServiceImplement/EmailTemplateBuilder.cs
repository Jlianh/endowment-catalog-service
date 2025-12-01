using CatalogWebApi.DTO;
using System.Text;

namespace CatalogWebApi.Service.ServiceImplement
{
    public class EmailTemplateBuilder : IEmailTemplateBuilder
    {
        public async Task<string> BuildCotizationTemplateAsync(string clientName)
        {
            var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "QuotationTemplate.html");

            var html = await File.ReadAllTextAsync(templatePath);

            html = html.Replace("{{clientName}}", clientName)
                       .Replace("{{year}}", DateTime.Now.Year.ToString());

            return html;
        }
    }
}
