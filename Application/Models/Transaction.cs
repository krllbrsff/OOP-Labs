namespace Domain.Models;

public class Transaction
{
    public Transaction(int accountId, decimal sum)
    {
        AccountId = accountId;
        Sum = sum;
    }

    public int AccountId { get; }
    public decimal Sum { get; }
}
