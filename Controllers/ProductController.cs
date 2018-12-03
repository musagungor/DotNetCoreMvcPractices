using System.Collections.Generic;
using DotNetCoreMvcPractices.Models;
using DotNetCoreMvcPractices.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcPractices.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {

        [Route("new-product")]
        public IActionResult Create()
        {
            var productCreateViewModel = new ProductCreateViewModel();
            productCreateViewModel.Brands = new List<Brand>{
                new Brand{Id=1,Name="Mercedes"},
                new Brand{Id=2,Name="Renault"},
                new Brand{Id=3,Name="Anadol"},
                new Brand{Id=4,Name="Suziki"}
            };

            return View(productCreateViewModel);

        }

        [Route("new-product")]
        [HttpPost]
        public IActionResult Create(ProductCreateViewModel productCreateViewModel)
        {

            var aa = productCreateViewModel;
             productCreateViewModel.Brands = new List<Brand>{
                new Brand{Id=1,Name="Mercedes"},
                new Brand{Id=2,Name="Renault"},
                new Brand{Id=3,Name="Anadol"},
                new Brand{Id=4,Name="Suziki"}
            };
            return View(productCreateViewModel);

        }
    }
}