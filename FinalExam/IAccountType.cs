namespace FinalExam;

public interface IAccountType
{
    IAccount CreateAccount(decimal initialBalance, decimal exchangeRate = 1.0m);
    string GetAccountType();
}
