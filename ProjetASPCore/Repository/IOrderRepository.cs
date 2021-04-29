using ProjetASPCore.Models;

namespace ProjetASPCore.Repository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
