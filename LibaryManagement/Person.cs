public class Person{
    public string name;
    public string id;

    public Person(string name)
    {
        if (name == "")
        {
            string[] firstnames = File.ReadAllLines(SaveSystem.gamePath + "/" + "firstnames.txt");
            string[] lastnames = File.ReadAllLines(SaveSystem.gamePath + "/" + "lastnames.txt");
            //Generate random name
            this.name = firstnames[Gamehandler.rand.Next(0, firstnames.Length)] + " " + lastnames[Gamehandler.rand.Next(0, lastnames.Length)];
        }
        else
        {
            this.name = name;    
        }

        id = new System.Guid().ToString();

        Console.WriteLine(name + " " + id);
    }
}