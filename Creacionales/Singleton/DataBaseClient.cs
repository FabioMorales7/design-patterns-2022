public class DataBaseConsumer : IConsumer
{
    // TODO implementa el patron de diseño singleton
    public void runClient()
    {

        Console.WriteLine("Ejecución database service.");

        DatabaseService databaseService = new DatabaseService();

        List<string> scores = databaseService.getScoreList();

        foreach (var it in scores)
        {
            Console.WriteLine(it);
        }
        
    }
}