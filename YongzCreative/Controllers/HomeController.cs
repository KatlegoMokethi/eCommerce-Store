using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YongzCreative.Models;

namespace YongzCreative.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository repo)
        {
            _productRepository = repo;
        }

        public IActionResult Index()
        {
            return View(_productRepository.Products);
        }
    }
}