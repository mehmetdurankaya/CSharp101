using VotingApp.Data;
using VotingApp.Models;

namespace VotingApp.Services
{
    public class UserService
    {
        public User GetUser(string username)
        {
            return Database.Users.FirstOrDefault(u => u.Username == username);
        }

        public User Register(string username)
        {
            var user = new User(username);
            Database.AddUser(user);
            return user;
        }
    }
}
