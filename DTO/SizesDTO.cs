namespace CatalogWebApi.DTO
{
    public class SizesDTO
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<int> endowments { get; set; } = new();


    }
}
