using AP.MyGameStore.DAL.Model;
using Bogus;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Person = AP.MyGameStore.DAL.Model.Person;

namespace AP.MyGameStore.DAL.Seeding
{
    public static class PeopleSeeding
    {
        public static void Seed(this EntityTypeBuilder<Person> modelBuilder)
        {
            //install "Bogus" nuGet package 
            var fakePeople = new Faker<Person>();
            fakePeople.RuleFor(p => p.Id, f => -(f.IndexFaker + 1))
                .RuleFor(p => p.LastName, f => f.Person.LastName)
                .RuleFor(p => p.FirstName, f => f.Person.FirstName)
                .RuleFor(p => p.Email, f => f.Internet.Email())
                .RuleFor(p => p.Gender, f => (Gender)f.Person.Gender)
                .RuleFor(p => p.EmployerId, f => f.Random.Int(-100, -1));

            var fakePeopleList = fakePeople.GenerateBetween(100, 100);

            modelBuilder.HasData(fakePeopleList);

        }
    }
}
