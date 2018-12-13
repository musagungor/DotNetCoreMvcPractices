using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreMvcPractices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcPractices.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        // GET: Cart
        public ActionResult Index()
        {
           var cart =  _cartService.GetCart();
            return View(cart);
        }

		[Route("add-to-cart")]
		public async Task AddToCart(int id)
		{

			await _cartService.Add(id);



		}

	}
}