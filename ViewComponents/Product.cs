using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcPractices.ViewComponents
{
    public class Product : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(DotNetCoreMvcPractices.Models.Product product , string viewName = "Thumnail")
        {
           

            return await Task.FromResult((IViewComponentResult)View(viewName, product));
        }
    }
} 
