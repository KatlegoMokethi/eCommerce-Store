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
        private readonly IRepositoryWrapper _repository;

        public SweatpantsController(IRepositoryWrapper repo)
        {
            _repository = repo;
        }

        public IActionResult Sweatpants()
        {
            return View(_repository.Product.Sweatpants);
        }
    }
}
