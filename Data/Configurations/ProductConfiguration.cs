using IntelligentGrowthSolutions.Marketplace.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntelligentGrowthSolutions.Marketplace.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("products");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("product_id");

            builder.Property(e => e.Name)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(e => e.Price)
                .HasMaxLength(10)
                .IsRequired();

            builder.HasData(new Product
            {
                Id = 1,
                Name = "Lavender heart",
                Price = "9.25"
            },
            new Product
            {
                Id = 2,
                Name = "Personalised cufflinks",
                Price = "45.00"
            }, new Product
            {
                Id = 3,
                Name = "Kids T-shirt",
                Price = "19.95"
            }
            );
        }
    }
}
