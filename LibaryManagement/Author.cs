public class Author : Person
{
    public List<Book> booksWritten = new List<Book>();
    public int bookWritingSpeed;
    public double writingQuality;

    public Author(string name, int bookWritingSpeed, float writingQuality) : base(name)
    {
        if (bookWritingSpeed == -1)
        {
            this.bookWritingSpeed = (int)Gamehandler.rand.Next(20,50);
            this.writingQuality = Gamehandler.rand.NextDouble();
        }
        else
        {
            this.bookWritingSpeed = bookWritingSpeed;
            this.writingQuality = writingQuality;
        }
    }
}

