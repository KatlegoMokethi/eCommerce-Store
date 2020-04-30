using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YongzCreative.Infrastructure;
using YongzCreative.Models;
using YongzCreative.Models.ViewModels;

namespace YongzCreative.Controllers
{
    //[Authorize(Roles = "Customers")]
    public class CartController : Controller
    {
        private IProductRepository _repository;
        private Cart cart;
        public CartController(IProductRepository repository, Cart cartService)
        {
            _repository = repository;
            cart = cartService;
        }

        public IActionResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }
        public IActionResult AddToCart(int productId, string returnUrl)
        {
            Product product = _repository.GetById(productId);
            if (product != null)
            {
                cart.AddItem(product, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }
        public IActionResult RemoveFromCart(int productId,
        string returnUrl)
        {
            Product product = _repository.GetById(productId);
            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}
