public class Staff : Person
{
    public Role role;

    public Staff(string name) : base(name)
    {

    }
}





public enum Role { Cleaner, Sorter, Receptionist }