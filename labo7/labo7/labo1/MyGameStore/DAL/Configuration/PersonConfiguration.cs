using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyGameStore.DAL.Model;

namespace MyGameStore.DAL.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("tblPeople", "Person").HasKey(p => p.Id);

            builder.HasOne(p => p.Employer).WithMany(s => s.Employees);

            builder.HasIndex(p => p.Email).IsUnique();

            builder.Property(p => p.FirstName).HasMaxLength(50).IsRequired();

            builder.Property(p => p.LastName).HasMaxLength(70).IsRequired();

            builder.Property(p => p.Email).HasMaxLength(100).HasColumnName("EmailAddress");
        }
    }
}
