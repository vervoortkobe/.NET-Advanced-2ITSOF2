using AP.MyGameStore.DAL.Contexts;
using AP.MyGameStore.DAL.Interfaces;
using AP.MyGameStore.DAL.Model;
using Microsoft.EntityFrameworkCore;
using static AP.MyGameStore.DAL.Interfaces.IPeopleRepository;

namespace AP.MyGameStore.DAL.Repositories
{
    public class PeopleRepository : GenericRepository<Person>, IPeopleRepository
    {

        public PeopleRepository(GameStoreContext context): base(context)
        {
        }

        public IEnumerable<Person> GetAll(string LastNameFilter = null, Gender? GenderFilter = null, string EmailFilter = null, IPeopleRepository.Sort? sortBy = null)
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

        public override Person? GetById(int id)
        {
            return context.People
                    .Include(p => p.Employer)
                    .FirstOrDefault(p => p.Id == id);
        }
    }
}
