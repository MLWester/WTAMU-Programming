namespace Homework2b;

class Program
{
    static void Main()
    {
        Console.Write("Please input the first number: ");
        int num1 = Convert.ToInt16(Console.ReadLine());
        
        Console.Write("Please input the second number: ");
        int num2 = Convert.ToInt16(Console.ReadLine());
        
        Console.Write("Please input the third number: ");
        int num3 = Convert.ToInt16(Console.ReadLine());
        
        int smallest;

        if (num1 <= num2 && num1 <= num3)
        {
            smallest = num1;
        }
        else if (num2 <= num1 && num2 <= num3)
        {
            smallest = num2;
        }
        else
        {
            smallest = num3;
        }

        Console.WriteLine($"The smallest number is: {smallest}");
    }
}
