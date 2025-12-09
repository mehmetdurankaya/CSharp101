using ATMApp.Data;
using ATMApp.Services;

namespace ATMApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Load data (users from file, seed if missing)
            Database.Initialize();

            var authService = new AuthService();
            var transactionService = new TransactionService();
            var atmService = new ATMService(authService, transactionService);
            var logger = new FileLogger();

            Console.WriteLine("=== WELCOME TO SIMPLE ATM ===\n");

            // User login / register flow
            var user = authService.AuthenticateOrRegister();

            if (user == null)
            {
                Console.WriteLine("Giriş yapılmadı. Uygulamadan çıkılıyor.");
                return;
            }

            // Main ATM loop
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n--- Menü ---");
                Console.WriteLine("1. Bakiye Görüntüle");
                Console.WriteLine("2. Para Yatırma");
                Console.WriteLine("3. Para Çekme");
                Console.WriteLine("4. Ödeme Yapma");
                Console.WriteLine("5. Gün Sonu (EOD) Al");
                Console.WriteLine("6. Çıkış");
                Console.Write("Seçiminiz: ");

                var sel = Console.ReadLine();
                switch (sel)
                {
                    case "1":
                        atmService.ShowBalance(user);
                        break;
                    case "2":
                        atmService.Deposit(user);
                        break;
                    case "3":
                        atmService.Withdraw(user);
                        break;
                    case "4":
                        atmService.Payment(user);
                        break;
                    case "5":
                        // Create EOD report and write to file
                        Console.WriteLine("Gün sonu alınıyor...");
                        logger.WriteEODReport(Database.Transactions, Database.FraudLogs);
                        Console.WriteLine("Gün sonu başarılı. Dosyaya yazıldı.");
                        break;
                    case "6":
                        exit = true;
                        Console.WriteLine("Çıkış yapılıyor. İyi günler!");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek, tekrar deneyin.");
                        break;
                }
            }

            // On exit, persist users (balances etc.)
            Database.SaveUsersToFile();
        }
    }
}
