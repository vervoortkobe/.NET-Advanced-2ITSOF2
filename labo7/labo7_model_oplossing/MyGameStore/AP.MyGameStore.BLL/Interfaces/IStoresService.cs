using AP.MyGameStore.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AP.MyGameStore.BLL.Services.StoresService;

namespace AP.MyGameStore.BLL.Interfaces
{
    public interface IStoresService
    {
        public PagedResult<Store> GetAll(string? nameFilter = null, SortFilter? filter = null, int pageNumber = 1, int pageLength = 10);
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
