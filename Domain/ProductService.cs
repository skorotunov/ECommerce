using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace Domain
{
    public class ProductService
    {
        private readonly ProductRepository productRepository;

        public ProductService(ProductRepository productRepository)
        {
            this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public IEnumerable<DiscountedProduct> GetFeaturedProducts(IPrincipal user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            return this.productRepository.GetFeaturedProducts().Select(x => x.ApplyDiscountFor(user));
        }
    }
}
