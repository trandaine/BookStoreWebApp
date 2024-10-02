using BookStore.MVC.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Permissions;

namespace BookStore.MVC.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(b => b.Title)
                .HasMaxLength(256)
                .IsRequired();
            builder.Property(b => b.Alias)
                .HasMaxLength(1000);
            
            builder.HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId);
            builder.HasData(
                new Book
                {
                    Id = new System.Guid("f5b3f9c7-7b3d-4b0b-9b3e-2e6d3b3b9e1d"),
                    Title = "Default",
                    Alias = "default",
                    Description = "Default book",
                    CategoryId = new System.Guid("f5b3f9c7-7b3d-4b0b-9b3e-2e6d3b3b9e1d"),
                    AuthorId = new System.Guid("f5b3f9c7-7b3d-4b0b-9b3e-2e6d3b3b9e1d")
                });
        }
    }
}
