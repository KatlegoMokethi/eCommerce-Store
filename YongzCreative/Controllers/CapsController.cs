using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YongzCreative.Models;

namespace YongzCreative.Controllers
{
    [Route("[controller]")]
    public class CapsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public CapsController(IProductRepository repo)
        {
            _productRepository = repo;
        }

        public IActionResult Caps()
        {
            return View(_productRepository.Caps);
        }
    }
}
