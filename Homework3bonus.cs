namespace Homework3bonus;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int N))
        {
            PrintPattern(N);
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
        
    }
    static void PrintPattern(int N)
    {
        for (int i = 1; i <= N; i++)
        {
            
            for (int spaces = 1; spaces <= N - i; spaces++)
            {
                Console.Write(" ");
            }

            
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }

            Console.WriteLine();
        }
    }
}
