using FinalExam;

public class Program
{
    public static void Main(string[] args)
    {
        Account account =new Account(){
            balance = 1000
        };
        ExchangeRate exchangeRate = new ExchangeRate(){
            exchangeRate = 2
        };
        NormalAccount normalAccount = new NormalAccount();
        normalAccount.CalculateBalancing(account);
        ExchangeAccount exchangeAccount = new ExchangeAccount();
        exchangeAccount.CalculateBalancing1(account, exchangeRate);
    }
}
