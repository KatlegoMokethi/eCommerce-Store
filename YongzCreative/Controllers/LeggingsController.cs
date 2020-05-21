using Microsoft.AspNetCore.Mvc;
using YongzCreative.Models;

namespace YongzCreative.Controllers
{
    [Route("[controller]")]
    public class LeggingsController : Controller
    {
        private readonly IRepositoryWrapper _repository;

        public LeggingsController(IRepositoryWrapper repo)
        {
            _repository = repo;
        }

        public IActionResult Leggings()
        {
            return View(_repository.Product.FindByCondition(p => p.CategoryID == 6));
        }
    }
}
