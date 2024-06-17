using AP.MyGameStore.DAL.Model;

namespace AP.MyGameStore.MVCApp.Models
{
    public class AddNewPersonModel
    {
        public Person Person{ get; set; }

        public IEnumerable<Store> Employers { get; set; }
    }
}
