using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using Microsoft.VisualBasic.FileIO;

class Program
{
    static void Main(string[] args)
    {
        string book;;
        int  chapter;
        int verse;
        int endVerse;
        string text;   

        //begin program for user
        Console.Clear();
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("This is the Scripture Memorizer.");
        Console.Write("How many words would you link to blank out at a time?  ");
        int numberToHide = int.Parse(Console.ReadLine());
        string shouldQuit = "";
        
        ScriptureLibrary sl = new ScriptureLibrary();
        (book, chapter, verse, endVerse, text) = sl.GetScriptureReference();
        Reference reference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(reference, text);
        
        while(shouldQuit != "quit" && shouldQuit != "Quit" && shouldQuit != "QUIT")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press 'ENTER' to blank out words or 'quit' to exit.");
            shouldQuit = Console.ReadLine();

            scripture.HideRandomWords(numberToHide);
            bool completelyHidden = scripture.IsCompletelyHidden();
            if(completelyHidden)
            {
                shouldQuit = "quit";
            }
        }
        
        
        




        
        
    }
}