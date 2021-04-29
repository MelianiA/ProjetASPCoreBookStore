using Microsoft.AspNetCore.Mvc;
using ProjetASPCore.Models;
using ProjetASPCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetASPCore.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some Book first");
            }
            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("ConfirmOrder");
            }
            return View(order);
        }

        public IActionResult ConfirmOrder()
        {
            return View();
        }
    }
}
