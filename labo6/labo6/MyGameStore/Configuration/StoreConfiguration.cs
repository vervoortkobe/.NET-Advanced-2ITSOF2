using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyGameStore.Model;

namespace MyGameStore.Configuration
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.ToTable("tblStores", "Store").HasKey(s => s.Id);

            builder.HasMany(s => s.Employees).WithOne(p => p.Employer);

            builder.HasIndex(s => s.Name).IsUnique();

            builder.Property(s => s.Name).HasMaxLength(30);

            builder.Property(s => s.Street).HasMaxLength(60).IsRequired();

            builder.Property(s => s.Number).HasMaxLength(5).IsRequired();

            builder.Property(s => s.Addition).HasMaxLength(2);

            builder.Property(s => s.Zipcode).HasMaxLength(6).IsRequired();

            builder.Property(s => s.City).HasMaxLength(60).HasColumnName("Place");
        }
    }
}
