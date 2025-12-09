using ATMApp.Models;
using System.Globalization;

namespace ATMApp.Services
{
    public class FileLogger
    {
        // Writes EOD file named EOD_ddMMyyyy.txt in current directory
        public void WriteEODReport(List<Transaction> transactions, List<FraudLog> frauds)
        {
            var today = DateTime.Now;
            var filename = $"EOD_{today:ddMMyyyy}.txt";

            var lines = new List<string>();
            lines.Add("=== END OF DAY REPORT ===");
            lines.Add($"Date: {today:dd-MM-yyyy HH:mm:ss}");
            lines.Add("");
            lines.Add("Transactions:");
            lines.Add("----------------------");
            if (transactions.Count == 0)
            {
                lines.Add("No transactions today.");
            }
            else
            {
                foreach (var t in transactions)
                {
                    lines.Add(t.ToString());
                }
            }
            lines.Add("");
            lines.Add("Fraud / Failed Login Attempts:");
            lines.Add("-------------------------------");
            if (frauds.Count == 0)
            {
                lines.Add("No fraud attempts recorded.");
            }
            else
            {
                foreach (var f in frauds)
                {
                    lines.Add(f.ToString());
                }
            }

            // Also summary totals
            lines.Add("");
            lines.Add("Summary:");
            var totalTx = transactions.Count;
            var totalAmount = transactions.Sum(t => t.Amount);
            lines.Add($"Total transactions: {totalTx}");
            lines.Add($"Total amount transacted: {totalAmount.ToString("C", CultureInfo.CurrentCulture)}");

            File.WriteAllLines(filename, lines);
        }
    }
}
