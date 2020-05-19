using Microsoft.AspNetCore.Mvc;
using YongzCreative.Models;

namespace YongzCreative.Controllers
{
    [Route("[controller]")]
    public class TShirtsController : Controller
    {
        private readonly IRepositoryWrapper _repository;

        public TShirtsController(IRepositoryWrapper repo)
        {
            _repository = repo;
        }

        public IActionResult Tshirts()
        {
            return View(_repository.Product.TShirts);
        }
    }
}
