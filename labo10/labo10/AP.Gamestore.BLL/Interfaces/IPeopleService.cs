using AP.MyGameStore.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.MyGameStore.BLL.Interfaces
{
    public interface IPeopleService
    {
        public IEnumerable<Person> GetAll(int pageNr, int pageSize);
        public Person GetById(int id);
        public Person Add(Person person);
        public void Delete(int id);
        public Person Update(Person person);
    }
}
