namespace CatalogWebApi.DTO
{
    public class QuotationDTO
    {
        public int id {  get; set; }
        public string clientName { get; set; }
        public string? clientCompany {  get; set; }
        public string clientEmail { get; set; }
        public string? clientAddress { get; set; }
        public string? clientPhone { get; set; }
        public DateOnly createdAt { get; set; }
        public List<QuotationItemsDTO> quotationItems { get; set; }


    }
}
