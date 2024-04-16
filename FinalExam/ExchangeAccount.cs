namespace FinalExam;

public class ExchangeAccount : IAccount
{
    public void CalculateBalancing1(Account account, ExchangeRate exchangeRate)
    {
        System.Console.WriteLine($"Your Exchange account balance is {account.balance* exchangeRate.exchangeRate}");
    }

    public void CalculateBalancing(Account account)
    {
        throw new NotImplementedException();
    }
}
