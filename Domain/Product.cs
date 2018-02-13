using System.Security.Principal;

namespace Domain
{
    public class Product
    {
        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public DiscountedProduct ApplyDiscountFor(IPrincipal user)
        {
            decimal discount = user.IsInRole("PreferredCustomer") ? 0.95m : 1;
            return new DiscountedProduct(this.Name, this.UnitPrice * discount);
        }
    }
}
