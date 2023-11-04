using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class SellerConfiguration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> modelBuilder)
        {
            modelBuilder
                .HasKey(s => s.Id);

            modelBuilder
                .Property(s => s.Id)
                .HasDefaultValue(Guid.NewGuid())
                .HasConversion(
                    key => key.ToString(),
                    sqlKey => Guid.Parse(sqlKey));

            modelBuilder
                .HasMany(s => s.Goods)
                .WithOne(g => g.Seller)
                .HasForeignKey(g => g.SellerId);
        }
    }
}