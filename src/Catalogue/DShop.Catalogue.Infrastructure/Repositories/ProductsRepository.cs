using DShop.Catalogue.Core.Entities;
using DShop.Catalogue.Core.Repositories;
using DShop.Infrastructure.Repositories;

namespace DShop.Catalogue.Infrastructure.Repositories
{
    public class ProductsRepository : Repository<Product, CatalogueContext>, IProductsRepository
    {
        public ProductsRepository(CatalogueContext context) : base(context)
        {
        }
    }
}
