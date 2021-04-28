using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetASPCore.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;

        public string ShoppingCartSessinID { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public static ShoppingCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = service.GetService<AppDbContext>();

            var sessionCart = session.GetString("cartIdSession") ?? Guid.NewGuid().ToString();

            session.SetString("cartIdSession", sessionCart);

            return new ShoppingCart(context) { ShoppingCartSessinID = sessionCart };

        }
        public void AddToCart(Book book, int amount)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.
                FirstOrDefault(item => item.ShoppingCartSessionId == ShoppingCartSessinID
                && item.Book.BookId == book.BookId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartSessionId = ShoppingCartSessinID,
                    Book = book,
                    Amount = 1
                };
                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            _appDbContext.SaveChanges();
        }
        public int RemoveFromCart(Book book)
        {
            var shoppingCartItem =
                    _appDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Book.BookId == book.BookId && s.ShoppingCartSessionId == ShoppingCartSessinID);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
                       _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartSessionId == ShoppingCartSessinID)
                           .Include(s => s.Book)
                           .ToList());
        }
        public void ClearCart()
        {
            var cartItems = _appDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartSessionId == ShoppingCartSessinID);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }
        public double GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartSessionId == ShoppingCartSessinID)
                .Select(c => c.Book.Price * c.Amount).Sum();
            return total;
        }
    }
}

