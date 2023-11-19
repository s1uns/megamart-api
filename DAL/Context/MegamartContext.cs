using Core.Models;
using DAL.Configurations;
using Microsoft.EntityFrameworkCore;

namespace megamart_api.Context
{
    public class MegamartContext : DbContext
    {
        public MegamartContext(DbContextOptions<MegamartContext> options) : base(options) { }

        public required DbSet<Category> Categories { get; set; }
        public required DbSet<Customer> Customers { get; set; }
        public required DbSet<DeliveryAddress> DeliveryAddresses { get; set; }
        public required DbSet<DeliveryMethod> DeliveryMethods { get; set; }
        public required DbSet<Good> Goods { get; set; }
        public required DbSet<GoodOption> GoodOptions { get; set; }
        public required DbSet<Order> Orders { get; set; }
        public required DbSet<OrderPosition> OrderPositions { get; set; }
        public required DbSet<Seller> Sellers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new DeliveryAddressConfiguration());
            builder.ApplyConfiguration(new DeliveryMethodConfiguration());
            builder.ApplyConfiguration(new GoodConfiguration());            
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new OrderPositionConfiguration());
            builder.ApplyConfiguration(new SellerConfiguration());
        }

    }
}
