using DShop.Infrastructure.Repositories;
using DShop.Ordering.Core.Orders.Entities;
using DShop.Ordering.Core.Orders.Repositories;

namespace DShop.Ordering.Infrastructure.Repositories
{
    public class OrdersRepository : Repository<Order, OrderingContext>, IOrdersRepository
    {
        public OrdersRepository(OrderingContext context) : base(context)
        {
        }
    }
}
