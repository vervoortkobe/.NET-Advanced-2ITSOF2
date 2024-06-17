using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Interfaces;
using AP.MyGameStore.DAL.Contexts;
using AP.MyGameStore.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.MyGameStore.BLL.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly MyGameStoreContext context;

        public PeopleService(MyGameStoreContext context)
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

        public IEnumerable<Person> GetAll(int pageNr, int pageSize)
        {
            return context.People.Skip((pageNr - 1) * pageSize).Take(pageSize);
        }

        public Person GetById(int id)
        {
            return context.People.FirstOrDefault(p => p.Id == id);
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
