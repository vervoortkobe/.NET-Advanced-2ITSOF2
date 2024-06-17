using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGameStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.Configuration
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.ToTable("tblStores", "Store")
                    .HasKey(p => p.Id);
            builder.HasIndex(p => p.Name)
                    .IsUnique();

            builder.Property(p => p.Id)
                   .HasColumnType("int");

            builder.Property(p => p.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(30)");
            builder.Property(p => p.Street)
                    .IsRequired()
                    .HasColumnType("nvarchar(60)");
            builder.Property(p => p.Number)
                    .IsRequired()
                    .HasColumnType("nvarchar(5)");
            builder.Property(p => p.Addition)
                    .HasColumnType("nvarchar(2)");
            builder.Property(p => p.Zipcode)
                    .IsRequired()
                    .HasColumnType("nvarchar(6)");
            builder.Property(p => p.City)
                .HasColumnName("Place")
                .HasColumnType("nvarchar(60)");
            builder.Property(p => p.IsFranchiseStore)
                .HasColumnType("bit");

            builder.HasMany(s => s.Employees).WithOne(p => p.Employer);
        }
    }
}
