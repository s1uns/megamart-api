using Core.Models;
using DAL.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace megamart_api.Context
{
    public class MegamartContext : IdentityDbContext<IdentityUser>
    {

        public required DbSet<Category> Categories { get; set; }
        public required DbSet<Customer> Customers { get; set; }
        public required DbSet<DeliveryAddress> DeliveryAddresses { get; set; }
        public required DbSet<DeliveryMethod> DeliveryMethods { get; set; }
        public required DbSet<Good> Goods { get; set; }
        public required DbSet<GoodOption> GoodOptions { get; set; }
        public required DbSet<Order> Orders { get; set; }
        public required DbSet<OrderPosition> OrderPositions { get; set; }
        public required DbSet<Seller> Sellers { get; set; }

        public MegamartContext(DbContextOptions<MegamartContext> options) : base(options) { }

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

            base.OnModelCreating(builder);

        }
    }
}
