namespace Homework2a;

class Program
{
    static void Main()
    {
        Console.Write("Enter a letter grade (A,B,C,D,F): ");
        char lettergrade = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        int gpaPoints = 0;

        if (lettergrade == 'A')
        {
            gpaPoints = 4;
        }
        else if (lettergrade == 'B')
        {
            gpaPoints = 3;
        }
         else if (lettergrade == 'C')
        {
            gpaPoints = 2;
        }
         else if (lettergrade == 'D')
        {
            gpaPoints = 1;
        }
         else if (lettergrade == 'F')
        {
            gpaPoints = 0;
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade! ");
            return;
        }
        Console.WriteLine($"GPA Points for {lettergrade}: {gpaPoints}");
    }
    
}
