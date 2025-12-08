namespace VotingApp.Models
{
    public class User
    {
        public string Username { get; set; }
        public bool HasVoted { get; set; } = false;

        public User(string username)
        {
            Username = username;
        }
    }
}
