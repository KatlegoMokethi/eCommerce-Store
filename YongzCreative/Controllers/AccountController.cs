using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YongzCreative.Models.ViewModels;

namespace YongzCreative.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;
        private string _role = "Customers";
        public AccountController(UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginModel
            {
                ReturnUrl = returnUrl
            });
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user =
                await _userManager.FindByEmailAsync(loginModel.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user,
                    loginModel.Password, false, false);
                    if (result.Succeeded)
                    {
                        return Redirect(loginModel?.ReturnUrl ?? "/Home/Index");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid email or password");
            return View(loginModel);
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                if (await _roleManager.FindByNameAsync(_role) == null)
                {
                    await _roleManager.CreateAsync(new IdentityRole(_role));
                }
                var user = new IdentityUser
                {
                    UserName = registerModel.UserName,
                    Email = registerModel.Email
                };
                var result = await _userManager.CreateAsync(user, registerModel.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, _role);
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("", "Unable to register new user");
                }
            }
            return View(registerModel);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
