using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(64)]
        public string Name { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        public decimal UnitPrice { get; set; }

        public bool IsFeatured { get; set; }

        public Domain.Product ToDomainProduct()
        {
            var product = new Domain.Product
            {
                Name = this.Name,
                UnitPrice = this.UnitPrice
            };
            return product;
        }
    }
}
