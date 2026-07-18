//implemented Scripture Library file that reads a CSV containing multiple scriptures, and returns a random scripture.
//program allows the user to select how many words they would like to blank out at a time.
//The randomizer is set up in a way to prevent selecting a word that has already been blanked out.
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
        string _book;;
        int  _chapter;
        int _verse;
        int _endVerse;
        string _text;   

        //begin program for user
        Console.Clear();
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("This is the Scripture Memorizer.");
        Console.Write("How many words would you link to blank out at a time?  ");
        int numberToHide = int.Parse(Console.ReadLine());
        string shouldQuit = "";
        
        ScriptureLibrary sl = new ScriptureLibrary();
        (_book, _chapter, _verse, _endVerse, _text) = sl.GetScriptureReference();
        Reference reference = new Reference(_book, _chapter, _verse, _endVerse);
        Scripture scripture = new Scripture(reference, _text);
        
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