public class Gamehandler
{
    GameData data;

    public Gamehandler(GameData data)
    {
        this.data = data;
        Main();
    }

    void Main()
    {
        Console.Clear();

        while (true)
        {
            Console.WriteLine("Hi Manager! What should we do today");
            Console.WriteLine("See stats");
            Console.WriteLine("Manage Emplooyes");
            Console.WriteLine("Upgrade Building");
            Console.WriteLine("Manage Books");
            Console.WriteLine("Manage Reception");
            Console.WriteLine("Sort Books");
            Console.WriteLine("Go home for the day");
        }
    }

    void SeeStats()
    {
        Console.Clear();
        //Just print all stats
    }

    void ManageEmplooyes()
    {
        Console.Clear();

        while (true)
        {
            Console.WriteLine("1: Hire new emplooyes");
            Console.WriteLine("2: Fire emplooyes");
            Console.WriteLine("3: Back");
        }
    }

    void ManageBooks()
    {
        Console.Clear();

        while (true)
        {
            Console.WriteLine("1: Buy Books");
            Console.WriteLine("2: Sell Books");
            Console.WriteLine("3: Back");
        }
    }

    void WorkRecpetion() //Calculate the fee or approve books to be lended out or make new members
    {
        Console.Clear();

        while (true)
        {
            Console.WriteLine("1: Buy Books");
            Console.WriteLine("2: Sell Books");
            Console.WriteLine("3: Back");
        }
    }

    void SortBooks() //Get a book thats in the unsorted list point to right genre
    {
        
    }


}

