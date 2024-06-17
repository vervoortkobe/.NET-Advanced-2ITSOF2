using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace MyGameStore.DAL.Model
{
    [Table("tblPeople", Schema = "Person")]
    public class Person
    {
        //[Key]
        public int Id { get; set; }
        //[Required, MaxLength(50)]
        public string FirstName { get; set; }
        //[Required, MaxLength(70)]
        public string LastName { get; set; }
        //[Column("EmailAdress"), MaxLength(100)]
        public string Email { get; set; }
        public int Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string MobileNr { get; set; }
        public Store Employer { get; set; }
    }
}
