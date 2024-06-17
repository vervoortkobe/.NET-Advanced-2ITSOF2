using AP.MyGameStore.DAL.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AP.MyGameStore.DAL.Seeding
{
    public static class PeopleSeeding
    {
        public static void Seed(this EntityTypeBuilder<Person> modelBuilder)
        {
            modelBuilder.HasData(
                new Person()
                {
                    Id = -1,
                    FirstName = "Bert",
                    LastName = "Bibber",
                    BirthDate = new DateTime(),
                    Email = "bert@bibber.com",
                    Gender = Gender.Male,
                    EmployerId = 1
                }
            );
        }
    }
}
