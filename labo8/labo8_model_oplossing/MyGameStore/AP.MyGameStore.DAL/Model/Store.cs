using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Text.Json.Serialization;

namespace AP.MyGameStore.DAL.Model
{
    public class Store
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Street { get; set; }
        //[Column("Number", TypeName = "nvarchar(5)")]
        //[Required]
        public string Number { get; set; }
        //[Column("Addition", TypeName = "nvarchar(2)")]
        public string Addition { get; set; }
        //[Column("ZipCode", TypeName = "nvarchar(6)")]
        //[Required]
        public string Zipcode { get; set; }
        //[Column("Place", TypeName = "nvarchar(60)")]
        public string City { get; set; }

        //[Column("IsFranchiseStore", TypeName = "bit")]
        public bool IsFranchiseStore { get; set; }

        [JsonIgnore]
        public List<Person>? Employees { get; set; }
    }
}
