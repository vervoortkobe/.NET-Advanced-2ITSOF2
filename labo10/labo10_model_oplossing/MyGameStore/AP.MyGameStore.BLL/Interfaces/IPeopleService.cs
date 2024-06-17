using AP.MyGameStore.DAL.Model;
using static AP.MyGameStore.DAL.Interfaces.IPeopleRepository;

namespace AP.MyGameStore.BLL.Interfaces
{
    public interface IPeopleService
    {
        public IEnumerable<Person> GetAll(string LastNameFilter = null, Gender? GenderFilter = null, string EmailFilter = null, Sort? sortBy = null);
        public Person GetById(int id);
        public Person Add(Person person);
        public void Delete(int id);
        public Person Update(Person person);
    }
}
