using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using DotNetCoreMvcPractices.Helpers;
using DotNetCoreMvcPractices.Models;
using DotNetCoreMvcPractices.Repositories;
using DotNetCoreMvcPractices.Services;
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
        private readonly ICartService _cartService;

        public ProductController(IHostingEnvironment environment,
        IProductRepository repository,
        IUnitOfWork unitOfWork,
        IBrandRepository brandRepository,
        IFormFileDownloader fileDownloader,
            ICartService cartService)
        {
            this.environment = environment;
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.brandRepository = brandRepository;
            this.fileDownloader = fileDownloader;
            _cartService = cartService;
        }

        //TOASK Sayfadan buton ile bu actiona gelmek için post ve pur ikiside olmalı mı?
        [Route("products")]
        public async Task<IActionResult> Index(string productName,int? categoryId)
        {
            var products = await repository
                        .FindAsync(p => (string.IsNullOrWhiteSpace(productName)
                                        || p.Name.ToLower().StartsWith(productName.ToLower()))
                                        && (!categoryId.HasValue || p.CategoryId==categoryId.Value )
                                        );
            return View(products);
        }

        [HttpPost]
        public async Task<IActionResult> Index()
        {
            var products = await repository.GetAllAsync();
            return View(products);
        }

        [Route("new-product")]
        public async Task<IActionResult> Create(int? id)
        {
            var productCreateViewModel = new ProductCreateViewModel();
            productCreateViewModel.Brands = await brandRepository.GetAllAsync();
            if (id.HasValue)
            {
                var product = await repository.GetAsync(id.Value);
                if (product != null)
                {
                    productCreateViewModel.Product = product;
                }
            }

            return View(productCreateViewModel);

        }

        [Route("new-product")]
        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateViewModel productCreateViewModel)
        {
            var imagePath = "";
            var newImageExist = false;
            if (productCreateViewModel.ImageFile != null
           && productCreateViewModel.ImageFile.Length > 0)
            {
                var filePath = Path.Combine(environment.WebRootPath, @"images/product");
                fileDownloader.DonloadFormFile(productCreateViewModel.ImageFile, filePath);
                imagePath = productCreateViewModel.ImageFile.FileName;
                newImageExist = true;
            }

            if (productCreateViewModel.Product.Id > 0)
            {
                var productDb = await repository.GetAsync(productCreateViewModel.Product.Id);
                if (productDb != null)
                {

                    productDb.Name = productCreateViewModel.Product.Name;
                    productDb.Stock = productCreateViewModel.Product.Stock;
                    productDb.Price = productCreateViewModel.Product.Price;
                    productDb.BrandId = productCreateViewModel.Product.BrandId;
                    if (newImageExist)
                        productDb.ImagePath = imagePath;
                }
            }
            else
            {
                productCreateViewModel.Product.ImagePath = imagePath;
                await repository.AddAsync(productCreateViewModel.Product);

            }




            await unitOfWork.ComplateAsync();


            return RedirectToAction("Index");

        }

        [Route("delete-product")]
        public async Task<IActionResult> Delete(int id)
        {

            var product = await repository.GetAsync(id);
            if (product == null) { return NotFound(); }

            repository.Remove(product);
            await unitOfWork.ComplateAsync();


            return RedirectToAction("Index"); ;

        }

        [Route("add-to-cart")]
        public async Task AddToCart(int id)
        {

            await _cartService.Add(id);


           
        }
    }
}