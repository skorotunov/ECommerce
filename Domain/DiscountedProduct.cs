using System;

namespace Domain
{
    public class DiscountedProduct
    {
        private readonly string name;
        private readonly decimal unitPrice;

        public DiscountedProduct(string name, decimal unitPrice)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.unitPrice = unitPrice;
        }

        public string Name
        {
            get => this.name;
        }

        public decimal UnitPrice
        {
            get => this.unitPrice;
        }
    }
}
