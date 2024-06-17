using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyGameStore.DAL.Model
{
    [Table("tblStores", Schema = "Store")]
    public class Store
    {
        //[Key]
        public int Id { get; set; }
        //[Required, MaxLength(30)]
        public string Name { get; set; }
        //[Required, MaxLength(60)]
        public string Street { get; set; }
        //[Required, MaxLength(5)]
        public string Number { get; set; }
        // [MaxLength(2)]
        public string Addition { get; set; }
        //[Required, MaxLength(6)]
        public string Zipcode { get; set; }
        //[Column("Place"), MaxLength(60)]
        public string City { get; set; }
        public bool IsFranchiseStore { get; set; }
        public List<Person> Employees { get; set; }
    }
}
