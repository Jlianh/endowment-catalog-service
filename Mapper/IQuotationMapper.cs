using CatalogWebApi.DTO;
using CatalogWebApi.Models;

namespace CatalogWebApi.Mapper
{
    public interface IQuotationMapper
    {
        public Quotation DtoToEntity(QuotationDTO quotationDTO);

        public QuotationDTO EntitytoDto(Quotation quotation);

        public IEnumerable<QuotationDTO> EntityToDtoList(IEnumerable<Quotation> quotations);

        QuotationItem DtoToItemEntity(QuotationItemsDTO quotationItemsDTO, int quotationId);
    }
}
