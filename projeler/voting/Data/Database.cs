using VotingApp.Models;

namespace VotingApp.Data
{
    public static class Database
    {
        public static List<User> Users = new List<User>();
        public static List<Category> Categories = new List<Category>();

        public static void SeedCategories()
        {
            Categories.Add(new Category("Film"));
            Categories.Add(new Category("Tech Stack"));
            Categories.Add(new Category("Spor"));
        }

        public static void AddUser(User user)
        {
            Users.Add(user);
        }
    }
}
