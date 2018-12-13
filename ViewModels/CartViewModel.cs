using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreMvcPractices.Models;

namespace DotNetCoreMvcPractices.ViewModels
{
    public class CartViewModel
    {
        public Cart Cart { get; set; }
        public decimal TotalPrice => Cart.CartItems.Sum(c=> c.Quantity * c.Product.Price);
    }
}
