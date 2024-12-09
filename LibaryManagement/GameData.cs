public class GameData
{
    public string saveName { get; set; }
    public int days { get; set; }
    public int time {get; set; }

    List<Book> books {get; set;}
    List<Author> authors {get; set;}

    public GameData(string saveName)
    {
        this.saveName = saveName; 
        days = 0;
        time = 8;

        books = new List<Book>();
        authors = new List<Author>();




    }
}

