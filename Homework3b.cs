namespace Homework3b;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number (N): ");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int N))
        {
            PrintSquarePattern(N);
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
    static void PrintSquarePattern(int N)
    {


        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= N; j++)
            {
               
                Console.Write("#");
            }

            
            Console.WriteLine();
        }
    }
}
