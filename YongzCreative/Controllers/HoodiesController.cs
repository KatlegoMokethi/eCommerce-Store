using Microsoft.AspNetCore.Mvc;
using YongzCreative.Models;

namespace YongzCreative.Controllers
{
    [Route("[controller]")]
    public class HoodiesController : Controller
    {
        private readonly IRepositoryWrapper _repository;

        public HoodiesController(IRepositoryWrapper repo)
        {
            _repository = repo;
        }

        public IActionResult Hoodies()
        {
            return View(_repository.Product.Hoodies);
        }
    }
}