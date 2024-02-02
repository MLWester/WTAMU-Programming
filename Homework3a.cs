namespace Homework3a;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is prime.");
            }
            else
            {
                Console.WriteLine($"{number} is not prime.");
            }
        }
    }
    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false; 
            }
        }

        return true; 
    }
}
