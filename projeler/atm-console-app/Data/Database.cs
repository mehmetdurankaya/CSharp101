using System.Globalization;
using ATMApp.Models;

namespace ATMApp.Data
{
    public static class Database
    {
        // In-memory collections
        public static List<User> Users { get; private set; } = new();
        public static List<Transaction> Transactions { get; private set; } = new();
        public static List<FraudLog> FraudLogs { get; private set; } = new();

        private static readonly string UsersFile = "users.txt"; // username;password;balance

        public static void Initialize()
        {
            // Load users from file if exists, otherwise seed defaults and create file.
            if (File.Exists(UsersFile))
            {
                LoadUsersFromFile();
            }
            else
            {
                SeedDefaultUsers();
                SaveUsersToFile();
            }
        }

        private static void SeedDefaultUsers()
        {
            Users.Add(new User("turan", "1234", 5000m));
            Users.Add(new User("ali", "abcd", 2500m));
            Users.Add(new User("ayse", "pw", 10000m));
        }

        public static void LoadUsersFromFile()
        {
            Users.Clear();
            var lines = File.ReadAllLines(UsersFile);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                // expected format: username;password;balance
                var parts = line.Split(';');
                if (parts.Length >= 3 && decimal.TryParse(parts[2], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal bal))
                {
                    Users.Add(new User(parts[0], parts[1], bal));
                }
            }
        }

        public static void SaveUsersToFile()
        {
            var lines = Users.Select(u => $"{u.Username};{u.Password};{u.Balance.ToString(CultureInfo.InvariantCulture)}");
            File.WriteAllLines(UsersFile, lines);
        }
    }
}
