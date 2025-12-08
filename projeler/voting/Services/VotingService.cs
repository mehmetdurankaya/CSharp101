using VotingApp.Data;
using VotingApp.Models;

namespace VotingApp.Services
{
    public class VotingService
    {
        public void Vote(User user)
        {
            if (user.HasVoted)
            {
                Console.WriteLine("Bu kullanıcı zaten oy kullanmış.");
                return;
            }

            Console.WriteLine("Oylama kategorileri:\n");

            for (int i = 0; i < Database.Categories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Database.Categories[i].Name}");
            }

            Console.Write("\nOy vermek istediğiniz kategori numarasını girin: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice < 1 || choice > Database.Categories.Count)
            {
                Console.WriteLine("Geçersiz seçim!");
                return;
            }

            Database.Categories[choice - 1].AddVote();
            user.HasVoted = true;

            Console.WriteLine("\nOyunuz başarıyla kaydedildi!\n");
        }

        public void ShowResults()
        {
            Console.WriteLine("\n=== OYLAMA SONUÇLARI ===");
            int totalVotes = Database.Categories.Sum(c => c.VoteCount);

            if (totalVotes == 0)
            {
                Console.WriteLine("Henüz hiç oy kullanılmadı.");
                return;
            }

            foreach (var category in Database.Categories)
            {
                double percentage = (double)category.VoteCount / totalVotes * 100;
                Console.WriteLine($"{category.Name}: {category.VoteCount} oy (%{percentage:F2})");
            }

            Console.WriteLine($"\nToplam Oy: {totalVotes}");
            Console.WriteLine("==========================");
        }
    }
}
