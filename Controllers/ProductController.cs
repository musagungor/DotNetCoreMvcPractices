using System;
using System.Collections.Generic;
using System.IO;
using DotNetCoreMvcPractices.Models;
using DotNetCoreMvcPractices.Repositories;
using DotNetCoreMvcPractices.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

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
        private readonly IProductRepository repository;
        private readonly IHostingEnvironment environment;

        public ProductController(IHostingEnvironment environment, IProductRepository repository)
        {
            this.environment = environment;
            this.repository = repository;

        }

        [Route("products")]
        public IActionResult Index()
        {
            var products = repository.GetAll();

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
            repository.Add(productCreateViewModel.Product);

          

            return RedirectToAction("Index");

        }
    }
}