using VotingApp.Data;
using VotingApp.Services;

namespace VotingApp
{
  class Program
    {
        static void Main(string[] args)
        {
            Database.SeedCategories();

            var userService = new UserService();
            var votingService = new VotingService();

            Console.WriteLine("=== VOTING APPLICATION ===\n");

            // Kullanıcı doğrulama
            Console.Write("Kullanıcı adınızı girin: ");
            string username = Console.ReadLine();

            var user = userService.GetUser(username);

            if (user == null)
            {
                Console.WriteLine("Kullanıcı bulunamadı. Kayıt oluşturuluyor...");
                user = userService.Register(username);
                Console.WriteLine("Kayıt başarılı!\n");
            }
            else
            {
                Console.WriteLine("Tekrar hoş geldin, " + user.Username + "!\n");
            }

            // Oy verme
            votingService.Vote(user);

            // Sonuçları göster
            votingService.ShowResults();
        }
    }
}
