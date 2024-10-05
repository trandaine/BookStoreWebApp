using BookStore.MVC.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BookStore.MVC.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(a => a.FullName)
                .HasMaxLength(256)
                .IsRequired();
            builder.Property(a => a.Name)
                .HasMaxLength(100);
            builder.Property(a => a.Phone)
                .HasMaxLength(11);
            builder.Property(a => a.Email)
                .HasMaxLength(200);
            //builder.HasData(
            //    new Author
            //    {
            //        Id = Guid.NewGuid(),
            //        FullName = "Default",
            //        Name = "default",
            //        DateOfBirth = new System.DateTime(2021, 1, 1),
            //        Phone = "0123456789",
            //        Email = "test@gmali.com"
            //    });
        }
    }
}
