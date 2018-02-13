using System.Collections.Generic;

namespace WebUI.Models
{
    public class FeaturedProductsViewModel
    {
        private List<ProductViewModel> products;

        public FeaturedProductsViewModel()
        {
            this.products = new List<ProductViewModel>();
        }

        public IList<ProductViewModel> Products
        {
            get { return this.products; }
        }
    }
}