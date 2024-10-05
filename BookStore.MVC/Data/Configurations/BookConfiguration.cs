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
                    Id = Guid.NewGuid(),
                    Title = "Default",
                    Alias = "default",
                    Description = "Default book"                    
                });
        }
    }
}
