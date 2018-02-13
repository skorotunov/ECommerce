using Domain;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductRepository productRepository;

        public HomeController(ProductRepository productRepository)
        {
            this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public ActionResult Index()
        {
            var productService = new ProductService(this.productRepository);

            var viewModel = new FeaturedProductsViewModel();

            IEnumerable<DiscountedProduct> products = productService.GetFeaturedProducts(this.User);
            foreach (DiscountedProduct product in products)
            {
                var productViewModel = new ProductViewModel(product);
                viewModel.Products.Add(productViewModel);
            }

            return this.View(viewModel);
        }
    }
}