using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YongzCreative.Models;

namespace YongzCreative.Controllers
{
    //[Authorize]
    public class OrderController : Controller
    {
        private IProductRepository _repository;
        private Cart _cart;

        public OrderController(IProductRepository repository, Cart cart)
        {
            _repository = repository;
            _cart = cart;

        }

        //[Authorize(Roles = "Admins")]
        public IActionResult List()
        {
            return View(_repository.Order.GetOrders().Where(o => !o.Shipped));
        }

        [HttpPost]
        //[Authorize(Roles = "Admins")]
        public IActionResult MarkShipped(int orderID)
        {
            Order order = _repository.Order.GetById(orderID);
            if (order != null)
            {
                order.Shipped = true;
                _repository.Order.Save();
                TempData["Message"] = $"Order {orderID} has been shipped";
            }
            else
            {
                TempData["Message"] = $"Order {orderID} could not been shipped";
            }
            return RedirectToAction(nameof(List));
        }
        //[Authorize(Roles = "Customers")]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        //[Authorize(Roles = "Customers")]
        public IActionResult Checkout(Order order)
        {
            if (_cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                order.Lines = _cart.Lines.ToArray();
                _repository.Order.SaveOrder(order);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(order);
            }
        }

        //[Authorize(Roles = "Customers")]
        public IActionResult Completed()
        {
            _cart.Clear();
            return View();
        }
    }
}
