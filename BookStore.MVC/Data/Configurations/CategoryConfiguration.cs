using BookStore.MVC.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BookStore.MVC.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category> 
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name)
                .HasMaxLength(256)
                .IsRequired();
            builder.Property(c => c.Alias)
                .HasMaxLength(1000);
            builder.Property(c => c.Description)
                .HasMaxLength(1000);
            builder.HasData(
                new Category
                {
                    Id = new System.Guid("f5b3f9c7-7b3d-4b0b-9b3e-2e6d3b3b9e1d"),
                    Name = "Default",
                    Alias = "default",
                    Description = "Default category",
                    Position = 1
                });
        }
    }
}
