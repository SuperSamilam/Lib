using System.Text.Json;

public static class SaveSystem
{
    public static void WriteData(GameData data)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(data.saveName))
            {
                var opt = new JsonSerializerOptions() { WriteIndented = true };
                string strJson = JsonSerializer.Serialize<GameData>(data, opt);
                writer.Write(strJson);
            }
        }
        catch (Exception exp)
        {
            Console.Write(exp.Message);
        }
    }

    public static GameData loadData(string saveName){
        GameData data = JsonSerializer.Deserialize<GameData>(File.ReadAllText(saveName));
        return data;
    }
}