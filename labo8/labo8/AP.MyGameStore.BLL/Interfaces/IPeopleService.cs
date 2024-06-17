using AP.MyGameStore.DAL.Model;

namespace AP.MyGameStore.BLL.Interfaces
{
    public  interface IPeopleService
    {
        public List<Person> GetAll();
        public Person GetById(int id);
        public Person Add(Person person);
        public void Delete(int id);
        public void Update(Person person);

        public enum Sort
        {
            ByLastName,
            ByBirthDate
        }
    }
}
