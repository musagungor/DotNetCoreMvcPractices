using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreMvcPractices.Helpers;
using DotNetCoreMvcPractices.Models;
using DotNetCoreMvcPractices.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace DotNetCoreMvcPractices.Services
{
    public class CartService : ICartService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IProductRepository _productRepository;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        private const string CART_KEY = "cart";

        public CartService(IHttpContextAccessor httpContextAccessor,IProductRepository productRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _productRepository = productRepository;
        }
        public Cart GetCart()
        {
            var cart = _session.GetObjectFromJson<Cart>(CART_KEY);
            if (cart == null)
            {
                cart=new Cart();
                _session.SetObjectAsJson(CART_KEY,cart);
            }
            return cart;
        }

        public async Task Add(int id)
        {
            var cart = GetCart();
            var product = await _productRepository.GetAsync(id);
            if (product == null) return;

            var cartItem = cart.CartItems.FirstOrDefault(p => p.Product.Id == id);
            if (cartItem == null)
            {
                cartItem = new CartItem {Product = product, Quantity = 1};
                cart.CartItems.Add(cartItem);
            }
            else
                cartItem.Quantity++;

            _session.SetObjectAsJson(CART_KEY, cart);

        }

        public async Task Remove(int id)
        {
            var cart = GetCart();
            var product = await _productRepository.GetAsync(id);
            if (product == null) return;

            var cartItem = cart.CartItems.FirstOrDefault(p => p.Product.Id == id);
            if (cartItem == null)
                return;
            else
                cartItem.Quantity--;

            if (cartItem.Quantity <= 0)
            {
                cart.CartItems.Remove(cartItem);
            }

            _session.SetObjectAsJson(CART_KEY, cart);

        }
    }
}
