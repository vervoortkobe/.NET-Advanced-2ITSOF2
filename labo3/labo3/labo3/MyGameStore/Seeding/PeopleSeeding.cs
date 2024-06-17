using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGameStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.Seeding
{
    public static class PeopleSeeding
    {
        public static void Seed(this EntityTypeBuilder<Person> modelBuilder)
        {
            modelBuilder.HasData(
                new Person()
                {
                    Id = -1,
                    FirstName = "Jan",
                    LastName = "Janssens",
                    BirthDate = new DateTime(),
                    Email = "a@b.com",
                    Gender = Gender.Male,
                    EmployerId = -1
                }
            );
        }
    }
}
