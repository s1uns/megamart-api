using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> modelBuilder)
        {

            modelBuilder.HasKey(c => c.Id);

            modelBuilder
                .Property(c => c.Id)
                .HasDefaultValue(Guid.NewGuid())
                .HasConversion(
                    key => key.ToString(),
                    sqlKey => Guid.Parse(sqlKey));

            modelBuilder
                .Property(c => c.Description)
                .HasDefaultValue("No description");

            modelBuilder
                .Property(c => c.Color)
                .HasDefaultValue("FFFFFF");

            modelBuilder
                .Property(c => c.LogoUrl)
                .HasDefaultValue("https://icons.veryicon.com/png/o/commerce-shopping/basic-icon-of-e-commerce/empty-21.png");

            modelBuilder
                .HasMany(c => c.Goods)
                .WithMany(g => g.Categories);

        }
    }
}