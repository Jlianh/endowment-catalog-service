using CatalogWebApi.Models;

namespace CatalogWebApi.Repository
{
    public interface IQuotationRepository
    {
        Task<IEnumerable<Quotation>> GetAllAsync();
        Task<Quotation> GetByIdAsync(int id);
        Task<Quotation> AddAsync(Quotation quotation);
        Task<List<QuotationItem>> AddQuotationItemsAsync(List<QuotationItem> quotationItems);
        Task<ICollection<QuotationItem>> GetQuotationItemsByIdAsync(List<int> itemsId);
    }
}
