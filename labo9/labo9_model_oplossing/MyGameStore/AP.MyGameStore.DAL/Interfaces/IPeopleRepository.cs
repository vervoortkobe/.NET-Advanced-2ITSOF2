using AP.MyGameStore.DAL.Model;

namespace AP.MyGameStore.DAL.Interfaces
{
    public interface IPeopleRepository : IGenericRepository<Person>
    {
        IEnumerable<Person> GetAll(string LastNameFilter = null, Gender? GenderFilter = null, string EmailFilter = null, Sort? sortBy = null);

        public enum Sort
        {
            ByLastName,
            ByBirthDate
        }

    }


}
