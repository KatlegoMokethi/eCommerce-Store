using Microsoft.AspNetCore.Mvc;
using YongzCreative.Models;

namespace YongzCreative.Controllers
{
    [Route("[controller]")]
    public class CapsController : Controller
    {
        private readonly IRepositoryWrapper _repository;

        public CapsController(IRepositoryWrapper repo)
        {
            _repository = repo;
        }

        public IActionResult Caps()
        {
            return View(_repository.Product.Caps);
        }
    }
}
