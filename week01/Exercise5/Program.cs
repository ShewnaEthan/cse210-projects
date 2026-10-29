using System;

class Program
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        static void DisplaysWelcome()
        {
            Console.WriteLine("Welcome To the program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string userNumString = Console.ReadLine();
            int userNum = int.Parse(userNumString);
            return userNum;
        }
        static int SquareNumber (int userNum)
        {
            int squaredNumber = userNum * userNum;
            return squaredNumber;
        }

        static void DisplayResults (string userName, int squaredNum)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNum}");
        }

        DisplaysWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNum = SquareNumber(number);
        DisplayResults(name, squaredNum);
    }
}