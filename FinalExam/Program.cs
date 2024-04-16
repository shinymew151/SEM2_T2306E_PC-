using FinalExam;

public class Program
{
    public static void Main(string[] args)
    {
        IAccount account;
        decimal amount;

        Console.WriteLine("Select account type (1 - Normal, 2 - Exchange):");
#pragma warning disable CS8604 // Possible null reference argument.
        int choice = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

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
#pragma warning disable CS8604 // Possible null reference argument.
        decimal initialBalance = decimal.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

        account = accountType.CreateAccount(initialBalance); // Leverage interface method

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Transfer");
            Console.WriteLine("3. Exit");

            Console.WriteLine("Enter your choice:");
#pragma warning disable CS8604 // Possible null reference argument.
            int option = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            if (option == 1)
            {
                account.CheckBalance();
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter amount to transfer:");
#pragma warning disable CS8604 // Possible null reference argument.
                amount = decimal.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
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
