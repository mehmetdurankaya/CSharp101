
using ATMApp.Models;
using ATMApp.Services;

namespace ATMApp
{
    public class ATMService
    {
        private readonly AuthService _authService;
        private readonly TransactionService _transactionService;

        public ATMService(AuthService authService, TransactionService transactionService)
        {
            _authService = authService;
            _transactionService = transactionService;
        }

        public void ShowBalance(User user)
        {
            Console.WriteLine($"\nMevcut bakiye: {user.Balance:C}\n");
        }

        public void Deposit(User user)
        {
            Console.Write("Yatırılacak miktarı girin: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                user.Balance += amount;
                _transactionService.RecordTransaction(user.Username, "Yatirma", amount, "Nakit yatırma");
                Console.WriteLine($"Başarılı. Yeni bakiye: {user.Balance:C}");
            }
            else
            {
                Console.WriteLine("Geçersiz miktar.");
            }
        }

        public void Withdraw(User user)
        {
            Console.Write("Çekilecek miktarı girin: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                if (user.Balance >= amount)
                {
                    user.Balance -= amount;
                    _transactionService.RecordTransaction(user.Username, "Cekme", amount, "Nakit çekme");
                    Console.WriteLine($"Lütfen parayı alınız. Kalan bakiye: {user.Balance:C}");
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz miktar.");
            }
        }

        public void Payment(User user)
        {
            Console.Write("Ödeme açıklaması girin (örn: Elektrik Faturası): ");
            string desc = Console.ReadLine() ?? "";

            Console.Write("Ödenecek miktarı girin: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                if (user.Balance >= amount)
                {
                    user.Balance -= amount;
                    _transactionService.RecordTransaction(user.Username, "Odeme", amount, desc);
                    Console.WriteLine($"Ödeme tamamlandı. Kalan bakiye: {user.Balance:C}");
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye, ödeme gerçekleştirilemedi.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz miktar.");
            }
        }
    }
}
