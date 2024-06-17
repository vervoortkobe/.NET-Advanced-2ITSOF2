using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Interfaces;
using AP.MyGameStore.DAL.Interfaces;
using AP.MyGameStore.DAL.Model;
using System.Text.RegularExpressions;
using static AP.MyGameStore.DAL.Interfaces.IPeopleRepository;

namespace AP.MyGameStore.BLL.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IUnitOfWork uow;

        public PeopleService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public Person Add(Person person)
        {
            if (DateTime.Now.Year - person.BirthDate.Year > 67) throw new ValidationException("Person age cannot be > 67 years", ValidationException.ErrorCode.AgeGreaterThan67);
            if (DateTime.Now.Year - person.BirthDate.Year < 16) throw new ValidationException("Person age cannot be < 16 years", ValidationException.ErrorCode.AgeSmallerThan16);
            if (!person.Email.Contains('@') || !person.Email.Contains('.')) throw new ValidationException("Email address invalid", ValidationException.ErrorCode.EmailInvalid);

            if (person.EmployerId.HasValue)
            {
                var employer = uow.StoresRepository.GetById(person.EmployerId.Value);
                if (employer == null)
                    throw new RelationNotFoundException("The specified employer does not exist");
            }
            uow.PeopleRepository.Create(person);
            uow.Commit();
            return person;
        }

        public void Delete(int id)
        {
            var person = uow.PeopleRepository.GetById(id);
            if (person == null)
                throw new KeyNotFoundException("the person was not found");

            uow.PeopleRepository.Delete(person);
            uow.Commit();
        }

        public IEnumerable<Person> GetAll(string LastNameFilter = null, Gender? GenderFilter = null, string EmailFilter = null, Sort? sortBy = null)
        {
            return uow.PeopleRepository.GetAll(LastNameFilter, GenderFilter, EmailFilter, sortBy);
        }

       
        public Person GetById(int id)
        {
            return uow.PeopleRepository.GetById(id); 
        }

        public Person Update(Person person)
        {
            var existing = uow.PeopleRepository.GetById(person.Id);
            if (existing == null)
                throw new KeyNotFoundException("the person was not found");

            //Control birthdate en email

            if (person.EmployerId.HasValue)
            {
                var employer = uow.StoresRepository.GetById(person.EmployerId.Value);
                if (employer == null)
                    throw new RelationNotFoundException("The specified employer does not exist");
            }
            existing.FirstName = person.FirstName;
            existing.LastName = person.LastName;
            existing.BirthDate = person.BirthDate;
            existing.Gender = person.Gender;
            existing.EmployerId = person.EmployerId;
            uow.Commit();
            return existing;
        }
    }
}
