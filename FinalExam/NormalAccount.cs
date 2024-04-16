namespace FinalExam;

public class NormalAccount : IAccount
{
    public void CalculateBalancing(Account account)
    {
        System.Console.WriteLine($"Your Normal Account: {account.balance}");
    }

    public void CalculateBalancing(Account account, ExchangeRate exchangeRate)
    {
        throw new NotImplementedException();
    }
}
