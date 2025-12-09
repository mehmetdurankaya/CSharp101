namespace ATMApp.Models
{
    public class Transaction
    {
        public DateTime Timestamp { get; set; }
        public string Username { get; set; } = "";
        public string Type { get; set; } = "";
        public decimal Amount { get; set; }
        public string Description { get; set; } = "";

        public override string ToString()
        {
            return $"[{Timestamp:HH:mm:ss}] {Username} - {Type} - {Amount:C} - {Description}";
        }
    }

    public class FraudLog
    {
        public DateTime Timestamp { get; set; }
        public string UsernameAttempt { get; set; } = "";
        public string Reason { get; set; } = "";

        public override string ToString()
        {
            return $"[{Timestamp:HH:mm:ss}] {UsernameAttempt} - {Reason}";
        }
    }
}
