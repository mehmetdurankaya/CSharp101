namespace Interface_example
{
  public class FileLogger : ILogger
  {
    public void writeLog()
    {
      Console.WriteLine("Dosyaya log yazar");
    }
  }
}
