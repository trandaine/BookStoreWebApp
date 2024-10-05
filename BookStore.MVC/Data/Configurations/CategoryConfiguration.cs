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
            //builder.HasData(
            //    new Category
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Default",
            //        Alias = "default",
            //        Description = "Default category",
            //        Position = 1
            //    });
        }
    }
}
