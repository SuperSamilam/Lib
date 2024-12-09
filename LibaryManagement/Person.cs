using System.IO;

public class Person{
    public string name;
    public string id;

    public Person(string name)
    {
        if (name == "")
        {
            string[] firstnames = File.ReadAllLines(@"firstnames.txt");
            string[] lastnames = File.ReadAllLines(@"lastnames.txt");
            name = firstnames[Gamehandler.rand.Next(0, firstnames.Length)] + " " + lastnames[Gamehandler.rand.Next(0, lastnames.Length)];
        }
        this.name = name;

        id = System.Guid.NewGuid().ToString();
    }
}