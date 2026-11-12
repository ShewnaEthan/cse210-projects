using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        string userInput = "";
        bool completelyHidden = false;
        while (!completelyHidden && userInput != "quit")
        {
            completelyHidden = scripture.IsCompletelyHidden();
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            scripture.HideRandomWords(3);
            userInput = Console.ReadLine();
        }
    }
}