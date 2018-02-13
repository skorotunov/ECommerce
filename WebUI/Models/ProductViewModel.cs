using Domain;

namespace WebUI.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
        }

        public ProductViewModel(DiscountedProduct product)
        {
            this.Name = product.Name;
            this.UnitPrice = product.UnitPrice;
        }

        public string Name { get; set; }

        public string SummaryText
        {
            get => $"{this.Name} ({this.UnitPrice.ToString("C")})";
        }

        public decimal UnitPrice { get; set; }
    }
}