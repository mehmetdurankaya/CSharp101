using ATMApp.Data;
using ATMApp.Models;
using System;

namespace ATMApp.Services
{
    public class AuthService
    {
        private const int MaxPasswordAttempts = 3;

        public User? AuthenticateOrRegister()
        {
            Console.Write("Kullanıcı adınızı girin: ");
            string username = Console.ReadLine()?.Trim() ?? "";

            var user = Database.Users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            if (user == null)
            {
                Console.WriteLine("Kullanıcı bulunamadı. Kayıt oluşturmak ister misiniz? (e/h)");
                var ans = Console.ReadLine();
                if (ans?.ToLower() == "e")
                {
                    return RegisterUser(username);
                }
                else
                {
                    return null;
                }
            }

            // Password check
            bool isAuthenticated = false;
            for (int attempt = 1; attempt <= MaxPasswordAttempts; attempt++)
            {
                Console.Write("Şifrenizi girin: ");
                var pw = Console.ReadLine() ?? "";

                if (pw == user.Password)
                {
                    Console.WriteLine($"Hoşgeldiniz {user.Username}!");
                    isAuthenticated = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı şifre.");
                    Database.FraudLogs.Add(new FraudLog
                    {
                        Timestamp = DateTime.Now,
                        UsernameAttempt = username,
                        Reason = $"Hatalı şifre denemesi ({attempt})"
                    });
                }
            }
            if (!isAuthenticated)
            {
                Console.WriteLine("Çok fazla hatalı deneme. Giriş reddedildi.");
                return null;
            }
            return user;
        }



        private User RegisterUser(string username)
        {
            Console.Write("Yeni şifre belirleyin: ");
            string pw = Console.ReadLine() ?? "";
            decimal initialBalance = 0m;
            while (true)
            {
                Console.Write("İlk bakiye (isteğe bağlı, boş bırakmak 0 kabul edilir): ");
                var balInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(balInput))
                {
                    initialBalance = 0m;
                    break;
                }
                if (decimal.TryParse(balInput, out var val))
                {
                    initialBalance = val;
                    break;
                }
                Console.WriteLine("Geçersiz bakiye, tekrar deneyin.");
            }

            var newUser = new User(username, pw, initialBalance);
            Database.Users.Add(newUser);
            Database.SaveUsersToFile(); // persist immediately
            Console.WriteLine("Kayıt başarılı!");
            return newUser;
        }
    }
}
