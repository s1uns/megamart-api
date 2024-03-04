using Core.Enums;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> modelBuilder)
        {
            modelBuilder
              .HasKey(o => o.Id);

            modelBuilder
                .Property(o => o.Id)
                .HasDefaultValue(Guid.NewGuid())
                .HasConversion(
                    key => key.ToString(),
                    sqlKey => Guid.Parse(sqlKey));

            modelBuilder
                .HasOne(o => o.Customer);

            modelBuilder
                .HasMany(o => o.OrderPositions)
                .WithOne(oP => oP.Order)
                .HasForeignKey(oP => oP.OrderId);

            modelBuilder
                .Property(o => o.CreatedAt)
                .HasDefaultValue(DateTime.UtcNow);

            modelBuilder
                .Property(o => o.OrderStatus)
                .HasDefaultValue(OrderStatus.JustCreated);
        }
    }
}