namespace DL
{
    //POCO -> Plain Old CLR Objects
    public class Employee 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public Employee() // Constructor -> parameterless
        {
            FirstName = "Steve";
            LastName = "Jobs";
            Id = "001";
        }
        public Employee(string firstname, string lastname, string id)// parameterised
        {
            FirstName = firstname;
            LastName = lastname;
            Id = id;
        }
    }
}