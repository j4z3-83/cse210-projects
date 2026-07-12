
//made an affirmations class that displays a random affirmation for the user at the start of the program.
//increased the number of journal prompts from 5 to 10.
//added visual separators to make the program more readable.
using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator myPrompts = new PromptGenerator();
        Journal aJournal = new Journal();
        Affirmations affirmations = new Affirmations();   

        Console.WriteLine(new string('-', 50));    
        Console.WriteLine("Welcome to your journal.");
        Console.WriteLine("Your daily affirmation is.");
        string affirmation = affirmations.GetRandomAffirmation();
        Console.WriteLine(affirmation);
        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Please select one for the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
        
            if(choice == "1")
            {
                Entry anEntry = new Entry();  
                anEntry._date = DateTime.Now.ToString("MM/dd/yyyy"); 
                anEntry._promptText = myPrompts.GetRandomPrompt();
                Console.WriteLine("");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine(anEntry._promptText);
                Console.Write(">");
                anEntry._entryText = Console.ReadLine();

                aJournal.AddEntry(anEntry);
            }
            else if(choice == "2")
            {
                aJournal.DisplayAll();
            }
            else if(choice == "3")
            {
                Console.WriteLine("Please enter the file name you would like to load.");
                string filename = Console.ReadLine();
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Loading file.");
                aJournal.LoadFromFile(filename); 
            }
            else if(choice == "4")
            {
                Console.WriteLine("Please enter the file name you would like to save.");
                string filename = Console.ReadLine();
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Saving file.");
                aJournal.SaveToFile(filename);
            }
        }
    }
}