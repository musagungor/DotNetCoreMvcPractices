using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreMvcPractices.Models.Identity;
using DotNetCoreMvcPractices.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMvcPractices.Controllers
{
    public class AccountController : Controller
    {
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly RoleManager<ApplicationRole> _roleManager;

		public AccountController( UserManager<ApplicationUser> userManager,
			SignInManager<ApplicationUser> signInManager , 
			RoleManager<ApplicationRole> roleManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_roleManager = roleManager;
		}

        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Register() {

			return View();
		}


		[HttpPost]
		public async Task<IActionResult> RegisterAsync(RegisterViewModel registerViewModel)
		{
			var user = new ApplicationUser()
			{
				Email = registerViewModel.Email,
				UserName = registerViewModel.UserName
			};

			var identityResult = await _userManager.CreateAsync(user, registerViewModel.Password);

			if (identityResult.Succeeded)
			{
				await _userManager.AddToRoleAsync(user, "User");
			}


			return RedirectToAction("Index", "Home");

		}


		[HttpPost]
		public IActionResult Login(LoginViewModel loginViewModel) {



			return RedirectToAction("Index", "Home");

		}
    }
}