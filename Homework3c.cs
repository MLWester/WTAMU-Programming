namespace Homework3c;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int numRows))
        {
            PrintPattern(numRows);
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
     static void PrintPattern(int numRows)
    {
        for (int i = 1; i <= numRows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
