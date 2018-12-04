using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using DotNetCoreMvcPractices.Models;
using DotNetCoreMvcPractices.Repositories;
using DotNetCoreMvcPractices.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreMvcPractices.Controllers
{


    [Route("product")]
    public class ProductController : Controller
    {

        List<Brand> Brands = new List<Brand>{
                new Brand{Id=1,Name="Mercedes"},
                new Brand{Id=2,Name="Renault"},
                new Brand{Id=3,Name="Anadol"},
                new Brand{Id=4,Name="Suziki"}
            };
        
        private readonly IHostingEnvironment environment;
        private readonly MvcPracticeDbContext context;

        public ProductController(IHostingEnvironment environment, MvcPracticeDbContext context)
        {
            this.environment = environment;
            this.context = context;
        }

        [Route("products")]
        public async Task<IActionResult> Index()
        {
            var products = await context.Products.Include(m=>m.Brand).ToListAsync();
            return View(products);
        }

        [Route("new-product")]
        public IActionResult Create()
        {
            var productCreateViewModel = new ProductCreateViewModel();
            productCreateViewModel.Brands = Brands;

            return View(productCreateViewModel);

        }

        [Route("new-product")]
        [HttpPost]
        public IActionResult Create(ProductCreateViewModel productCreateViewModel)
        {


            if (productCreateViewModel.ImageFile != null && productCreateViewModel.ImageFile.Length > 0)
            {
                var filePath = Path.Combine(environment.WebRootPath, @"TempImages");
                var x = Path.Combine(Directory.GetCurrentDirectory(), @"Images");
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                     productCreateViewModel.ImageFile.CopyTo(stream);
                    productCreateViewModel.Product.ImagePath = productCreateViewModel.ImageFile.FileName;
                }
            }
             context.Products.Add(productCreateViewModel.Product);
            context.SaveChanges();
          

            return RedirectToAction("Index");

        }
    }
}