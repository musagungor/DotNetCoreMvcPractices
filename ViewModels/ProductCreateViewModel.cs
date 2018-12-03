using System.Collections.Generic;
using DotNetCoreMvcPractices.Models;
using Microsoft.AspNetCore.Http;

namespace DotNetCoreMvcPractices.ViewModels
{
    public class ProductCreateViewModel
    {
        public Product Product { get; set; }
        public List<Brand> Brands { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}