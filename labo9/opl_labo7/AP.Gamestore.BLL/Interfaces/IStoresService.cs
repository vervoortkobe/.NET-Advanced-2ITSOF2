using AP.MyGameStore.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.MyGameStore.BLL.Interfaces
{
    public interface IStoresService
    {
        public IEnumerable<Store> GetAll(int pageNr, int pageSize, sortBy orderBy, string city, string zipCode);
        public Store GetById(int id);
        public Store Add(Store store);
        public void Delete(int id);
        public Store Update(Store store);
        public IEnumerable<Person> GetEmployees(int storeId);
        public void DeleteEmployees(int storeId);

        public enum sortBy
        {
            cityAscending,
            cityDescending,
            zipCodeAscending,
            zipcodeDescending
        }
    }

    
}
