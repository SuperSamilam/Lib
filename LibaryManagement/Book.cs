public class Book
{
    public string title;
    public Author author;
    public Genre genre;

    public int available = 0;
    public int lended = 0;
    public int unSorted = 0;

    public bool CheckBookavailabilty()
    {
        if (available > 0)
        {
            return true;
        }
        return false;
    }

    public void ReturnBook()
    {
        unSorted++;
        lended--;
    }

    public void SortBook()
    {
        if (unSorted > 0)
        {
            unSorted--;
            available++;
        }
    }

}

public enum Genre { Fantasy, Horror, Mystery, Romance, ScFi, Comedy, Crime }

