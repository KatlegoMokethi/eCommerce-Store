using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YongzCreative.Models;

namespace YongzCreative.Controllers
{
    [Route("[controller]")]
    public class LeggingsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public LeggingsController(IProductRepository repo)
        {
            _productRepository = repo;
        }

        public IActionResult Leggings()
        {
            return View(_productRepository.Leggings);
        }
    }
}
