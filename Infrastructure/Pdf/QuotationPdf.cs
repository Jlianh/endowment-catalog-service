using CatalogWebApi.Data;
using CatalogWebApi.DTO;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CatalogWebApi.Infrastructure.Pdf
{
    public class QuotationPdf : IDocument
    {
        public QuotationPdfDTO _quotation { get; }

        public QuotationPdf(QuotationPdfDTO quotation)
        {
            _quotation = quotation;
        }

        public DocumentMetadata GetMetadata() => new DocumentMetadata()
        {
            Title = "Cotizacion de Dotaciones.",
            Author = "SEGURIDAD INDUSTRIAL Y SUMINISTROS S.A.S."
        };

        public DocumentSettings GetSettings() => new DocumentSettings()
        {
            CompressDocument = true,
        };

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(30);

                page.Header()
                .Text("Cotización")
                .FontSize(24)
                .SemiBold()
                .FontColor(Colors.Blue.Medium);

                page.Content().Column(col =>
                {
                    col.Spacing(15);

                    // Información del cliente
                    col.Item().Text($"Cliente: {_quotation.clientName}");
                    col.Item().Text($"Empresa: {_quotation.clientCompany}");
                    col.Item().Text($"Email: {_quotation.clientEmail}");
                    col.Item().Text($"Teléfono: {_quotation.clientPhone}");
                    col.Item().Text($"Fecha: {_quotation.createdAt.ToShortDateString()}");

                    col.Item().PaddingVertical(10).LineHorizontal(1);

                    // Tabla
                    col.Item().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(70);     // Imagen
                            columns.RelativeColumn();       // Nombre
                            columns.RelativeColumn();       // Talla
                            columns.RelativeColumn();       // Color
                            columns.RelativeColumn();       // Cantidad
                        });

                        // Encabezados
                        table.Header(header =>
                        {
                            header.Cell().Text("Imagen").SemiBold();
                            header.Cell().Text("Nombre").SemiBold();
                            header.Cell().Text("Talla").SemiBold();
                            header.Cell().Text("Color").SemiBold();
                            header.Cell().Text("Cantidad").SemiBold();
                        });

                        var items = new List<QuotationItemPdfDTO>();

                        // Items
                        foreach (var item in _quotation.Items)
                        {

                            table.Cell().Image(GetImage(item.ImageName)).FitArea();
                            table.Cell().Text(item.EndowmentName);
                            table.Cell().Text(item.SizeName);
                            table.Cell().Text(item.ColorName);
                            table.Cell().Text(item.Quantity.ToString());
                        }
                    });
                });
            });
        }
        private byte[] GetImage(string name)
        {
            var basePath = @"C:\Users\hedi2\source\repos\CatalogWebApi\uploads";
            var path = Path.Combine(basePath, name);

            if (!File.Exists(path))
            {
                // Imagen por defecto para evitar romper el PDF
                var fallback = Path.Combine(basePath, "no-image.png");

                if (File.Exists(fallback))
                    return File.ReadAllBytes(fallback);

                return Array.Empty<byte>();
            }

            return File.ReadAllBytes(path);
        }

        public async Task<List<QuotationItemPdfDTO>> buildItemList(QuotationDTO quotationDTO)
        {
            var items = new List<QuotationItemPdfDTO>();

            var context = new AppDbContext();

            // Items
            foreach (var item in quotationDTO.quotationItems)
            {
                var endowment = await context.Endowments.FindAsync(item.endowmentId);
                var size = await context.Sizes.FindAsync(item.sizeId);
                var color = await context.Colors.FindAsync(item.colorId);

                items.Add(new QuotationItemPdfDTO
                {
                    EndowmentName = endowment.Name,
                    SizeName = size.Name,
                    ColorName = color.Name,
                    ImageName = item.imageName,
                    Quantity = item.quantity
                });
            }

            return items;
        }
    }
}
