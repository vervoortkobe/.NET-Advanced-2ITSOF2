using AP.MyGameStore.DAL.Contexts;
using AP.MyGameStore.DAL.Interfaces;

namespace AP.MyGameStore.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>  where T:class 
    {
        protected readonly GameStoreContext context;

        public GenericRepository(GameStoreContext context)
        {
            this.context = context;
        }
        public T Create(T item)
        {
            context.Add<T>(item);
            return item;
        }

        public void Delete(T item)
        {
            context.Remove<T>(item);
        }

      

        public virtual T? GetById(int id)
        {
            return context.Find<T>(id);
        }

        public void Update(T item)
        {
            context.Update<T>(item);
        }
    }
}
