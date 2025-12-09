namespace ATMApp.Models
{
    public class User
    {
        public string Username { get; }
        public string Password { get; } // Simplified: plain text (only for demo)
        public decimal Balance { get; set; }

        public User(string username, string password, decimal balance = 0m)
        {
            Username = username;
            Password = password;
            Balance = balance;
        }
    }
}
