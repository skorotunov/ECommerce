using System.Data.Entity;

namespace DAL
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext()
        {
        }

        public ECommerceContext(string connectionStr)
            : base(connectionStr)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
