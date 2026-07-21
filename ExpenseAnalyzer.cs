using System.Collections.Generic;

public class ExpenseAnalyzer
{
    public void Analyze(
        List<Transaction> transactions)
    {
        var matcher =
            new CategoryMatcher();

        foreach (var transaction in transactions)
        {
            matcher.Apply(transaction);
        }
    }
}
