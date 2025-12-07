namespace Interface_example
{
  public class DatabaseLogger : ILogger
  {
    public void writeLog()
    {
      Console.WriteLine("Database logları yazar");
    }
  }
}
