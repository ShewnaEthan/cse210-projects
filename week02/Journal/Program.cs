/*
This program acts like a digital Journal. It also allows you to save or load the journal.

Addtions:
I made it so each entry also asks and stores the the book the user is currently reading.
*/

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcom to the journal program!");
        Journal myJournal = new Journal();
        GeneratePrompt promptGenerator = new GeneratePrompt();
        int menuChoice = 0;
        while (menuChoice != 5) {
            Console.WriteLine("");
            Console.WriteLine("Please Select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            menuChoice = int.Parse(Console.ReadLine());
            if (menuChoice == 1)
            {
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
                Console.Write(">");
                newEntry._entryText = Console.ReadLine();
                Console.WriteLine("What book are you currently reading?");
                Console.Write(">");
                newEntry._entryBook = Console.ReadLine();
                myJournal.AddEntry(newEntry);
            }
            else if (menuChoice == 2)
            {
                myJournal.DisplayAll();
            }
            else if (menuChoice == 3)
            {
                Console.WriteLine("What is the name of the file you'd like to load from?");
                string fileName = Console.ReadLine();
                myJournal.LoadFromFile(fileName);
            }
            else if (menuChoice == 4)
            {
                Console.WriteLine("What is the name of the file you'd like to save to?");
                string fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
            }
            else if (menuChoice == 5)
            {
                Console.WriteLine("Exiting Program");
            }
            else
            {
                Console.WriteLine("Invaild menu option, please try again.");
            }
        }
    }
}