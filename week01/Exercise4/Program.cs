using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        string newNumString = "";
        int newNum = -1;
        while (newNum != 0)
        {
            Console.Write("What number would you like to add to the list?(Enter 0 to quit) ");
            newNumString =  Console.ReadLine();
            newNum = int.Parse(newNumString);
            if (newNum != 0)
            {
                numbers.Add(newNum);
            }
        }
        Console.WriteLine($"The sum of the numbers is {numbers.Sum()}");
        Console.WriteLine($"The average of the numbers is {numbers.Average()}");

        int largest = -2147483648;
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is {largest}");
    }
}