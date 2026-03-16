using System;

public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Group { get; set; }
    public int Point { get; set; }
    public bool IsGraduated { get; set; }

    /// Constructor
    public Student(string name, string surname, string group, int point, bool isGraduated)
    {
        Name = name;
        Surname = surname;
        Group = group;
        Point = point;
        IsGraduated = isGraduated;
    }

    /// a) GetInfo()
    public void GetInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Surname: {Surname}");
        Console.WriteLine($"Group: {Group}");
        Console.WriteLine($"Point: {Point}");
        Console.WriteLine($"Is Graduated: {IsGraduated}");
    }

    /// b) CheckGraduation()
    public void CheckGraduation()
    {
        if (IsGraduated)
        {
            Console.WriteLine("Telebe mezun olub.");
        }
        else
        {
            Console.WriteLine("Telebe hele məzun olmayib.");
        }
    }

    /// c) GetDiplomDegree()
    public void GetDiplomDegree()
    {
        if (Point < 65)
        {
            Console.WriteLine("Diplom derecesi: Zeif");
        }
        else if (Point >= 65 && Point <= 80)
        {
            Console.WriteLine("Diplom derecesi: Orta");
        }
        else if (Point > 80 && Point <= 90)
        {
            Console.WriteLine("Diplom derecesi: Yaxşi");
        }
        else if (Point > 90)
        {
            Console.WriteLine("Diplom derecesi: Ela");
        }
    }
}

// Test ucun Main metod
class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Ali", "Huseynov", "CS101", 85, true);

        student1.GetInfo();
        student1.CheckGraduation();
        student1.GetDiplomDegree();
    }
}
