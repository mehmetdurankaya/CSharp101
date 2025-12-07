namespace Interface_example
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("**********");
        FileLogger fileLogger = new FileLogger();
        fileLogger.writeLog();
        Console.WriteLine("**********");
        DatabaseLogger databaseLogger = new DatabaseLogger();
        databaseLogger.writeLog();
        Console.WriteLine("**********");
        SmsLogger smsLogger = new SmsLogger();
        smsLogger.writeLog();
        Console.WriteLine("**********");

        LogManager logManager = new LogManager(new FileLogger());
        logManager.writeLog();


    }
  }
}
