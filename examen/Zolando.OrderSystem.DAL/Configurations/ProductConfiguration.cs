using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zolando.OrderSystem.DAL.Model;

namespace Zolando.OrderSystem.DAL.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("tblProducts", "Product")
                .HasKey(p => p.Id);


            builder.Property(p => p.Name)
                //.IsUnique()
                .HasMaxLength(60)
                .IsRequired();
        }
    }
}
