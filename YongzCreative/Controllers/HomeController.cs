using Microsoft.AspNetCore.Mvc;
using YongzCreative.Models;

namespace YongzCreative.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositoryWrapper _repository;

        public HomeController(IRepositoryWrapper repo)
        {
            _repository = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllProducts()
        {
            return View(_repository.Product.FindAll());
        }
    }
}