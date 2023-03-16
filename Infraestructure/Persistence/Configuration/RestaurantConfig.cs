using Domain.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Persistence.Configuration
{
    public class RestaurantConfig : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.ToTable("Restaurants");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name)
                   .HasMaxLength(80)
                   .IsRequired();
            builder.Property(p => p.Email)
                 .HasMaxLength(100);
            builder.Property(p => p.PhoneNumber)
                  .HasMaxLength(9)
                   .IsRequired();
            builder.Property(p => p.Street)
                 .HasMaxLength(100)
                  .IsRequired();
            builder.Property(p => p.City)
                .HasMaxLength(50)
                 .IsRequired();
            builder.Property(p => p.Country)
                .HasMaxLength(50)
                 .IsRequired(); 
            builder.Property(p => p.PostalCode)
                 .HasMaxLength(50)
                 .IsRequired();
            builder.Property(p => p.CreatedBy)
                .HasMaxLength(30);
            builder.Property(p => p.LastModifiedBy)
               .HasMaxLength(30);
        }
    }
}
