using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreMvcPractices.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcPractices.ViewComponents
{
    public class Category : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public Category(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();

            return await Task.FromResult((IViewComponentResult)View("Default", categories));
        }
    }
}
