using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGameStore.Model;

namespace MyGameStore.Seeding
{
    public static class People
    {
        public static void Seed(this EntityTypeBuilder<Person> builder)
        {
            builder.HasData(new Person
            {
                Id = -1,
                FirstName = "Thomas",
                LastName = "Mol",
                Email = "thomasmol078@gmail.com",
                BirthDate = new DateTime(),
                Employer = new Store
                {
                    Id = -2,
                    Name = "Albert Heijn",
                    City = "Antwerpen",
                    IsFranchiseStore = true,
                    Street = "Slachthuislaan",
                    Number = "57",
                    Zipcode = "2000",
                }
            });
        }
    }
}
