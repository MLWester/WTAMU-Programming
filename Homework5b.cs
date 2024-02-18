namespace Homework5b;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third integer:");
        int num3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the fourth integer:");
        int num4 = int.Parse(Console.ReadLine());

        int largest = GetLargest(num1, num2, num3, num4);
        Console.WriteLine("The largest number is: " + largest);
    }

    static int GetLargest(int num1, int num2, int num3, int num4)
    {
        int largest1 = GetLargest(num1, num2);
        int largest2 = GetLargest(num3, num4);
        return GetLargest(largest1, largest2);
    }

    static int GetLargest(int num1, int num2)
    {
        return Math.Max(num1, num2);
    }
}
