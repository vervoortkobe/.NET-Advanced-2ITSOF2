using AP.MyGameStore.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AP.MyGameStore.DAL.Configurations
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.ToTable("tblStores", "Store")
                .HasIndex(s => s.Name)
                .IsUnique();

            builder.Property(s => s.Name).HasMaxLength(30);
            //....
        }
    }
}
