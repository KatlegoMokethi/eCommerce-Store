using Microsoft.AspNetCore.Mvc;
using YongzCreative.Models;

namespace YongzCreative.Controllers
{
    [Route("[controller]")]
    public class SweatersController : Controller
    {
        private readonly IRepositoryWrapper _repository;

        public SweatersController(IRepositoryWrapper repo)
        {
            _repository = repo;
        }

        public IActionResult Sweaters()
        {
            return View(_repository.Product.FindByCondition(p => p.CategoryID == 3));
        }
    }
}
