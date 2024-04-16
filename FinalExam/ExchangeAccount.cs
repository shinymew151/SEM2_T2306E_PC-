namespace FinalExam;

public class ExchangeAccount : IAccount, IAccountType
{
    public decimal Balance { get; private set; }
    public decimal ExchangeRate { get; private set; }

    public ExchangeAccount(decimal initialBalance, decimal exchangeRate)
    {
        Balance = initialBalance;
        ExchangeRate = exchangeRate;
    }

    public ExchangeAccount()
    {
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Your balance: {Balance * ExchangeRate:C2}");
    }

    public void Transfer(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }

        Balance -= amount;
        Console.WriteLine($"Transferred: {(amount * ExchangeRate):C2} ({amount:C2} {ExchangeRate})");
        Console.WriteLine($"Your balance: {(Balance * ExchangeRate):C2}");
    }

    public string GetAccountType()
    {
        return "Exchange";
    }

    public IAccount CreateAccount(decimal initialBalance, decimal exchangeRate = 1.0m)
    {
        return new ExchangeAccount(initialBalance, exchangeRate);
    }
}
