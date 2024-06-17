using System.Text.Json.Serialization;

namespace AP.MyGameStore.DAL.Model
{
    public enum Gender
    {
        Female,
        Male
    }
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string? MobilePhone { get; set; }

        public int? EmployerId { get; set; }

        //[JsonIgnore]
        public Store? Employer { get; set; }

    }
}
