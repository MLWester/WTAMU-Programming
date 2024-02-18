namespace Homework5c;

class Program
{
    static void Main(string[] args)
    {
        createAccount();
    }

    static bool checkAge(int birth_year)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birth_year;
        return age >= 18;
    }

    static void createAccount()
    {
        Console.WriteLine("Welcome to the account creation process.");
        Console.WriteLine("Please enter your username:");
        string username = Console.ReadLine();

        Console.WriteLine("Please enter your password:");
        string password1 = Console.ReadLine();

        Console.WriteLine("Please re-enter your password:");
        string password2 = Console.ReadLine();

        if (password1 != password2)
        {
            Console.WriteLine("Passwords do not match. Account creation failed.");
            return;
        }

        Console.WriteLine("Please enter your birth year:");
        int birthYear;
        if (!int.TryParse(Console.ReadLine(), out birthYear))
        {
            Console.WriteLine("Invalid birth year format. Account creation failed.");
            return;
        }

        if (checkAge(birthYear))
        {
            Console.WriteLine("Account is created successfully.");
        }
        else
        {
            Console.WriteLine("You must be at least 18 years old to create an account. Account creation failed.");
        }
    }
}