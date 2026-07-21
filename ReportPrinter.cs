using System;
using System.Collections.Generic;
using System.Linq;

public static class ReportPrinter
{
    public static void Print(
        List<Transaction> transactions)
    {
        Console.WriteLine(
            "Importing statement...\n");

        Console.WriteLine(
            $"Transactions loaded : {transactions.Count}\n");

        var stats =
            new Statistics().Build(transactions);

        foreach (var item in stats)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(
                $"${item.Value:F2}\n");
        }

        Console.WriteLine("-----------------------\n");

        Console.WriteLine(
            $"Total expenses : ${transactions.Sum(t=>t.Amount):F2}");
    }
}
