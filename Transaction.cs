public class Transaction
{
    public string Description { get; }

    public decimal Amount { get; }

    public string Category { get; set; }

    public Transaction(
        string description,
        decimal amount)
    {
        Description = description;
        Amount = amount;
        Category = "";
    }
}
