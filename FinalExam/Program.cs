using FinalExam;

public class Program
{
    public static void Main(string[] args)
    {
        IAccount account;
        decimal amount;

        Console.WriteLine("Select account type (1 - Normal, 2 - Exchange):");

        int choice = int.Parse(Console.ReadLine());


        IAccountType accountType;
        if (choice == 1)
        {
            accountType = new NormalAccount();
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter exchange rate (default 1.0):");
            decimal.TryParse(Console.ReadLine(), out decimal rate);
            accountType = new ExchangeAccount();
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(choice), "Invalid choice.");
        }

        Console.WriteLine("Enter initial balance:");

        decimal initialBalance = decimal.Parse(Console.ReadLine());


        account = accountType.CreateAccount(initialBalance); // Leverage interface method

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Transfer");
            Console.WriteLine("3. Exit");

            Console.WriteLine("Enter your choice:");

            int option = int.Parse(Console.ReadLine());


            if (option == 1)
            {
                account.CheckBalance();
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter amount to transfer:");

                amount = decimal.Parse(Console.ReadLine());

                account.Transfer(amount);
            }
            else if (option == 3)
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
