using DShop.Infrastructure.Repositories;
using DShop.Ordering.Core.Baskets.Entities;
using DShop.Ordering.Core.Baskets.Repositories;

namespace DShop.Ordering.Infrastructure.Repositories
{
    public class BasketsRepository : Repository<Basket, OrderingContext>, IBasketsRepository
    {
        public BasketsRepository(OrderingContext context) : base(context)
        {
        }
    }
}
