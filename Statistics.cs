using System.Collections.Generic;
using System.Linq;

public class Statistics
{
    public Dictionary<string, decimal> Build(
        List<Transaction> transactions)
    {
        return transactions
            .GroupBy(t => t.Category)
            .ToDictionary(
                g => g.Key,
                g => g.Sum(x => x.Amount));
    }
}
