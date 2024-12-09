public class Gamehandler
{
    GameData data;
    public static Random rand;

    public Gamehandler(GameData data)
    {
        this.data = data;
        rand = new Random();
        Main();
    }

    void Main()
    {
        Console.Clear();

        while (true)
        {
            Console.WriteLine("Hi Manager! What should we do today");
            Console.WriteLine("Time: " + data.time + ":00, the day ends at 16");
            Console.WriteLine("1: See stats");
            Console.WriteLine("2: Manage Emplooyes");
            Console.WriteLine("3: Upgrade Building");
            Console.WriteLine("4: Manage Books");
            Console.WriteLine("5: Manage Reception");
            Console.WriteLine("6: Sort Books");
            Console.WriteLine("7: Advance 2 hours");
            Console.WriteLine("8: Go home for the day");
            Console.WriteLine();
            Console.WriteLine("9: Go back to main menu");

            string input = Console.ReadLine() ?? "";

            if (input == "1")
            {
                Console.WriteLine("NOT IMPLIMENTED YET");
            }
            else if (input == "2")
            {
                Console.WriteLine("NOT IMPLIMENTED YET");
            }
            else if (input == "3")
            {
                Console.WriteLine("NOT IMPLIMENTED YET");
            }
            else if (input == "4")
            {
                Console.WriteLine("NOT IMPLIMENTED YET");
            }
            else if (input == "5")
            {
                Console.WriteLine("NOT IMPLIMENTED YET");
            }
            else if (input == "6")
            {
                Console.WriteLine("NOT IMPLIMENTED YET");
            }
            else if (input == "7")
            {
                Console.WriteLine("NOT IMPLIMENTED YET");
            }
            else if (input == "8")
            {
                Console.WriteLine("NOT IMPLIMENTED YET");
            }
            else if (input == "9")
            {
                Console.WriteLine("NOT IMPLIMENTED YET");
            }
        }
    }

    void SeeStats()
    {
        Console.Clear();
        //Day : Time
        //Books in library
        //Lended books
        //Staff amount
        //Stars
        //Building size
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

    void AdvanceTime(int hours)
    {
        for (int i = 0; i < hours; i++)
        {
            data.time++;
            if (data.time == 16)
            {
                AdvanceDay();
                return;
            }

            //Let all emplooyes sort as many books as they can
            //Let cleaners clean as much as they can
            //Let receptionist handle as many transactions as they can


        }
    }

    void AdvanceDay()
    {
        data.days++;
        //More day advance stuff
    }


}

