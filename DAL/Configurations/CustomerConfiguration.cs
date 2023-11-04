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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> modelBuilder)
        {

            modelBuilder.HasKey(c => c.Id);

            modelBuilder
                .Property(c => c.Id)
                .HasDefaultValue(Guid.NewGuid())
                .HasConversion(
                    key => key.ToString(),
                    sqlKey => Guid.Parse(sqlKey));

            modelBuilder
                .Property(c => c.CreatedAt)
                .HasDefaultValue(DateTime.UtcNow);

            modelBuilder
                .HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);

            modelBuilder
                .Property(c => c.ProfilePicUrl)
                .HasDefaultValue("https://www.freeiconspng.com/thumbs/no-image-icon/no-image-icon-15.png");
        }
    }
}