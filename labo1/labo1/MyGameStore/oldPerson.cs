namespace MyGameStore
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
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Gender = gender;
            this.BirthPlace = birthPlace;
        }
    }
}
