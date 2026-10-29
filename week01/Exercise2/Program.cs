using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percent? ");
        string gradeString = Console.ReadLine();
        int gradeInt = int.Parse(gradeString);

        if (gradeInt >= 90)
        {
            Console.WriteLine($"Your letter grade: A");
        }
        else if (gradeInt >= 80)
        {
            Console.WriteLine($"Your letter grade: B");
        }
        else if (gradeInt >= 70)
        {
            Console.WriteLine($"Your letter grade: C");
        }
        else if (gradeInt >= 60)
        {
            Console.WriteLine($"Your letter grade: D");
        }
        else
        {
            Console.WriteLine($"Your letter grade: F");
        }
        
        if (gradeInt >= 70)
        {
            Console.WriteLine("You passed the course, Congradulations!");
        }
        else
        {
            Console.WriteLine("You failed the course :(. You'll get it next time!");
        }
    }
}