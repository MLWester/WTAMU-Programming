namespace Homework5a;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = int.Parse(Console.ReadLine());

        int largest = GetLargest(num1, num2);
        Console.WriteLine("The largest number is: " + largest);
    }

    static int GetLargest(int num1, int num2)
    {
        return Math.Max(num1, num2);
    }
}
