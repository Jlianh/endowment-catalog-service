namespace CatalogWebApi.DTO
{
    public class QuotationItemsDTO
    {
        public int id { get; set; }
        public int endowmentId { get; set; }
        public int? quotationId { get; set; }
        public int? sizeId { get; set; }
        public int? colorId { get; set; }
        public int quantity { get; set; }
        public string imageName { get; set; }

    }
}
