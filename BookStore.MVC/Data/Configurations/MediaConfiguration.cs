using BookStore.MVC.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.MVC.Data.Configurations
{
    public class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.Property(m => m.Name)
                .HasMaxLength(256)
                .IsRequired();
            builder.Property(m => m.Alias)
                .HasMaxLength(1000);
            builder.Property(m => m.FileName)
                .HasMaxLength(1000)
                .IsRequired();
            builder.Property(m => m.Extension)
                .HasMaxLength(10)
                .IsRequired();
            builder.HasData(
                new Media
                {
                    Id = new System.Guid("f5b3f9c7-7b3d-4b0b-9b3e-2e6d3b3b9e1d"),
                    Name = "Default",
                    Alias = "default",
                    FileName = "default.jpg",
                    Extension = ".jpg",
                    Position = 1
                });
        }
    }
}
