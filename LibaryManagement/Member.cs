public class Member : Person
{
    List<Transaction> transactions = new List<Transaction>();

    public Member(string name) : base(name)
    {
        
    }
}