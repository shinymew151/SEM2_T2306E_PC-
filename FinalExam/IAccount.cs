namespace FinalExam;

public interface IAccount
{   
    decimal Balance { get; }
    void CheckBalance();
    void Transfer(decimal amount);
}
