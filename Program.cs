namespace Homework4b;

class Program
{
    static void PrintTriangle(int N, string shape)
    {
        Console.WriteLine($"N = {N}, Shape = {shape}");

        if (shape == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else if (shape == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid shape. Please enter 'left' or 'right'.");
        }
    }

    static void Main(string[] args)
    {
        PrintTriangle(5, "left");
        Console.WriteLine();
        PrintTriangle(5, "right");
    }
}
