using AP.MyGameStore.BLL.Interfaces;
using AP.MyGameStore.DAL;
using AP.MyGameStore.DAL.Model;
using Microsoft.AspNetCore.Mvc;
using static AP.MyGameStore.BLL.Interfaces.IPeopleService;

namespace AP.MyGameStore.BLL.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly MyGameStoreContext context;

        public PeopleService(MyGameStoreContext context)
        {
            this.context = context;
        }

        public List<Person> GetAll([FromQuery] string LastNameFilter = null, Gender? GenderFilter = null, string EmailFilter = null, Sort? sortBy = null)
        {             //Starting to build query taking into account the parameters given
            //As long as we work with IQueryable the actual query is not performed yet (deferred execution)
            IQueryable<Person> query = context.People;         //using Method syntax
            //IQueryable<Person> query = from p in context.People select p;   //alternative: using Query syntax

            //filtering first, any parameter that is not null is used for filtering (where clauses can be chained)
            if (LastNameFilter != null)
                query = query.Where(p => p.LastName.Contains(LastNameFilter));
            //query = from p in query where p.LastName.Contains(LastNameFilter) select p;
            if (GenderFilter != null)
                query = query.Where(p => p.Gender == GenderFilter);
            //query = from p in query where p.Gender == GenderFilter select p;
            if (EmailFilter != null)
                query = query.Where(p => p.Email.Contains(EmailFilter));
            //query = from p in query where p.Email.Contains(EmailFilter) select p;

            switch (sortBy)
            {
                case Sort.ByBirthDate:
                    query = query.OrderBy(p => p.BirthDate);
                    //query = from p in query orderby p.BirthDate select p;
                    break;
                case Sort.ByLastName:
                    query = query.OrderBy(p => p.LastName);
                    //query = from p in query orderby p.LastName select p;
                    break;
                default:
                    break;
            }

            //Here (converting to list) is where the actual query is performed on the database !
            return Ok(query.ToList());
        }

        public Person Add(Person person)
        {
            context.People.Add(person);
            context.SaveChanges();
            return person;
        }

        public void Delete(int id)
        {
            var person = context;
            context.People.Remove(id);
            context.SaveChanges();
        }

        public Person GetById(int id)
        {
            var person = context.People.FirstOrDefault(p => p.Id == id);
            if (person == null) throw new KeyNotFoundException($"Person with id: {id} was not found.");
            return person;
        }

        public Person Update(Person person)
        {
            var currentPerson = GetById(person.Id);
            currentPerson.FirstName = person.FirstName;
            currentPerson.LastName = person.LastName;
            currentPerson.BirthDate = person.BirthDate;
            currentPerson.Gender = person.Gender;
            context.SaveChanges();
            return person;
        }
    }
}
