using CatalogWebApi.Data;
using CatalogWebApi.DTO;
using CatalogWebApi.Infrastructure.Pdf;
using CatalogWebApi.Mapper;
using CatalogWebApi.Models;
using CatalogWebApi.Repository;
using QuestPDF.Fluent;

namespace CatalogWebApi.Service.ServiceImplement
{
    public class PdfService : IPdfService
    {
        public async Task<byte[]> GenerateQuotationPdf(QuotationDTO quotationDTO)
        {

            var pdfInfo = new QuotationPdfDTO
            {
                clientName = quotationDTO.clientName,
                clientEmail = quotationDTO.clientEmail,
                clientPhone = quotationDTO.clientPhone,
                clientCompany = quotationDTO.clientCompany
            };

            var prePdf = new QuotationPdf(pdfInfo);

            var items = await prePdf.buildItemList(quotationDTO);

            var pdfModel = new QuotationPdfDTO
            {
                clientName = quotationDTO.clientName,
                clientCompany = quotationDTO.clientCompany,
                clientEmail = quotationDTO.clientEmail,
                clientPhone = quotationDTO.clientPhone,
                createdAt = quotationDTO.createdAt,
                Items = items
            };

            var buildPdf = new QuotationPdf(pdfModel);
            var bytes = buildPdf.GeneratePdf();

            return bytes;

        }

    }
}
