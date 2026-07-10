using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator myPrompts = new PromptGenerator();
        Journal aJournal = new Journal();   
            
        Console.WriteLine("Hello World! This is the Journal Project.");
        string choice = "";
        while (choice != "5")
        {
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
                aJournal.LoadFromFile(filename); 
            }
            else if(choice == "4")
            {
                Console.WriteLine("Please enter the file name you would like to save.");
                string filename = Console.ReadLine();
                aJournal.SaveToFile(filename);
            }
        }
    }
}