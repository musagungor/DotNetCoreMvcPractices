namespace DotNetCoreMvcPractices.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Stock { get; set; }
        public int BrandId { get; set; }
    }
}