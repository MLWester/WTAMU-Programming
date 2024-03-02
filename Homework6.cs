namespace Homework6;

public class Professor
{
    public string profName;
    public string classTeach;
    private double salary;

    public Professor(string name, string course, double salary)
    {
        this.profName = name;
        this.classTeach = course;
        this.salary = salary;
    }

    public void SetSalary(double salary_amount)
    {
        this.salary = salary_amount;
    }

    public double GetSalary()
    {
        return this.salary;
    }

    public string GetName()
    {
        return this.profName;
    }

    public string GetClassTeach()
    {
        return this.classTeach;
    }
}

public class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade;

    public Student(string name, string course, double grade)
    {
        this.studentName = name;
        this.classEnroll = course;
        this.studentGrade = grade;
    }

    public void SetGrade(double newGrade)
    {
        this.studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return this.studentGrade;
    }

    public string GetName()
    {
        return this.studentName;
    }

    public string GetClassEnroll()
    {
        return this.classEnroll;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Professor professor1 = new Professor("Alice", "Java", 9000);
        Professor professor2 = new Professor("Bob", "Math", 8000);

        Student student1 = new Student("Lisa", "Java", 90);
        Student student2 = new Student("Tom", "Math", 80);

       
        Console.WriteLine("Professors:");
        Console.WriteLine("Name: " + professor1.GetName());
        Console.WriteLine("Class they teach: " + professor1.GetClassTeach());
        Console.WriteLine("Salary: " + professor1.GetSalary());

        Console.WriteLine();

        Console.WriteLine("Name: " + professor2.GetName());
        Console.WriteLine("Class they teach: " + professor2.GetClassTeach());
        Console.WriteLine("Salary: " + professor2.GetSalary());

        
        Console.WriteLine("\nStudents:");
        Console.WriteLine("Name: " + student1.GetName());
        Console.WriteLine("Class they're enrolled in: " + student1.GetClassEnroll());
        Console.WriteLine("Grade: " + student1.GetGrade());

        Console.WriteLine();

        Console.WriteLine("Name: " + student2.GetName());
        Console.WriteLine("Class they're enrolled in: " + student2.GetClassEnroll());
        Console.WriteLine("Grade: " + student2.GetGrade());

        
        double salaryDifference = Math.Abs(professor1.GetSalary() - professor2.GetSalary());
        Console.WriteLine("\nSalary difference between professors: " + salaryDifference);

        
        double totalGrade = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine("Total grade of Lisa’s Java course and Tom’s Math course: " + totalGrade);
    }
}