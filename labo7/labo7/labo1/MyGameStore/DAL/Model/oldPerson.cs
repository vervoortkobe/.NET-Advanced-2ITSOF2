namespace MyGameStore.DAL.Model
{
    public class oldPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string BirthPlace { get; set; }

        public oldPerson(int id, string firstName, string lastName, string email, string gender, string birthPlace)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            BirthPlace = birthPlace;
        }
    }
}
