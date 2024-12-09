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

        Author GregOlives = new Author("Greg Olives", -1, -1);
        Author JuliaKayRice = new Author("Julia Kay Rice", -1, -1);
        Author MariaSpaghetti = new Author("Maria Spaghetti", -1, -1);
        Author WillShakePear = new Author("Will Shakepear", -1, -1);
        Author RayBradBerry = new Author("Ray Bradberry", -1, -1);
    }
}

