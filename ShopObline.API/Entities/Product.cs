namespace ShopOnline.API.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Desc { get; set; }
        public string? ImageURL { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public int CategoryID { get; set; }
    }
}
