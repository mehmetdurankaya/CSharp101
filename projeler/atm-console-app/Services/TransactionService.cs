using ATMApp.Data;
using ATMApp.Models;

namespace ATMApp.Services
{
    public class TransactionService
    {
        public void RecordTransaction(string username, string type, decimal amount, string description = "")
        {
            var t = new Transaction
            {
                Timestamp = DateTime.Now,
                Username = username,
                Type = type,
                Amount = amount,
                Description = description
            };
            Database.Transactions.Add(t);
        }
    }
}
