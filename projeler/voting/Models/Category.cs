namespace VotingApp.Models
{
    public class Category
    {
        public string Name { get; set; }
        public int VoteCount { get; set; }

        public Category(string name)
        {
            Name = name;
            VoteCount = 0;
        }

        public void AddVote()
        {
            VoteCount++;
        }
    }
}
