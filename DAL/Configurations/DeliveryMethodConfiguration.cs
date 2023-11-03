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
    public class DeliveryMethodConfiguration : IEntityTypeConfiguration<DeliveryMethod>
    {
        public void Configure(EntityTypeBuilder<DeliveryMethod> modelBuilder)
        {
            modelBuilder
               .HasKey(dM => dM.Id);

            modelBuilder
                .Property(dM => dM.Id)
                .HasDefaultValue(Guid.NewGuid())
                .HasConversion(
                    key => key.ToString(),
                    sqlKey => Guid.Parse(sqlKey));

            modelBuilder
                .Property(dM => dM.LogoUrl)
                .HasDefaultValue("https://w7.pngwing.com/pngs/7/387/png-transparent-delivery-computer-icons-timely-delivery-miscellaneous-angle-text.png");
        }
    }
}