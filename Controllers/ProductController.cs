using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using DotNetCoreMvcPractices.Helpers;
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


        private readonly IHostingEnvironment environment;
        private readonly IProductRepository repository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IBrandRepository brandRepository;
        private readonly IFormFileDownloader fileDownloader;

        public ProductController(IHostingEnvironment environment,
        IProductRepository repository,
        IUnitOfWork unitOfWork,
        IBrandRepository brandRepository,
        IFormFileDownloader fileDownloader)
        {
            this.environment = environment;
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.brandRepository = brandRepository;
            this.fileDownloader = fileDownloader;

        }

//TOASK Sayfadan buton ile bu actiona gelmek için post ve pur ikiside olmalı mı?
        [Route("products")]
        public async Task<IActionResult> Index(string productName)
        {
            var products = await repository
                        .FindAsync(p => string.IsNullOrWhiteSpace(productName)
                                        || p.Name.ToLower().StartsWith(productName.ToLower()));
            return View(products);
        }

        [HttpPost]
        public async Task<IActionResult> Index()
        {
            var products = await repository.GetAllAsync();
            return View(products);
        }

        [Route("new-product")]
        public async Task<IActionResult> Create()
        {
            var productCreateViewModel = new ProductCreateViewModel();
            productCreateViewModel.Brands = await brandRepository.GetAllAsync();

            return View(productCreateViewModel);

        }

        [Route("new-product")]
        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateViewModel productCreateViewModel)
        {


            if (productCreateViewModel.ImageFile != null
            && productCreateViewModel.ImageFile.Length > 0)
            {
                var filePath = Path.Combine(environment.WebRootPath, @"images/product");
                fileDownloader.DonloadFormFile(productCreateViewModel.ImageFile, filePath);
                productCreateViewModel.Product.ImagePath = productCreateViewModel.ImageFile.FileName;

            }
            await repository.AddAsync(productCreateViewModel.Product);
            await unitOfWork.ComplateAsync();


            return RedirectToAction("Index");

        }

         [Route("delete-product")]
        public async Task<IActionResult> Delete(int id)
        {

            var product = await repository.GetAsync(id);
             if(product == null){  return NotFound();}
          
            repository.Remove(product);
            await unitOfWork.ComplateAsync();


            return RedirectToAction("Index");;

        }
    }
}