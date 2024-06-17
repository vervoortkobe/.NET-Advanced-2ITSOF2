using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Interfaces;
using AP.MyGameStore.DAL.Contexts;
using AP.MyGameStore.DAL.Model;
using Microsoft.EntityFrameworkCore;
using static AP.MyGameStore.BLL.Interfaces.IStoresService;

namespace AP.MyGameStore.BLL.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly GameStoreContext context;

        public PeopleService(GameStoreContext context)
        {
            this.context = context;
        }
        public Person Add(Person person)
        {
            var employer = context.Stores.Find(person.EmployerId);
            if (employer == null)
                throw new RelationNotFoundException("The specified employer does not exist");

            context.People.Add(person);
            context.SaveChanges();
            return person;
        }

        public void Delete(int id)
        {
            var person = context.People.FirstOrDefault(p => p.Id == id);
            if (person == null)
                throw new KeyNotFoundException("the person was not found");

            context.People.Remove(person);
            context.SaveChanges();
        }

        public IEnumerable<Person> GetAll(string LastNameFilter = null, Gender? GenderFilter = null, string EmailFilter = null, Sort? sortBy = null)
        {
            IQueryable<Person> query = context.People;

            if (LastNameFilter != null)
                query = query.Where(p => p.LastName.Contains(LastNameFilter));
            if (GenderFilter != null)
                query = query.Where(p => p.Gender == GenderFilter);
            if (EmailFilter != null)
                query = query.Where(p => p.Email.Contains(EmailFilter));

            switch (sortBy)
            {
                case Sort.ByLastName:
                    query = query.OrderBy(p => p.LastName);
                    break;
                case Sort.ByBirthDate:
                    query = query.OrderBy(p => p.BirthDate);
                    break;
                default:
                    break;
            }

            return query.ToList();
        }

        public enum Sort
        {
            ByLastName,
            ByBirthDate
        }

        public Person GetById(int id)
        {
            return context.People
                .Include(p => p.Employer)
                .Where(p => p.Id == id).FirstOrDefault();
        }

        public Person Update(Person person)
        {
            var existing = context.People.FirstOrDefault(p => p.Id == person.Id);
            if (existing == null)
                throw new KeyNotFoundException("the person was not found");

            var employer = context.Stores.Find(person.EmployerId);
            if (employer == null)
                throw new RelationNotFoundException("The specified employer does not exist");

            existing.FirstName = person.FirstName;
            existing.LastName = person.LastName;
            existing.BirthDate = person.BirthDate;
            existing.Gender = person.Gender;
            existing.EmployerId = person.EmployerId;
            context.SaveChanges();
            return existing;
        }
    }
}
