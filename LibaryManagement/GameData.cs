public class GameData
{
    public string saveName { get; set; }
    public int days { get; set; }


    public GameData(string saveName)
    {
        this.saveName = saveName; 
        days = 0;
    }
}