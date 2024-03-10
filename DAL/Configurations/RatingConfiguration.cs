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
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> modelBuilder)
        {
            modelBuilder
                .HasKey(r => r.Id);

            modelBuilder
                .Property(r => r.Id)
                .HasDefaultValue(Guid.NewGuid())
                .HasConversion(
                    key => key.ToString(),
                    sqlKey => Guid.Parse(sqlKey));

            modelBuilder
                .HasOne(r => r.Customer)
                .WithMany(c => c.Ratings)
                .HasForeignKey(r => r.CustomerId);            
            
            modelBuilder
                .HasOne(r => r.Good)
                .WithMany(g => g.Ratings)
                .HasForeignKey(r => r.GoodId);
        }
    }
}
