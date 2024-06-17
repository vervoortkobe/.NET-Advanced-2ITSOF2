using AP.MyGameStore.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGameStore.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("tblPeople", "Person")
                    .HasKey(p => p.Id);
            builder.HasIndex(p => p.Id)
                    .IsUnique();

            builder.Property(p => p.Id)
                   .HasColumnType("int");
            
            builder.Property(p => p.LastName)
                    .IsRequired()
                    .HasColumnType("nvarchar(70)");
            builder.Property(p => p.FirstName)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");
            builder.Property(p => p.Gender)
                    .HasColumnType("int");
            builder.Property(p => p.Email)
                    .HasColumnName("EmailAddress")
                    .HasColumnType("nvarchar(100)");
        }
    }
}
