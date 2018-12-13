using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreMvcPractices.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcPractices.ViewComponents
{
    public class Cart : ViewComponent
    {
        private readonly ICartService _cartService;

        public Cart(ICartService cartService)
        {
            _cartService = cartService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cart =  _cartService.GetCart();

            return await Task.FromResult((IViewComponentResult)View("CartSummary", cart));

        }


    }
}
