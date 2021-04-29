using Microsoft.AspNetCore.Mvc;
using ProjetASPCore.Models;
using ProjetASPCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetASPCore.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel();

            shoppingCartViewModel.ShoppingCart = _shoppingCart;
            shoppingCartViewModel.ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal();

            return View(shoppingCartViewModel);
        }
    }
}
