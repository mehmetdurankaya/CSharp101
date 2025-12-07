namespace Interface_example
{
  public class SmsLogger : ILogger
  {
    public void writeLog()
    {
      Console.WriteLine("Sms olarak yazar");
    }
  }
}
