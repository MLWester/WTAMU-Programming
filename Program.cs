namespace Homework4a;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int largestNumber = FindLargest(num1, num2);
        
        Console.WriteLine($"The largest number is: {largestNumber}");
    }

    static int FindLargest(int num1, int num2)
    {
        return num1 > num2 ? num1 : num2;
    }
}
