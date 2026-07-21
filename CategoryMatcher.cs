using System.Linq;

public class CategoryMatcher
{
    public void Apply(Transaction transaction)
    {
        foreach (var item in Categories.Rules)
        {
            if (item.Value.Any(word =>
                transaction.Description.Contains(word)))
            {
                transaction.Category = item.Key;
                return;
            }
        }

        transaction.Category = "Other";
    }
}
