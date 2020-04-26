using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YongzCreative.Models;

namespace YongzCreative.Controllers
{
    [Route("[controller]")]
    public class SweatpantsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public SweatpantsController(IProductRepository repo)
        {
            _productRepository = repo;
        }

        public IActionResult Sweatpants()
        {
            return View(_productRepository.Sweatpants);
        }
    }
}
