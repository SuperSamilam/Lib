public class Transaction
{
    public Book book;
    public int returnDate;
    static int lateFee;

    public int CalculateLateFee(int currentDay)
    {
        if (returnDate >= currentDay)
            return 0;
        
        return (currentDay-returnDate) * lateFee;
    }

}