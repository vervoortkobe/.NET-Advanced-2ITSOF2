using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.MyGameStore.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IPeopleRepository PeopleRepository { get; }
        IStoresRepository StoresRepository { get; }

        void Commit();
    }
}
