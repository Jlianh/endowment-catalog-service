using CatalogWebApi.Data;
using CatalogWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogWebApi.Repository.RepositoryImplement
{
    public class QuotationRepository : IQuotationRepository
    {
        private readonly AppDbContext _appDbContext;

        public QuotationRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Quotation>> GetAllAsync()
        {
            return await _appDbContext
                .Quotations
                .Include(q => q.QuotationItems)
                .ToListAsync();
        }

        public async Task<Quotation> AddAsync(Quotation quotation)
        {
            await _appDbContext.Quotations.AddAsync(quotation);
            await _appDbContext.SaveChangesAsync();
            return quotation;
        }

        public async Task<List<QuotationItem>> AddQuotationItemsAsync(List<QuotationItem> quotationItems)
        {
            _appDbContext.QuotationItems.AddRange(quotationItems);
            await _appDbContext.SaveChangesAsync();
            return quotationItems;
        }

        public async Task<Quotation> GetByIdAsync(int id)
        {
            var quotation = await _appDbContext.Quotations
                .Include(q => q.QuotationItems)
                .FirstOrDefaultAsync(q => q.Id == id);

            if (quotation == null)
                throw new KeyNotFoundException("The endowment wasn't found");

            return quotation;
        }
        public async Task<ICollection<QuotationItem>> GetQuotationItemsByIdAsync(List<int> itemsId)
        {
            return await _appDbContext.QuotationItems
                .Where(q => itemsId.Contains(q.Id))
                .ToListAsync();
        } 
    }
}
