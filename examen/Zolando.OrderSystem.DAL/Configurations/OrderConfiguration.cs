using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zolando.OrderSystem.DAL.Model;

namespace Zolando.OrderSystem.DAL.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("tblOrders", "Order")
                .HasKey(p => p.Id);
        }
    }
}
