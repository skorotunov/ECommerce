using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class ProductRepository : Domain.ProductRepository
    {
        private readonly ECommerceContext context;

        public ProductRepository(string connString)
        {
            this.context = new ECommerceContext(connString);
        }

        public override IEnumerable<Domain.Product> GetFeaturedProducts() => this.context.Products
            .Where(x => x.IsFeatured).Select(x => x.ToDomainProduct());
    }
}
