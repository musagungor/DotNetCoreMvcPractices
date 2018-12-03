using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcPractices.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {

        [Route("new-product")]
        public IActionResult Create()
        {

            return View();

        }
    }
}