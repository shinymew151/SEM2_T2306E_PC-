namespace FinalExam;

public class NormalAccount : IAccount, IAccountType
{
    public decimal Balance { get; private set; }

    public NormalAccount(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public NormalAccount()
    {
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Your balance: {Balance}");
    }

    public void Transfer(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }

        Balance -= amount;
        Console.WriteLine($"Transferred: {amount}");
        Console.WriteLine($"Your balance: {Balance}");
    }

    public string GetAccountType()
    {
        return "Normal";
    }
    public IAccount CreateAccount(decimal initialBalance, decimal exchangeRate = 1.0m)
    {
        return new ExchangeAccount(initialBalance, exchangeRate);
    }
}

    

