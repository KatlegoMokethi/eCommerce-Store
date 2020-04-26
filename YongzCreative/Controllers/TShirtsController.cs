using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YongzCreative.Models;

namespace YongzCreative.Controllers
{
    [Route("[controller]")]
    public class TShirtsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public TShirtsController(IProductRepository repo)
        {
            _productRepository = repo;
        }

        public IActionResult Tshirts()
        {
            return View(_productRepository.TShirts);
        }
    }
}
