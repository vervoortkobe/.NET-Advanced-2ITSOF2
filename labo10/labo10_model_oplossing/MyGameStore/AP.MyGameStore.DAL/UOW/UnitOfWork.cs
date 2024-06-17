using AP.MyGameStore.DAL.Contexts;
using AP.MyGameStore.DAL.Interfaces;

namespace AP.MyGameStore.DAL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GameStoreContext context;

        public UnitOfWork(GameStoreContext context, 
                          IPeopleRepository peopleRepository, 
                          IStoresRepository storesRepository)
        {
            this.context = context;
            this.PeopleRepository = peopleRepository;
            this.StoresRepository = storesRepository;
        }
        public IPeopleRepository PeopleRepository { get; private set; }
        public IStoresRepository StoresRepository { get; private set; }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
