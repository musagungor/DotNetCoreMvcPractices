using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace DotNetCoreMvcPractices.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
[StringLength(255)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Stock { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string ImagePath { get; set; }

        public int CategoryId { get; set; }
        [JsonIgnore]
        public Category Category { get; set; }
    }
}