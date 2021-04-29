using ProjetASPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetASPCore.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }


        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            var items = _shoppingCart.GetShoppingCartItems();

            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            order.OrderDetails = new List<OrderDetail>();
            foreach (var item in items)
            {
                var orderDetail = new OrderDetail
                {
                    BookId = item.Book.BookId,
                    Amount = item.Amount,
                    Price = item.Book.Price,
                   
                };
                order.OrderDetails.Add(orderDetail);
            }

            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
        }
    }
}
